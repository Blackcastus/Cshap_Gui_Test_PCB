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
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.lbComStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbBase2 = new System.Windows.Forms.Label();
            this.lbBase384 = new System.Windows.Forms.Label();
            this.tboBase384 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboBase5 = new System.Windows.Forms.TextBox();
            this.tboBase3 = new System.Windows.Forms.TextBox();
            this.lbBaseCur = new System.Windows.Forms.Label();
            this.lbBase5 = new System.Windows.Forms.Label();
            this.lbBase3 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tboBaseCur = new System.Windows.Forms.TextBox();
            this.tboBase2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tboSync2 = new System.Windows.Forms.TextBox();
            this.lbSync2 = new System.Windows.Forms.Label();
            this.lbSync384 = new System.Windows.Forms.Label();
            this.tboSync384 = new System.Windows.Forms.TextBox();
            this.tboSync48 = new System.Windows.Forms.TextBox();
            this.tboSync5 = new System.Windows.Forms.TextBox();
            this.lbSync48 = new System.Windows.Forms.Label();
            this.lbSync5 = new System.Windows.Forms.Label();
            this.lbSync3 = new System.Windows.Forms.Label();
            this.tboSync3 = new System.Windows.Forms.TextBox();
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
            this.tboEtagCurTrans = new System.Windows.Forms.TextBox();
            this.tboEtagCurSleep = new System.Windows.Forms.TextBox();
            this.tboEtag3 = new System.Windows.Forms.TextBox();
            this.lbEtagCurrRun = new System.Windows.Forms.Label();
            this.lbEtagCurSleep = new System.Windows.Forms.Label();
            this.lbEtag3 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel5.Controls.Add(this.btConnect, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btDisconnect, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btRefresh, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbComStatus, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(271, 92);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btConnect.Location = new System.Drawing.Point(3, 3);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 24);
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
            this.btDisconnect.Size = new System.Drawing.Size(75, 24);
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
            this.lbComStatus.Location = new System.Drawing.Point(138, 36);
            this.lbComStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbComStatus.Name = "lbComStatus";
            this.lbComStatus.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbComStatus.Size = new System.Drawing.Size(108, 20);
            this.lbComStatus.TabIndex = 8;
            this.lbComStatus.Text = "Disconnected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(138, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Connection Status";
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
            this.groupBox6.Text = "BASE-03";
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
            this.tableLayoutPanel1.Controls.Add(this.lbBase2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbBase384, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tboBase384, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tboBase5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboBase3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBaseCur, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbBase5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbBase3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tboBaseCur, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tboBase2, 1, 5);
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
            // lbBase2
            // 
            this.lbBase2.AutoSize = true;
            this.lbBase2.BackColor = System.Drawing.Color.Red;
            this.lbBase2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase2.ForeColor = System.Drawing.Color.Black;
            this.lbBase2.Location = new System.Drawing.Point(340, 189);
            this.lbBase2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbBase2.Name = "lbBase2";
            this.lbBase2.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbBase2.Size = new System.Drawing.Size(93, 28);
            this.lbBase2.TabIndex = 24;
            this.lbBase2.Text = "FAIL";
            // 
            // lbBase384
            // 
            this.lbBase384.AutoSize = true;
            this.lbBase384.BackColor = System.Drawing.Color.Red;
            this.lbBase384.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase384.ForeColor = System.Drawing.Color.Black;
            this.lbBase384.Location = new System.Drawing.Point(340, 152);
            this.lbBase384.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbBase384.Name = "lbBase384";
            this.lbBase384.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbBase384.Size = new System.Drawing.Size(93, 28);
            this.lbBase384.TabIndex = 23;
            this.lbBase384.Text = "FAIL";
            // 
            // tboBase384
            // 
            this.tboBase384.BackColor = System.Drawing.Color.Gainsboro;
            this.tboBase384.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboBase384.Location = new System.Drawing.Point(224, 151);
            this.tboBase384.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboBase384.Name = "tboBase384";
            this.tboBase384.Size = new System.Drawing.Size(99, 29);
            this.tboBase384.TabIndex = 21;
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
            // tboBase5
            // 
            this.tboBase5.BackColor = System.Drawing.Color.Gainsboro;
            this.tboBase5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboBase5.Location = new System.Drawing.Point(224, 77);
            this.tboBase5.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboBase5.Name = "tboBase5";
            this.tboBase5.Size = new System.Drawing.Size(99, 29);
            this.tboBase5.TabIndex = 2;
            // 
            // tboBase3
            // 
            this.tboBase3.BackColor = System.Drawing.Color.Gainsboro;
            this.tboBase3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboBase3.Location = new System.Drawing.Point(224, 40);
            this.tboBase3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboBase3.Name = "tboBase3";
            this.tboBase3.Size = new System.Drawing.Size(99, 29);
            this.tboBase3.TabIndex = 0;
            // 
            // lbBaseCur
            // 
            this.lbBaseCur.AutoSize = true;
            this.lbBaseCur.BackColor = System.Drawing.Color.Red;
            this.lbBaseCur.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaseCur.ForeColor = System.Drawing.Color.Black;
            this.lbBaseCur.Location = new System.Drawing.Point(340, 115);
            this.lbBaseCur.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbBaseCur.Name = "lbBaseCur";
            this.lbBaseCur.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbBaseCur.Size = new System.Drawing.Size(93, 28);
            this.lbBaseCur.TabIndex = 8;
            this.lbBaseCur.Text = "FAIL";
            // 
            // lbBase5
            // 
            this.lbBase5.AutoSize = true;
            this.lbBase5.BackColor = System.Drawing.Color.Red;
            this.lbBase5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase5.ForeColor = System.Drawing.Color.Black;
            this.lbBase5.Location = new System.Drawing.Point(340, 78);
            this.lbBase5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbBase5.Name = "lbBase5";
            this.lbBase5.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbBase5.Size = new System.Drawing.Size(93, 28);
            this.lbBase5.TabIndex = 7;
            this.lbBase5.Text = "FAIL";
            // 
            // lbBase3
            // 
            this.lbBase3.AutoSize = true;
            this.lbBase3.BackColor = System.Drawing.Color.Red;
            this.lbBase3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase3.ForeColor = System.Drawing.Color.Black;
            this.lbBase3.Location = new System.Drawing.Point(340, 41);
            this.lbBase3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbBase3.Name = "lbBase3";
            this.lbBase3.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbBase3.Size = new System.Drawing.Size(93, 28);
            this.lbBase3.TabIndex = 6;
            this.lbBase3.Text = "FAIL";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1, 186);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(163, 19);
            this.label23.TabIndex = 20;
            this.label23.Text = "Sync Wave 2      KHz";
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
            // tboBaseCur
            // 
            this.tboBaseCur.BackColor = System.Drawing.Color.Gainsboro;
            this.tboBaseCur.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboBaseCur.Location = new System.Drawing.Point(224, 114);
            this.tboBaseCur.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboBaseCur.Name = "tboBaseCur";
            this.tboBaseCur.Size = new System.Drawing.Size(99, 29);
            this.tboBaseCur.TabIndex = 4;
            // 
            // tboBase2
            // 
            this.tboBase2.BackColor = System.Drawing.Color.Gainsboro;
            this.tboBase2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboBase2.Location = new System.Drawing.Point(224, 188);
            this.tboBase2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboBase2.Name = "tboBase2";
            this.tboBase2.Size = new System.Drawing.Size(99, 29);
            this.tboBase2.TabIndex = 22;
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
            this.groupBox7.Text = "SYNC-08";
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
            this.tableLayoutPanel2.Controls.Add(this.tboSync2, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbSync2, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbSync384, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.tboSync384, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tboSync48, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tboSync5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbSync48, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbSync5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbSync3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tboSync3, 1, 1);
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
            this.label11.Size = new System.Drawing.Size(163, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Sync Wave 2      KHz";
            // 
            // tboSync2
            // 
            this.tboSync2.BackColor = System.Drawing.Color.Gainsboro;
            this.tboSync2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSync2.Location = new System.Drawing.Point(224, 188);
            this.tboSync2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboSync2.Name = "tboSync2";
            this.tboSync2.Size = new System.Drawing.Size(100, 29);
            this.tboSync2.TabIndex = 12;
            // 
            // lbSync2
            // 
            this.lbSync2.AutoSize = true;
            this.lbSync2.BackColor = System.Drawing.Color.Red;
            this.lbSync2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSync2.ForeColor = System.Drawing.Color.Black;
            this.lbSync2.Location = new System.Drawing.Point(340, 189);
            this.lbSync2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbSync2.Name = "lbSync2";
            this.lbSync2.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbSync2.Size = new System.Drawing.Size(93, 28);
            this.lbSync2.TabIndex = 14;
            this.lbSync2.Text = "FAIL";
            // 
            // lbSync384
            // 
            this.lbSync384.AutoSize = true;
            this.lbSync384.BackColor = System.Drawing.Color.Red;
            this.lbSync384.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSync384.ForeColor = System.Drawing.Color.Black;
            this.lbSync384.Location = new System.Drawing.Point(340, 152);
            this.lbSync384.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbSync384.Name = "lbSync384";
            this.lbSync384.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbSync384.Size = new System.Drawing.Size(93, 28);
            this.lbSync384.TabIndex = 13;
            this.lbSync384.Text = "FAIL";
            // 
            // tboSync384
            // 
            this.tboSync384.BackColor = System.Drawing.Color.Gainsboro;
            this.tboSync384.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSync384.Location = new System.Drawing.Point(224, 151);
            this.tboSync384.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboSync384.Name = "tboSync384";
            this.tboSync384.Size = new System.Drawing.Size(100, 29);
            this.tboSync384.TabIndex = 9;
            // 
            // tboSync48
            // 
            this.tboSync48.BackColor = System.Drawing.Color.Gainsboro;
            this.tboSync48.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSync48.Location = new System.Drawing.Point(224, 114);
            this.tboSync48.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboSync48.Name = "tboSync48";
            this.tboSync48.Size = new System.Drawing.Size(100, 29);
            this.tboSync48.TabIndex = 4;
            // 
            // tboSync5
            // 
            this.tboSync5.BackColor = System.Drawing.Color.Gainsboro;
            this.tboSync5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSync5.Location = new System.Drawing.Point(224, 77);
            this.tboSync5.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboSync5.Name = "tboSync5";
            this.tboSync5.Size = new System.Drawing.Size(100, 29);
            this.tboSync5.TabIndex = 2;
            // 
            // lbSync48
            // 
            this.lbSync48.AutoSize = true;
            this.lbSync48.BackColor = System.Drawing.Color.Red;
            this.lbSync48.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSync48.ForeColor = System.Drawing.Color.Black;
            this.lbSync48.Location = new System.Drawing.Point(340, 115);
            this.lbSync48.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbSync48.Name = "lbSync48";
            this.lbSync48.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbSync48.Size = new System.Drawing.Size(93, 28);
            this.lbSync48.TabIndex = 8;
            this.lbSync48.Text = "FAIL";
            // 
            // lbSync5
            // 
            this.lbSync5.AutoSize = true;
            this.lbSync5.BackColor = System.Drawing.Color.Red;
            this.lbSync5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSync5.ForeColor = System.Drawing.Color.Black;
            this.lbSync5.Location = new System.Drawing.Point(340, 78);
            this.lbSync5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbSync5.Name = "lbSync5";
            this.lbSync5.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbSync5.Size = new System.Drawing.Size(93, 28);
            this.lbSync5.TabIndex = 7;
            this.lbSync5.Text = "FAIL";
            // 
            // lbSync3
            // 
            this.lbSync3.AutoSize = true;
            this.lbSync3.BackColor = System.Drawing.Color.Red;
            this.lbSync3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSync3.ForeColor = System.Drawing.Color.Black;
            this.lbSync3.Location = new System.Drawing.Point(340, 41);
            this.lbSync3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbSync3.Name = "lbSync3";
            this.lbSync3.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbSync3.Size = new System.Drawing.Size(93, 28);
            this.lbSync3.TabIndex = 6;
            this.lbSync3.Text = "FAIL";
            // 
            // tboSync3
            // 
            this.tboSync3.BackColor = System.Drawing.Color.Gainsboro;
            this.tboSync3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSync3.Location = new System.Drawing.Point(224, 40);
            this.tboSync3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboSync3.Name = "tboSync3";
            this.tboSync3.Size = new System.Drawing.Size(100, 29);
            this.tboSync3.TabIndex = 0;
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
            this.tableLayoutPanel3.Controls.Add(this.tboEtagCurTrans, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tboEtagCurSleep, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tboEtag3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbEtagCurrRun, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbEtagCurSleep, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbEtag3, 2, 1);
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
            // tboEtagCurTrans
            // 
            this.tboEtagCurTrans.BackColor = System.Drawing.Color.Gainsboro;
            this.tboEtagCurTrans.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboEtagCurTrans.Location = new System.Drawing.Point(224, 114);
            this.tboEtagCurTrans.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboEtagCurTrans.Name = "tboEtagCurTrans";
            this.tboEtagCurTrans.Size = new System.Drawing.Size(100, 29);
            this.tboEtagCurTrans.TabIndex = 9;
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
            // tboEtag3
            // 
            this.tboEtag3.BackColor = System.Drawing.Color.Gainsboro;
            this.tboEtag3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboEtag3.Location = new System.Drawing.Point(224, 40);
            this.tboEtag3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tboEtag3.Name = "tboEtag3";
            this.tboEtag3.Size = new System.Drawing.Size(100, 29);
            this.tboEtag3.TabIndex = 0;
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
            // lbEtagCurSleep
            // 
            this.lbEtagCurSleep.AutoSize = true;
            this.lbEtagCurSleep.BackColor = System.Drawing.Color.Red;
            this.lbEtagCurSleep.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtagCurSleep.ForeColor = System.Drawing.Color.Black;
            this.lbEtagCurSleep.Location = new System.Drawing.Point(340, 78);
            this.lbEtagCurSleep.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbEtagCurSleep.Name = "lbEtagCurSleep";
            this.lbEtagCurSleep.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbEtagCurSleep.Size = new System.Drawing.Size(93, 28);
            this.lbEtagCurSleep.TabIndex = 7;
            this.lbEtagCurSleep.Text = "FAIL";
            // 
            // lbEtag3
            // 
            this.lbEtag3.AutoSize = true;
            this.lbEtag3.BackColor = System.Drawing.Color.Red;
            this.lbEtag3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtag3.ForeColor = System.Drawing.Color.Black;
            this.lbEtag3.Location = new System.Drawing.Point(340, 41);
            this.lbEtag3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lbEtag3.Name = "lbEtag3";
            this.lbEtag3.Padding = new System.Windows.Forms.Padding(25, 4, 25, 5);
            this.lbEtag3.Size = new System.Drawing.Size(93, 28);
            this.lbEtag3.TabIndex = 6;
            this.lbEtag3.Text = "FAIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 616);
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
        private System.Windows.Forms.TextBox tboBase3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboBaseCur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboBase5;
        private System.Windows.Forms.Label lbBase3;
        private System.Windows.Forms.Label lbBase5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbBaseCur;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSync48;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbSync3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSync5;
        private System.Windows.Forms.TextBox tboSync3;
        private System.Windows.Forms.TextBox tboSync5;
        private System.Windows.Forms.TextBox tboSync48;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lbEtag3;
        private System.Windows.Forms.Label lbEtagCurSleep;
        private System.Windows.Forms.TextBox tboEtag3;
        private System.Windows.Forms.TextBox tboEtagCurSleep;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbEtagCurrRun;
        private System.Windows.Forms.TextBox tboEtagCurTrans;
        private System.Windows.Forms.Label lbSync2;
        private System.Windows.Forms.Label lbSync384;
        private System.Windows.Forms.TextBox tboSync384;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tboSync2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbBase2;
        private System.Windows.Forms.Label lbBase384;
        private System.Windows.Forms.TextBox tboBase384;
        private System.Windows.Forms.TextBox tboBase2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

