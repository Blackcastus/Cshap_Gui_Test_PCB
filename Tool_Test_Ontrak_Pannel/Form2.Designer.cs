namespace Tool_Test_Ontrak_Pannel
{
    partial class fOscilloscope
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btSwitchPannel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.tbPeriod = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbVmax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboDuty = new System.Windows.Forms.TextBox();
            this.lbFreqUnit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboFreq = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.tboPPulseWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tboNPulseWidth = new System.Windows.Forms.TextBox();
            this.tbVmin = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbVpp = new System.Windows.Forms.TextBox();
            this.lbVpp = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSettingOsci = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbScale = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbVolt = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbChannel = new System.Windows.Forms.ComboBox();
            this.checkboxOnOff = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbVoltType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbTime_Div = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbTriggerSlope = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbTriggerSource = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbTriggerSweep = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbTriggerMode = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSwitchPannel
            // 
            this.btSwitchPannel.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btSwitchPannel.Location = new System.Drawing.Point(12, 12);
            this.btSwitchPannel.Name = "btSwitchPannel";
            this.btSwitchPannel.Size = new System.Drawing.Size(102, 40);
            this.btSwitchPannel.TabIndex = 19;
            this.btSwitchPannel.Text = "Pannel";
            this.btSwitchPannel.UseVisualStyleBackColor = true;
            this.btSwitchPannel.Click += new System.EventHandler(this.btSwitchPannel_click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDisconnect);
            this.panel1.Controls.Add(this.btConnect);
            this.panel1.Location = new System.Drawing.Point(376, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 64);
            this.panel1.TabIndex = 20;
            // 
            // btDisconnect
            // 
            this.btDisconnect.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btDisconnect.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btDisconnect.Location = new System.Drawing.Point(173, 13);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(102, 40);
            this.btDisconnect.TabIndex = 21;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btConnect.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btConnect.Location = new System.Drawing.Point(35, 13);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(102, 40);
            this.btConnect.TabIndex = 20;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(711, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 601);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbPeriod, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label27, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label25, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label24, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label23, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbVmax, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tboDuty, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbFreqUnit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboFreq, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lable, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tboPPulseWidth, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tboNPulseWidth, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbVmin, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbVpp, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbVpp, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 558);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 216);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 18);
            this.label26.TabIndex = 27;
            this.label26.Text = "Period";
            // 
            // tbPeriod
            // 
            this.tbPeriod.Location = new System.Drawing.Point(126, 219);
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(100, 20);
            this.tbPeriod.TabIndex = 26;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(249, 216);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 18);
            this.label27.TabIndex = 25;
            this.label27.Text = "mS";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(249, 189);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 18);
            this.label25.TabIndex = 24;
            this.label25.Text = "mV";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(249, 162);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 18);
            this.label24.TabIndex = 23;
            this.label24.Text = "mV";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(249, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 18);
            this.label23.TabIndex = 22;
            this.label23.Text = "mV";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 18);
            this.label20.TabIndex = 16;
            this.label20.Text = "Vmax:";
            // 
            // tbVmax
            // 
            this.tbVmax.Location = new System.Drawing.Point(126, 138);
            this.tbVmax.Name = "tbVmax";
            this.tbVmax.Size = new System.Drawing.Size(100, 20);
            this.tbVmax.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(249, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Freq:";
            // 
            // tboDuty
            // 
            this.tboDuty.Location = new System.Drawing.Point(126, 57);
            this.tboDuty.Name = "tboDuty";
            this.tboDuty.Size = new System.Drawing.Size(100, 20);
            this.tboDuty.TabIndex = 3;
            // 
            // lbFreqUnit
            // 
            this.lbFreqUnit.AutoSize = true;
            this.lbFreqUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFreqUnit.Location = new System.Drawing.Point(249, 27);
            this.lbFreqUnit.Name = "lbFreqUnit";
            this.lbFreqUnit.Size = new System.Drawing.Size(26, 18);
            this.lbFreqUnit.TabIndex = 1;
            this.lbFreqUnit.Text = "Hz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Duty Cycle :";
            // 
            // tboFreq
            // 
            this.tboFreq.Location = new System.Drawing.Point(126, 30);
            this.tboFreq.Name = "tboFreq";
            this.tboFreq.Size = new System.Drawing.Size(100, 20);
            this.tboFreq.TabIndex = 0;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(3, 81);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(108, 18);
            this.lable.TabIndex = 9;
            this.lable.Text = "Pulse Width +:";
            // 
            // tboPPulseWidth
            // 
            this.tboPPulseWidth.Location = new System.Drawing.Point(126, 84);
            this.tboPPulseWidth.Name = "tboPPulseWidth";
            this.tboPPulseWidth.Size = new System.Drawing.Size(100, 20);
            this.tboPPulseWidth.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pulse Width -:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "%";
            // 
            // tboNPulseWidth
            // 
            this.tboNPulseWidth.Location = new System.Drawing.Point(126, 111);
            this.tboNPulseWidth.Name = "tboNPulseWidth";
            this.tboNPulseWidth.Size = new System.Drawing.Size(100, 20);
            this.tboNPulseWidth.TabIndex = 13;
            // 
            // tbVmin
            // 
            this.tbVmin.Location = new System.Drawing.Point(126, 165);
            this.tbVmin.Name = "tbVmin";
            this.tbVmin.Size = new System.Drawing.Size(100, 20);
            this.tbVmin.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 162);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 18);
            this.label21.TabIndex = 18;
            this.label21.Text = "Vmin:";
            // 
            // tbVpp
            // 
            this.tbVpp.Location = new System.Drawing.Point(126, 192);
            this.tbVpp.Name = "tbVpp";
            this.tbVpp.Size = new System.Drawing.Size(100, 20);
            this.tbVpp.TabIndex = 21;
            // 
            // lbVpp
            // 
            this.lbVpp.AutoSize = true;
            this.lbVpp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVpp.Location = new System.Drawing.Point(3, 189);
            this.lbVpp.Name = "lbVpp";
            this.lbVpp.Size = new System.Drawing.Size(41, 18);
            this.lbVpp.TabIndex = 20;
            this.lbVpp.Text = "Vpp:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSettingOsci);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(1040, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 601);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // btSettingOsci
            // 
            this.btSettingOsci.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btSettingOsci.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btSettingOsci.Location = new System.Drawing.Point(6, 426);
            this.btSettingOsci.Name = "btSettingOsci";
            this.btSettingOsci.Size = new System.Drawing.Size(102, 40);
            this.btSettingOsci.TabIndex = 37;
            this.btSettingOsci.Text = "Setting Osci";
            this.btSettingOsci.UseVisualStyleBackColor = true;
            this.btSettingOsci.Click += new System.EventHandler(this.btSettingOsci_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbScale);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.cbVolt);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.cbChannel);
            this.groupBox6.Controls.Add(this.checkboxOnOff);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.cbVoltType);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(6, 116);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(307, 133);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Veritical";
            // 
            // cbScale
            // 
            this.cbScale.FormattingEnabled = true;
            this.cbScale.Location = new System.Drawing.Point(106, 100);
            this.cbScale.Name = "cbScale";
            this.cbScale.Size = new System.Drawing.Size(121, 21);
            this.cbScale.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F);
            this.label16.Location = new System.Drawing.Point(14, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "Scale:";
            // 
            // cbVolt
            // 
            this.cbVolt.FormattingEnabled = true;
            this.cbVolt.Location = new System.Drawing.Point(106, 73);
            this.cbVolt.Name = "cbVolt";
            this.cbVolt.Size = new System.Drawing.Size(121, 21);
            this.cbVolt.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F);
            this.label12.Location = new System.Drawing.Point(14, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Channel:";
            // 
            // cbChannel
            // 
            this.cbChannel.FormattingEnabled = true;
            this.cbChannel.Location = new System.Drawing.Point(106, 19);
            this.cbChannel.Name = "cbChannel";
            this.cbChannel.Size = new System.Drawing.Size(121, 21);
            this.cbChannel.TabIndex = 28;
            // 
            // checkboxOnOff
            // 
            this.checkboxOnOff.AutoSize = true;
            this.checkboxOnOff.Location = new System.Drawing.Point(242, 21);
            this.checkboxOnOff.Name = "checkboxOnOff";
            this.checkboxOnOff.Size = new System.Drawing.Size(59, 17);
            this.checkboxOnOff.TabIndex = 33;
            this.checkboxOnOff.Text = "On/Off";
            this.checkboxOnOff.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F);
            this.label13.Location = new System.Drawing.Point(14, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Volt Type:";
            // 
            // cbVoltType
            // 
            this.cbVoltType.FormattingEnabled = true;
            this.cbVoltType.Location = new System.Drawing.Point(106, 46);
            this.cbVoltType.Name = "cbVoltType";
            this.cbVoltType.Size = new System.Drawing.Size(121, 21);
            this.cbVoltType.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F);
            this.label14.Location = new System.Drawing.Point(14, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "Volt:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbTime_Div);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.cbFormat);
            this.groupBox5.Location = new System.Drawing.Point(6, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(307, 87);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Horizontal";
            // 
            // cbTime_Div
            // 
            this.cbTime_Div.FormattingEnabled = true;
            this.cbTime_Div.Location = new System.Drawing.Point(106, 29);
            this.cbTime_Div.Name = "cbTime_Div";
            this.cbTime_Div.Size = new System.Drawing.Size(121, 21);
            this.cbTime_Div.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.Location = new System.Drawing.Point(14, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Time/DIV:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F);
            this.label11.Location = new System.Drawing.Point(14, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Format:";
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(106, 56);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(121, 21);
            this.cbFormat.TabIndex = 26;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbTriggerSlope);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.cbTriggerSource);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.cbTriggerSweep);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.cbTriggerMode);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(6, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 165);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trigger";
            // 
            // cbTriggerSlope
            // 
            this.cbTriggerSlope.FormattingEnabled = true;
            this.cbTriggerSlope.Location = new System.Drawing.Point(106, 104);
            this.cbTriggerSlope.Name = "cbTriggerSlope";
            this.cbTriggerSlope.Size = new System.Drawing.Size(121, 21);
            this.cbTriggerSlope.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F);
            this.label19.Location = new System.Drawing.Point(14, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 15);
            this.label19.TabIndex = 39;
            this.label19.Text = "Trigger Slope:";
            // 
            // cbTriggerSource
            // 
            this.cbTriggerSource.FormattingEnabled = true;
            this.cbTriggerSource.Location = new System.Drawing.Point(106, 77);
            this.cbTriggerSource.Name = "cbTriggerSource";
            this.cbTriggerSource.Size = new System.Drawing.Size(121, 21);
            this.cbTriggerSource.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9F);
            this.label18.Location = new System.Drawing.Point(14, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 15);
            this.label18.TabIndex = 37;
            this.label18.Text = "Trigger Source:";
            // 
            // cbTriggerSweep
            // 
            this.cbTriggerSweep.FormattingEnabled = true;
            this.cbTriggerSweep.Location = new System.Drawing.Point(106, 50);
            this.cbTriggerSweep.Name = "cbTriggerSweep";
            this.cbTriggerSweep.Size = new System.Drawing.Size(121, 21);
            this.cbTriggerSweep.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F);
            this.label17.Location = new System.Drawing.Point(14, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 15);
            this.label17.TabIndex = 35;
            this.label17.Text = "Trigger Sweep:";
            // 
            // cbTriggerMode
            // 
            this.cbTriggerMode.FormattingEnabled = true;
            this.cbTriggerMode.Location = new System.Drawing.Point(106, 23);
            this.cbTriggerMode.Name = "cbTriggerMode";
            this.cbTriggerMode.Size = new System.Drawing.Size(121, 21);
            this.cbTriggerMode.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F);
            this.label15.Location = new System.Drawing.Point(14, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "Trigger Mode:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Location = new System.Drawing.Point(12, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 522);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graph View";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 14);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CH1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(681, 497);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // fOscilloscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 617);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSwitchPannel);
            this.Name = "fOscilloscope";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oscilloscope";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSwitchPannel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboDuty;
        private System.Windows.Forms.Label lbFreqUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboFreq;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox tboPPulseWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboNPulseWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTime_Div;
        private System.Windows.Forms.ComboBox cbVolt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbVoltType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbChannel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkboxOnOff;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbTriggerMode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbScale;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbTriggerSweep;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbTriggerSlope;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbTriggerSource;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbVmax;
        private System.Windows.Forms.TextBox tbVmin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbVpp;
        private System.Windows.Forms.Label lbVpp;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbPeriod;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btSettingOsci;
    }
}