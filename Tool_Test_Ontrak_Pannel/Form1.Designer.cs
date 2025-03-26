using System.Drawing;

namespace Tool_Test_Ontrak_Pannel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.lbComStatus = new System.Windows.Forms.Label();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBaseCurrent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbBase3v3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBase5V = new System.Windows.Forms.Label();
            this.tboxBase3v3 = new System.Windows.Forms.TextBox();
            this.tboxBase5v = new System.Windows.Forms.TextBox();
            this.tboxBaseCurrent = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbSync48v = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSync3v3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbSync5v = new System.Windows.Forms.Label();
            this.tboSync3v3 = new System.Windows.Forms.TextBox();
            this.tboSync5v = new System.Windows.Forms.TextBox();
            this.tboSync48v = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbEtagCurrRun = new System.Windows.Forms.Label();
            this.tboEtagCurRun = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.lbEtag3v3 = new System.Windows.Forms.Label();
            this.lbEtagCurrSleep = new System.Windows.Forms.Label();
            this.tboEtag3v3 = new System.Windows.Forms.TextBox();
            this.tboEtagCurSleep = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCom
            // 
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(120, 21);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(121, 21);
            this.cboCom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate:";
            // 
            // cboBaud
            // 
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Location = new System.Drawing.Point(120, 50);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(121, 21);
            this.cboBaud.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cboCom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboBaud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(289, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 115);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btRefresh);
            this.groupBox3.Controls.Add(this.lbComStatus);
            this.groupBox3.Controls.Add(this.btDisconnect);
            this.groupBox3.Controls.Add(this.btConnect);
            this.groupBox3.Location = new System.Drawing.Point(24, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(111, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Connection Status";
            // 
            // btRefresh
            // 
            this.btRefresh.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btRefresh.Location = new System.Drawing.Point(6, 69);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 25);
            this.btRefresh.TabIndex = 9;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // lbComStatus
            // 
            this.lbComStatus.AutoSize = true;
            this.lbComStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComStatus.ForeColor = System.Drawing.Color.Red;
            this.lbComStatus.Location = new System.Drawing.Point(126, 56);
            this.lbComStatus.Name = "lbComStatus";
            this.lbComStatus.Size = new System.Drawing.Size(93, 20);
            this.lbComStatus.TabIndex = 8;
            this.lbComStatus.Text = "Disconnected";
            // 
            // btDisconnect
            // 
            this.btDisconnect.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btDisconnect.Location = new System.Drawing.Point(6, 43);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(75, 25);
            this.btDisconnect.TabIndex = 7;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btConnect.Location = new System.Drawing.Point(6, 17);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 25);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "ONTRAK TEST PANEL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Tool_Test_Ontrak_Pannel.Properties.Resources.Logo_Ontrak_140_80;
            this.pictureBox1.Location = new System.Drawing.Point(24, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel1);
            this.groupBox6.Location = new System.Drawing.Point(453, 411);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(257, 156);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BASE-06";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.1039F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.8961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbBaseCurrent, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBase3v3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbBase5V, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tboxBase3v3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tboxBase5v, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tboxBaseCurrent, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 122);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Volt 3.3 (V)";
            // 
            // lbBaseCurrent
            // 
            this.lbBaseCurrent.AutoSize = true;
            this.lbBaseCurrent.BackColor = System.Drawing.Color.Red;
            this.lbBaseCurrent.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaseCurrent.ForeColor = System.Drawing.Color.Black;
            this.lbBaseCurrent.Location = new System.Drawing.Point(161, 80);
            this.lbBaseCurrent.Name = "lbBaseCurrent";
            this.lbBaseCurrent.Size = new System.Drawing.Size(38, 20);
            this.lbBaseCurrent.TabIndex = 8;
            this.lbBaseCurrent.Text = "FAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Volt 5 (V)";
            // 
            // lbBase3v3
            // 
            this.lbBase3v3.AutoSize = true;
            this.lbBase3v3.BackColor = System.Drawing.Color.Red;
            this.lbBase3v3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase3v3.ForeColor = System.Drawing.Color.Black;
            this.lbBase3v3.Location = new System.Drawing.Point(161, 0);
            this.lbBase3v3.Name = "lbBase3v3";
            this.lbBase3v3.Size = new System.Drawing.Size(38, 20);
            this.lbBase3v3.TabIndex = 6;
            this.lbBase3v3.Text = "FAIL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Current  (mA)";
            // 
            // lbBase5V
            // 
            this.lbBase5V.AutoSize = true;
            this.lbBase5V.BackColor = System.Drawing.Color.Red;
            this.lbBase5V.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase5V.ForeColor = System.Drawing.Color.Black;
            this.lbBase5V.Location = new System.Drawing.Point(161, 40);
            this.lbBase5V.Name = "lbBase5V";
            this.lbBase5V.Size = new System.Drawing.Size(38, 20);
            this.lbBase5V.TabIndex = 7;
            this.lbBase5V.Text = "FAIL";
            // 
            // tboxBase3v3
            // 
            this.tboxBase3v3.Location = new System.Drawing.Point(76, 3);
            this.tboxBase3v3.Name = "tboxBase3v3";
            this.tboxBase3v3.Size = new System.Drawing.Size(66, 20);
            this.tboxBase3v3.TabIndex = 0;
            // 
            // tboxBase5v
            // 
            this.tboxBase5v.Location = new System.Drawing.Point(76, 43);
            this.tboxBase5v.Name = "tboxBase5v";
            this.tboxBase5v.Size = new System.Drawing.Size(66, 20);
            this.tboxBase5v.TabIndex = 2;
            // 
            // tboxBaseCurrent
            // 
            this.tboxBaseCurrent.Location = new System.Drawing.Point(76, 83);
            this.tboxBaseCurrent.Name = "tboxBaseCurrent";
            this.tboxBaseCurrent.Size = new System.Drawing.Size(66, 20);
            this.tboxBaseCurrent.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel2);
            this.groupBox7.Location = new System.Drawing.Point(450, 87);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(257, 156);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SYNC-03";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.1039F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.8961F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbSync48v, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbSync3v3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbSync5v, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tboSync3v3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tboSync5v, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tboSync48v, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(225, 122);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Volt 3.3 (V)";
            // 
            // lbSync48v
            // 
            this.lbSync48v.AutoSize = true;
            this.lbSync48v.BackColor = System.Drawing.Color.Red;
            this.lbSync48v.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSync48v.ForeColor = System.Drawing.Color.Black;
            this.lbSync48v.Location = new System.Drawing.Point(161, 80);
            this.lbSync48v.Name = "lbSync48v";
            this.lbSync48v.Size = new System.Drawing.Size(38, 20);
            this.lbSync48v.TabIndex = 8;
            this.lbSync48v.Text = "FAIL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Volt 5 (V)";
            // 
            // lbSync3v3
            // 
            this.lbSync3v3.AutoSize = true;
            this.lbSync3v3.BackColor = System.Drawing.Color.Red;
            this.lbSync3v3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSync3v3.ForeColor = System.Drawing.Color.Black;
            this.lbSync3v3.Location = new System.Drawing.Point(161, 0);
            this.lbSync3v3.Name = "lbSync3v3";
            this.lbSync3v3.Size = new System.Drawing.Size(38, 20);
            this.lbSync3v3.TabIndex = 6;
            this.lbSync3v3.Text = "FAIL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Volt 48 (V)";
            // 
            // lbSync5v
            // 
            this.lbSync5v.AutoSize = true;
            this.lbSync5v.BackColor = System.Drawing.Color.Red;
            this.lbSync5v.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSync5v.ForeColor = System.Drawing.Color.Black;
            this.lbSync5v.Location = new System.Drawing.Point(161, 40);
            this.lbSync5v.Name = "lbSync5v";
            this.lbSync5v.Size = new System.Drawing.Size(38, 20);
            this.lbSync5v.TabIndex = 7;
            this.lbSync5v.Text = "FAIL";
            // 
            // tboSync3v3
            // 
            this.tboSync3v3.Location = new System.Drawing.Point(76, 3);
            this.tboSync3v3.Name = "tboSync3v3";
            this.tboSync3v3.Size = new System.Drawing.Size(66, 20);
            this.tboSync3v3.TabIndex = 0;
            // 
            // tboSync5v
            // 
            this.tboSync5v.Location = new System.Drawing.Point(76, 43);
            this.tboSync5v.Name = "tboSync5v";
            this.tboSync5v.Size = new System.Drawing.Size(66, 20);
            this.tboSync5v.TabIndex = 2;
            // 
            // tboSync48v
            // 
            this.tboSync48v.Location = new System.Drawing.Point(76, 83);
            this.tboSync48v.Name = "tboSync48v";
            this.tboSync48v.Size = new System.Drawing.Size(66, 20);
            this.tboSync48v.TabIndex = 4;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel3);
            this.groupBox8.Location = new System.Drawing.Point(450, 249);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(257, 156);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ETAG-06";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.1039F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.8961F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.Controls.Add(this.lbEtagCurrRun, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.tboEtagCurRun, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lable, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbEtag3v3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbEtagCurrSleep, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tboEtag3v3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tboEtagCurSleep, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(16, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(225, 122);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // lbEtagCurrRun
            // 
            this.lbEtagCurrRun.AutoSize = true;
            this.lbEtagCurrRun.BackColor = System.Drawing.Color.Red;
            this.lbEtagCurrRun.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtagCurrRun.ForeColor = System.Drawing.Color.Black;
            this.lbEtagCurrRun.Location = new System.Drawing.Point(161, 80);
            this.lbEtagCurrRun.Name = "lbEtagCurrRun";
            this.lbEtagCurrRun.Size = new System.Drawing.Size(38, 20);
            this.lbEtagCurrRun.TabIndex = 10;
            this.lbEtagCurrRun.Text = "FAIL";
            // 
            // tboEtagCurRun
            // 
            this.tboEtagCurRun.Location = new System.Drawing.Point(76, 83);
            this.tboEtagCurRun.Name = "tboEtagCurRun";
            this.tboEtagCurRun.Size = new System.Drawing.Size(66, 20);
            this.tboEtagCurRun.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 26);
            this.label15.TabIndex = 8;
            this.label15.Text = "Current Run (mA)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Volt 3.3 (V)";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(3, 40);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(58, 26);
            this.lable.TabIndex = 3;
            this.lable.Text = "Current Sleep (mA)";
            // 
            // lbEtag3v3
            // 
            this.lbEtag3v3.AutoSize = true;
            this.lbEtag3v3.BackColor = System.Drawing.Color.Red;
            this.lbEtag3v3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtag3v3.ForeColor = System.Drawing.Color.Black;
            this.lbEtag3v3.Location = new System.Drawing.Point(161, 0);
            this.lbEtag3v3.Name = "lbEtag3v3";
            this.lbEtag3v3.Size = new System.Drawing.Size(38, 20);
            this.lbEtag3v3.TabIndex = 6;
            this.lbEtag3v3.Text = "FAIL";
            // 
            // lbEtagCurrSleep
            // 
            this.lbEtagCurrSleep.AutoSize = true;
            this.lbEtagCurrSleep.BackColor = System.Drawing.Color.Red;
            this.lbEtagCurrSleep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtagCurrSleep.ForeColor = System.Drawing.Color.Black;
            this.lbEtagCurrSleep.Location = new System.Drawing.Point(161, 40);
            this.lbEtagCurrSleep.Name = "lbEtagCurrSleep";
            this.lbEtagCurrSleep.Size = new System.Drawing.Size(38, 20);
            this.lbEtagCurrSleep.TabIndex = 7;
            this.lbEtagCurrSleep.Text = "FAIL";
            // 
            // tboEtag3v3
            // 
            this.tboEtag3v3.Location = new System.Drawing.Point(76, 3);
            this.tboEtag3v3.Name = "tboEtag3v3";
            this.tboEtag3v3.Size = new System.Drawing.Size(66, 20);
            this.tboEtag3v3.TabIndex = 0;
            // 
            // tboEtagCurSleep
            // 
            this.tboEtagCurSleep.Location = new System.Drawing.Point(76, 43);
            this.tboEtagCurSleep.Name = "tboEtagCurSleep";
            this.tboEtagCurSleep.Size = new System.Drawing.Size(66, 20);
            this.tboEtagCurSleep.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 604);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lbComStatus;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxBase3v3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxBaseCurrent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxBase5v;
        private System.Windows.Forms.Label lbBase3v3;
        private System.Windows.Forms.Label lbBase5V;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbBaseCurrent;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSync48v;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbSync3v3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSync5v;
        private System.Windows.Forms.TextBox tboSync3v3;
        private System.Windows.Forms.TextBox tboSync5v;
        private System.Windows.Forms.TextBox tboSync48v;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lbEtag3v3;
        private System.Windows.Forms.Label lbEtagCurrSleep;
        private System.Windows.Forms.TextBox tboEtag3v3;
        private System.Windows.Forms.TextBox tboEtagCurSleep;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbEtagCurrRun;
        private System.Windows.Forms.TextBox tboEtagCurRun;
    }
}

