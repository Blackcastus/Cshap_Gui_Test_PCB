using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace Tool_Test_Ontrak_Pannel
{
    internal class DataProcessing
    {
        string mPathAppHantek6000 = @"C:\\Program Files (x86)\\Hantek6000\\Scope.exe";
        string mPathTesseract = @"..\\..\\..\\packages\\tessdata";
        Process mAppHantek;
        KalmanFilter pKalman;
        readonly double FreqMhzMin = 38.39;
        readonly double FreqMhzMax = 38.43;
        readonly double FreqKhzMin = 1.99;
        readonly double FreqKhzMax = 2.10;
        //private extern PcbBase pPcbBase03;
        //public Dictionary<string, (double freq, string unit)> mFrequencyRaw = new Dictionary<string, (double freq, string unit)>();
        //public Dictionary<string, (double freq, string unit)> mFrequencyKalman = new Dictionary<string, (double freq, string unit)>();

        public struct FreqStruct
        {
            public double freq;
            public string unit;

        }
        public DataStructure mFreqCh1;
        public DataStructure mFreqCh2;
        public DataStructure mFreqCh3;
        public DataStructure mFreqCh4;

        double mFreqRawCH1;
        double mFreqRawCH2;
        double mFreqRawCH3;
        double mFreqRawCH4;
        public DataProcessing()
        {
            pKalman = new KalmanFilter(initialValue: 0, initialCovariance: 1, processVariance: 0.1, measurementVariance: 0.5);
            mFreqCh1 = new DataStructure();
            mFreqCh2 = new DataStructure();
            mFreqCh3 = new DataStructure();
            mFreqCh4 = new DataStructure();
        }
        public void CaptureScreen()
        {

            Rectangle WorkingArea = Screen.PrimaryScreen.WorkingArea;

            int XPos = (WorkingArea.X + WorkingArea.Width / 2);
            int YPos = (WorkingArea.Y + (WorkingArea.Height - 190));
            int Width = (WorkingArea.Width / 2) - 250;
            int Height = 100;

            Rectangle captureRect = new Rectangle(XPos, YPos, Width, Height);

            // Create Bitmap with capture size
            Bitmap bitmap = new Bitmap(captureRect.Width, captureRect.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(new Point(XPos, YPos), Point.Empty, new Size(captureRect.Width, captureRect.Height));
            }
            string ImageContentText = DetectTextFromImage(bitmap);
            //tbDebug.Text = ImageContentText;
            //string ImageContentText = "CH3:Freq=38:58MHz CH4:Freq=2KHz CH1:Freq = 38.82MHz CH2:Freq = ***";
            PaserFrequency(ImageContentText);

        }
        public string DetectTextFromImage(Bitmap image)
        {
            string resultText = "";
            using (var engine = new TesseractEngine(mPathTesseract, "eng", EngineMode.Default))
            {
                // Convert Bitmap to Pix
                using (var pix = PixConverter.ToPix(image))
                {
                    // Detect content in image
                    using (var page = engine.Process(pix))
                    {
                        resultText = page.GetText();
                    }
                }
            }

            return resultText;
        }

        public bool PaserFrequency(string multiFreq)
        {
            bool status = true;
            Regex regex = new Regex(@"CH(?<channel>\d+):Freq\s*=\s*(?<freq>[^A-Za-z\s]+)(?<unit>[A-Za-z]+)?");

            var matches = regex.Matches(multiFreq);

            foreach (Match match in matches)
            {
                string channel = match.Groups["channel"].Value;
                string temp = match.Groups["freq"].Value;
                if (temp.Contains(":"))
                {
                    temp = temp.Replace(":", ".");
                }
                double number;
                double tmpfreq;
                if (double.TryParse(temp, NumberStyles.Any, CultureInfo.InvariantCulture, out number))
                {
                    //Console.WriteLine("Chuỗi hợp lệ. Giá trị số: " + number);
                    tmpfreq = double.Parse(temp);
                    string unit = match.Groups["unit"].Value;
                    //mFrequencyRaw[channel] = (freq, unit);
                    switch (channel)
                    {
                        case "1":

                            mFreqRawCH1 = tmpfreq;
                            mFreqCh1.mUnit = unit;
                            break;

                        case "2":
                            mFreqRawCH2 = tmpfreq;
                            mFreqCh2.mUnit = unit;

                            break;
                        case "3":
                            mFreqRawCH3 = tmpfreq;
                            mFreqCh3.mUnit = unit;

                            break;
                        case "4":
                            mFreqRawCH4 = tmpfreq;
                            mFreqCh4.mUnit = unit;

                            break;
                        default:
                            break;
                    }    
                }
            }
            FreqKalman();
            return status;
        }

        public void OpenOscilloscope()
        {
            mAppHantek = Process.Start(mPathAppHantek6000);
            mAppHantek.WaitForInputIdle();
            if (mAppHantek != null && !mAppHantek.HasExited)
            {
                IntPtr hWnd = mAppHantek.MainWindowHandle;

                // get size main monitor
                Rectangle WorkingArea = Screen.PrimaryScreen.WorkingArea;
                int newWidth = WorkingArea.Width / 2;
                int newHeight = WorkingArea.Height;
                int newLeft = WorkingArea.Left + newWidth;
                int newTop = WorkingArea.Top;

                // 
                //MoveWindow(hWnd, newLeft, newTop, newWidth, newHeight, true);

                // update status
                //mStatusConnectOsci = true;
            }
        }
        public bool CloseOscilloscope()
        {
            if (mAppHantek != null && !mAppHantek.HasExited)
            {
                // update status
                //mStatusConnectOsci = false;
                mAppHantek.Kill();
            }
            return true;

        }
        
        public void UpdateLable(Label label, bool condition)
        {
            label.Text = condition ? "PASS" : "FAIL";
            label.BackColor = condition ? Color.Green : Color.Red;
        }
        
        public void UpdateButtonTextColor(Button button, Color color)
        {
            button.ForeColor = color;
        }

        private void FreqKalman()
        {
            mFreqCh1.mValue = pKalman.Update(mFreqRawCH1);
            mFreqCh2.mValue = pKalman.Update(mFreqRawCH2);
            mFreqCh3.mValue = pKalman.Update(mFreqRawCH3);
            mFreqCh4.mValue = pKalman.Update(mFreqRawCH4);
            //mFreqCh1.mValue = (mFreqRawCH1);
            //mFreqCh2.mValue = (mFreqRawCH2);
            //mFreqCh3.mValue = (mFreqRawCH3);
            //mFreqCh4.mValue = (mFreqRawCH4);

            if (mFreqCh1.mValue > 0.9 && mFreqCh1.mValue < 1.1)
            {
                mFreqCh1.mStatus = true;
            }
            else
            {
                mFreqCh1.mStatus = false;
            }

            if (mFreqCh2.mValue < FreqKhzMax && mFreqCh2.mValue > FreqKhzMin)
            {
                mFreqCh2.mStatus = true;
            }
            else
            {
                mFreqCh2.mStatus = false;
            }

            if (mFreqCh3.mValue < FreqMhzMax && mFreqCh3.mValue > FreqMhzMin)
            {
                mFreqCh3.mStatus = true;
            }
            else
            {
                mFreqCh3.mStatus = false;
            }

            if (mFreqCh4.mValue < FreqKhzMax && mFreqCh4.mValue > FreqKhzMin)
            {
                mFreqCh4.mStatus = true;
            }
            else
            {
                mFreqCh4.mStatus = false;
            }
        }
    }
}
