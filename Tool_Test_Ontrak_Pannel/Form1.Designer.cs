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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.lbComStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxBase5v = new System.Windows.Forms.TextBox();
            this.tboxBase3v3 = new System.Windows.Forms.TextBox();
            this.lbBaseCurrent = new System.Windows.Forms.Label();
            this.lbBase5V = new System.Windows.Forms.Label();
            this.lbBase3v3 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tboxBaseCurrent = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tboSync48v = new System.Windows.Forms.TextBox();
            this.tboSync5v = new System.Windows.Forms.TextBox();
            this.lbSync48v = new System.Windows.Forms.Label();
            this.lbSync5v = new System.Windows.Forms.Label();
            this.lbSync3v3 = new System.Windows.Forms.Label();
            this.tboSync3v3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tboEtagCurRun = new System.Windows.Forms.TextBox();
            this.tboEtagCurSleep = new System.Windows.Forms.TextBox();
            this.tboEtag3v3 = new System.Windows.Forms.TextBox();
            this.lbEtagCurrRun = new System.Windows.Forms.Label();
            this.lbEtagCurrSleep = new System.Windows.Forms.Label();
            this.lbEtag3v3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.cboCom.Location = new System.Drawing.Point(138, 3);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(121, 21);
            this.cboCom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate:";
            // 
            // cboBaud
            // 
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Location = new System.Drawing.Point(138, 40);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(121, 21);
            this.cboBaud.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Options";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboCom, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboBaud, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(271, 75);
            this.tableLayoutPanel4.TabIndex = 6;
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
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            this.groupBox3.Location = new System.Drawing.Point(12, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 118);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btConnect, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btDisconnect, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btRefresh, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbComStatus, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(271, 92);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(138, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Connection Status";
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btConnect.Location = new System.Drawing.Point(3, 3);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 25);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btDisconnect.Location = new System.Drawing.Point(3, 34);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(75, 25);
            this.btDisconnect.TabIndex = 7;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btRefresh.Location = new System.Drawing.Point(3, 65);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 24);
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
            this.lbComStatus.Location = new System.Drawing.Point(138, 31);
            this.lbComStatus.Name = "lbComStatus";
            this.lbComStatus.Size = new System.Drawing.Size(93, 20);
            this.lbComStatus.TabIndex = 8;
            this.lbComStatus.Text = "Disconnected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "ONTRAK TEST PANEL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Tool_Test_Ontrak_Pannel.Properties.Resources.Logo_Ontrak_140_80;
            this.pictureBox1.Location = new System.Drawing.Point(12, 82);
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
            this.groupBox6.Location = new System.Drawing.Point(767, 75);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(451, 262);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BASE-06";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5F));
            this.tableLayoutPanel1.Controls.Add(this.label20, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label26, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label25, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tboxBase5v, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboxBase3v3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBaseCurrent, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbBase5V, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbBase3v3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tboxBaseCurrent, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(439, 226);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(222, 1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 18);
            this.label20.TabIndex = 20;
            this.label20.Text = "VALUE";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label22.Location = new System.Drawing.Point(4, 1);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 18);
            this.label22.TabIndex = 19;
            this.label22.Text = "TEST POINT";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Red;
            this.label26.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(340, 189);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.label26.Name = "label26";
            this.label26.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.label26.Size = new System.Drawing.Size(93, 28);
            this.label26.TabIndex = 24;
            this.label26.Text = "FAIL";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Red;
            this.label25.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(340, 152);
            this.label25.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.label25.Name = "label25";
            this.label25.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.label25.Size = new System.Drawing.Size(93, 28);
            this.label25.TabIndex = 23;
            this.label25.Text = "FAIL";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(224, 151);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 29);
            this.textBox3.TabIndex = 21;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label21.Location = new System.Drawing.Point(338, 1);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 18);
            this.label21.TabIndex = 18;
            this.label21.Text = "PASS/FAIL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Current  mA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Volt 5    V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(1, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Volt 3.3 V";
            // 
            // tboxBase5v
            // 
            this.tboxBase5v.BackColor = System.Drawing.Color.Gainsboro;
            this.tboxBase5v.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBase5v.Location = new System.Drawing.Point(224, 77);
            this.tboxBase5v.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboxBase5v.Name = "tboxBase5v";
            this.tboxBase5v.Size = new System.Drawing.Size(99, 29);
            this.tboxBase5v.TabIndex = 2;
            // 
            // tboxBase3v3
            // 
            this.tboxBase3v3.BackColor = System.Drawing.Color.Gainsboro;
            this.tboxBase3v3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBase3v3.Location = new System.Drawing.Point(224, 40);
            this.tboxBase3v3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboxBase3v3.Name = "tboxBase3v3";
            this.tboxBase3v3.Size = new System.Drawing.Size(99, 29);
            this.tboxBase3v3.TabIndex = 0;
            // 
            // lbBaseCurrent
            // 
            this.lbBaseCurrent.AutoSize = true;
            this.lbBaseCurrent.BackColor = System.Drawing.Color.Red;
            this.lbBaseCurrent.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaseCurrent.ForeColor = System.Drawing.Color.Black;
            this.lbBaseCurrent.Location = new System.Drawing.Point(340, 115);
            this.lbBaseCurrent.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbBaseCurrent.Name = "lbBaseCurrent";
            this.lbBaseCurrent.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbBaseCurrent.Size = new System.Drawing.Size(93, 28);
            this.lbBaseCurrent.TabIndex = 8;
            this.lbBaseCurrent.Text = "FAIL";
            // 
            // lbBase5V
            // 
            this.lbBase5V.AutoSize = true;
            this.lbBase5V.BackColor = System.Drawing.Color.Red;
            this.lbBase5V.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase5V.ForeColor = System.Drawing.Color.Black;
            this.lbBase5V.Location = new System.Drawing.Point(340, 78);
            this.lbBase5V.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbBase5V.Name = "lbBase5V";
            this.lbBase5V.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbBase5V.Size = new System.Drawing.Size(93, 28);
            this.lbBase5V.TabIndex = 7;
            this.lbBase5V.Text = "FAIL";
            // 
            // lbBase3v3
            // 
            this.lbBase3v3.AutoSize = true;
            this.lbBase3v3.BackColor = System.Drawing.Color.Red;
            this.lbBase3v3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase3v3.ForeColor = System.Drawing.Color.Black;
            this.lbBase3v3.Location = new System.Drawing.Point(340, 41);
            this.lbBase3v3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbBase3v3.Name = "lbBase3v3";
            this.lbBase3v3.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbBase3v3.Size = new System.Drawing.Size(93, 28);
            this.lbBase3v3.TabIndex = 6;
            this.lbBase3v3.Text = "FAIL";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1, 186);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(167, 19);
            this.label23.TabIndex = 20;
            this.label23.Text = "Sync Wave 2       KHz";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(1, 149);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(166, 19);
            this.label24.TabIndex = 19;
            this.label24.Text = "Sync Wave 38.4 MHz";
            // 
            // tboxBaseCurrent
            // 
            this.tboxBaseCurrent.BackColor = System.Drawing.Color.Gainsboro;
            this.tboxBaseCurrent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBaseCurrent.Location = new System.Drawing.Point(224, 114);
            this.tboxBaseCurrent.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboxBaseCurrent.Name = "tboxBaseCurrent";
            this.tboxBaseCurrent.Size = new System.Drawing.Size(99, 29);
            this.tboxBaseCurrent.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(224, 188);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(99, 29);
            this.textBox4.TabIndex = 22;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel2);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(310, 75);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(451, 262);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SYNC-03";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5F));
            this.tableLayoutPanel2.Controls.Add(this.label17, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label19, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label16, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.label13, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tboSync48v, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tboSync5v, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbSync48v, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbSync5v, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbSync3v3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tboSync3v3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(439, 226);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Location = new System.Drawing.Point(222, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 18);
            this.label17.TabIndex = 20;
            this.label17.Text = "VALUE";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(4, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 18);
            this.label18.TabIndex = 19;
            this.label18.Text = "TEST POINT";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Location = new System.Drawing.Point(338, 1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 18);
            this.label19.TabIndex = 16;
            this.label19.Text = "PASS/FAIL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Sync Wave 2       KHz";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(224, 188);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Red;
            this.label16.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(340, 189);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.label16.Size = new System.Drawing.Size(93, 28);
            this.label16.TabIndex = 14;
            this.label16.Text = "FAIL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(340, 152);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.label13.Size = new System.Drawing.Size(93, 28);
            this.label13.TabIndex = 13;
            this.label13.Text = "FAIL";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(224, 151);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 9;
            // 
            // tboSync48v
            // 
            this.tboSync48v.BackColor = System.Drawing.Color.Gainsboro;
            this.tboSync48v.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSync48v.Location = new System.Drawing.Point(224, 114);
            this.tboSync48v.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboSync48v.Name = "tboSync48v";
            this.tboSync48v.Size = new System.Drawing.Size(100, 29);
            this.tboSync48v.TabIndex = 4;
            // 
            // tboSync5v
            // 
            this.tboSync5v.BackColor = System.Drawing.Color.Gainsboro;
            this.tboSync5v.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSync5v.Location = new System.Drawing.Point(224, 77);
            this.tboSync5v.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboSync5v.Name = "tboSync5v";
            this.tboSync5v.Size = new System.Drawing.Size(100, 29);
            this.tboSync5v.TabIndex = 2;
            // 
            // lbSync48v
            // 
            this.lbSync48v.AutoSize = true;
            this.lbSync48v.BackColor = System.Drawing.Color.Red;
            this.lbSync48v.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSync48v.ForeColor = System.Drawing.Color.Black;
            this.lbSync48v.Location = new System.Drawing.Point(340, 115);
            this.lbSync48v.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbSync48v.Name = "lbSync48v";
            this.lbSync48v.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbSync48v.Size = new System.Drawing.Size(93, 28);
            this.lbSync48v.TabIndex = 8;
            this.lbSync48v.Text = "FAIL";
            // 
            // lbSync5v
            // 
            this.lbSync5v.AutoSize = true;
            this.lbSync5v.BackColor = System.Drawing.Color.Red;
            this.lbSync5v.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSync5v.ForeColor = System.Drawing.Color.Black;
            this.lbSync5v.Location = new System.Drawing.Point(340, 78);
            this.lbSync5v.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbSync5v.Name = "lbSync5v";
            this.lbSync5v.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbSync5v.Size = new System.Drawing.Size(93, 28);
            this.lbSync5v.TabIndex = 7;
            this.lbSync5v.Text = "FAIL";
            // 
            // lbSync3v3
            // 
            this.lbSync3v3.AutoSize = true;
            this.lbSync3v3.BackColor = System.Drawing.Color.Red;
            this.lbSync3v3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSync3v3.ForeColor = System.Drawing.Color.Black;
            this.lbSync3v3.Location = new System.Drawing.Point(340, 41);
            this.lbSync3v3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbSync3v3.Name = "lbSync3v3";
            this.lbSync3v3.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbSync3v3.Size = new System.Drawing.Size(93, 28);
            this.lbSync3v3.TabIndex = 6;
            this.lbSync3v3.Text = "FAIL";
            // 
            // tboSync3v3
            // 
            this.tboSync3v3.BackColor = System.Drawing.Color.Gainsboro;
            this.tboSync3v3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSync3v3.Location = new System.Drawing.Point(224, 40);
            this.tboSync3v3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboSync3v3.Name = "tboSync3v3";
            this.tboSync3v3.Size = new System.Drawing.Size(100, 29);
            this.tboSync3v3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sync Wave 38.4 MHz";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 117);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Volt 48  V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Volt 5    V";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Volt 3.3 V";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel3);
            this.groupBox8.Location = new System.Drawing.Point(310, 343);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(451, 262);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ETAG-06";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5F));
            this.tableLayoutPanel3.Controls.Add(this.label27, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label28, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lable, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label29, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tboEtagCurRun, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tboEtagCurSleep, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tboEtag3v3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbEtagCurrRun, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbEtagCurrSleep, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbEtag3v3, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(439, 228);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label27.Location = new System.Drawing.Point(338, 1);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 18);
            this.label27.TabIndex = 19;
            this.label27.Text = "PASS/FAIL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1, 112);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 19);
            this.label15.TabIndex = 8;
            this.label15.Text = "Transmit Current (mA)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label28.Location = new System.Drawing.Point(222, 1);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 18);
            this.label28.TabIndex = 18;
            this.label28.Text = "VALUE";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(1, 75);
            this.lable.Margin = new System.Windows.Forms.Padding(0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(153, 19);
            this.lable.TabIndex = 3;
            this.lable.Text = "Sleep Current (mA)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label29.Location = new System.Drawing.Point(4, 1);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 18);
            this.label29.TabIndex = 17;
            this.label29.Text = "TEST POINT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(1, 38);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 19);
            this.label14.TabIndex = 1;
            this.label14.Text = "Volt 3.3 (V)";
            // 
            // tboEtagCurRun
            // 
            this.tboEtagCurRun.BackColor = System.Drawing.Color.Gainsboro;
            this.tboEtagCurRun.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboEtagCurRun.Location = new System.Drawing.Point(224, 114);
            this.tboEtagCurRun.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboEtagCurRun.Name = "tboEtagCurRun";
            this.tboEtagCurRun.Size = new System.Drawing.Size(100, 29);
            this.tboEtagCurRun.TabIndex = 9;
            // 
            // tboEtagCurSleep
            // 
            this.tboEtagCurSleep.BackColor = System.Drawing.Color.Gainsboro;
            this.tboEtagCurSleep.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboEtagCurSleep.Location = new System.Drawing.Point(224, 77);
            this.tboEtagCurSleep.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboEtagCurSleep.Name = "tboEtagCurSleep";
            this.tboEtagCurSleep.Size = new System.Drawing.Size(100, 29);
            this.tboEtagCurSleep.TabIndex = 2;
            // 
            // tboEtag3v3
            // 
            this.tboEtag3v3.BackColor = System.Drawing.Color.Gainsboro;
            this.tboEtag3v3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboEtag3v3.Location = new System.Drawing.Point(224, 40);
            this.tboEtag3v3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboEtag3v3.Name = "tboEtag3v3";
            this.tboEtag3v3.Size = new System.Drawing.Size(100, 29);
            this.tboEtag3v3.TabIndex = 0;
            // 
            // lbEtagCurrRun
            // 
            this.lbEtagCurrRun.AutoSize = true;
            this.lbEtagCurrRun.BackColor = System.Drawing.Color.Red;
            this.lbEtagCurrRun.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtagCurrRun.ForeColor = System.Drawing.Color.Black;
            this.lbEtagCurrRun.Location = new System.Drawing.Point(340, 115);
            this.lbEtagCurrRun.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbEtagCurrRun.Name = "lbEtagCurrRun";
            this.lbEtagCurrRun.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbEtagCurrRun.Size = new System.Drawing.Size(93, 28);
            this.lbEtagCurrRun.TabIndex = 10;
            this.lbEtagCurrRun.Text = "FAIL";
            // 
            // lbEtagCurrSleep
            // 
            this.lbEtagCurrSleep.AutoSize = true;
            this.lbEtagCurrSleep.BackColor = System.Drawing.Color.Red;
            this.lbEtagCurrSleep.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtagCurrSleep.ForeColor = System.Drawing.Color.Black;
            this.lbEtagCurrSleep.Location = new System.Drawing.Point(340, 78);
            this.lbEtagCurrSleep.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbEtagCurrSleep.Name = "lbEtagCurrSleep";
            this.lbEtagCurrSleep.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbEtagCurrSleep.Size = new System.Drawing.Size(93, 28);
            this.lbEtagCurrSleep.TabIndex = 7;
            this.lbEtagCurrSleep.Text = "FAIL";
            // 
            // lbEtag3v3
            // 
            this.lbEtag3v3.AutoSize = true;
            this.lbEtag3v3.BackColor = System.Drawing.Color.Red;
            this.lbEtag3v3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtag3v3.ForeColor = System.Drawing.Color.Black;
            this.lbEtag3v3.Location = new System.Drawing.Point(340, 41);
            this.lbEtag3v3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbEtag3v3.Name = "lbEtag3v3";
            this.lbEtag3v3.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbEtag3v3.Size = new System.Drawing.Size(93, 28);
            this.lbEtag3v3.TabIndex = 6;
            this.lbEtag3v3.Text = "FAIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 621);
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
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

