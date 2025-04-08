using System.Drawing;

namespace Tool_Test_Ontrak_Pannel
{
    partial class fMain_Pannel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain_Pannel));
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
            this.btRefresh = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbBaseKHz = new System.Windows.Forms.Label();
            this.tboBaseSyncKHz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbBaseMHz = new System.Windows.Forms.Label();
            this.tboBaseSyncMHz = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboBaseVolt5 = new System.Windows.Forms.TextBox();
            this.tboBaseVolt3 = new System.Windows.Forms.TextBox();
            this.lbBaseCur = new System.Windows.Forms.Label();
            this.lbBaseVolt5 = new System.Windows.Forms.Label();
            this.lbBaseVolt3 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tboBaseCurrent = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSyncKHz = new System.Windows.Forms.Label();
            this.tboSyncKHz = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbSyncMHz = new System.Windows.Forms.Label();
            this.tboSyncMHz = new System.Windows.Forms.TextBox();
            this.tboSyncVolt48 = new System.Windows.Forms.TextBox();
            this.tboSyncVolt5 = new System.Windows.Forms.TextBox();
            this.lbSyncVolt48 = new System.Windows.Forms.Label();
            this.lbSyncVolt5 = new System.Windows.Forms.Label();
            this.lbSyncVolt3 = new System.Windows.Forms.Label();
            this.tboSyncVolt3 = new System.Windows.Forms.TextBox();
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
            this.tboEtagVolt3 = new System.Windows.Forms.TextBox();
            this.lbEtagCurrTrans = new System.Windows.Forms.Label();
            this.lbEtagCurSleep = new System.Windows.Forms.Label();
            this.lbEtagVolt3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btOpenOsci = new System.Windows.Forms.Button();
            this.btCloseOsci = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCom
            // 
            this.cboCom.FormattingEnabled = true;
            resources.ApplyResources(this.cboCom, "cboCom");
            this.cboCom.Name = "cboCom";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboBaud
            // 
            this.cboBaud.FormattingEnabled = true;
            resources.ApplyResources(this.cboBaud, "cboBaud");
            this.cboBaud.Name = "cboBaud";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboCom, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboBaud, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.btConnect, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btRefresh, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btDisconnect, 0, 1);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // btConnect
            // 
            resources.ApplyResources(this.btConnect, "btConnect");
            this.btConnect.Name = "btConnect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btRefresh
            // 
            resources.ApplyResources(this.btRefresh, "btRefresh");
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btDisconnect
            // 
            resources.ApplyResources(this.btDisconnect, "btDisconnect");
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.ForeColor = System.Drawing.Color.Blue;
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lbBaseKHz, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tboBaseSyncKHz, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label20, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbBaseMHz, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tboBaseSyncMHz, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tboBaseVolt5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboBaseVolt3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBaseCur, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbBaseVolt5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbBaseVolt3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tboBaseCurrent, 1, 3);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lbBaseKHz
            // 
            resources.ApplyResources(this.lbBaseKHz, "lbBaseKHz");
            this.lbBaseKHz.BackColor = System.Drawing.Color.Red;
            this.lbBaseKHz.ForeColor = System.Drawing.Color.Black;
            this.lbBaseKHz.Name = "lbBaseKHz";
            // 
            // tboBaseSyncKHz
            // 
            this.tboBaseSyncKHz.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboBaseSyncKHz, "tboBaseSyncKHz");
            this.tboBaseSyncKHz.Name = "tboBaseSyncKHz";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // lbBaseMHz
            // 
            resources.ApplyResources(this.lbBaseMHz, "lbBaseMHz");
            this.lbBaseMHz.BackColor = System.Drawing.Color.Red;
            this.lbBaseMHz.ForeColor = System.Drawing.Color.Black;
            this.lbBaseMHz.Name = "lbBaseMHz";
            // 
            // tboBaseSyncMHz
            // 
            this.tboBaseSyncMHz.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboBaseSyncMHz, "tboBaseSyncMHz");
            this.tboBaseSyncMHz.Name = "tboBaseSyncMHz";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tboBaseVolt5
            // 
            this.tboBaseVolt5.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboBaseVolt5, "tboBaseVolt5");
            this.tboBaseVolt5.Name = "tboBaseVolt5";
            // 
            // tboBaseVolt3
            // 
            this.tboBaseVolt3.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboBaseVolt3, "tboBaseVolt3");
            this.tboBaseVolt3.Name = "tboBaseVolt3";
            // 
            // lbBaseCur
            // 
            resources.ApplyResources(this.lbBaseCur, "lbBaseCur");
            this.lbBaseCur.BackColor = System.Drawing.Color.Red;
            this.lbBaseCur.ForeColor = System.Drawing.Color.Black;
            this.lbBaseCur.Name = "lbBaseCur";
            // 
            // lbBaseVolt5
            // 
            resources.ApplyResources(this.lbBaseVolt5, "lbBaseVolt5");
            this.lbBaseVolt5.BackColor = System.Drawing.Color.Red;
            this.lbBaseVolt5.ForeColor = System.Drawing.Color.Black;
            this.lbBaseVolt5.Name = "lbBaseVolt5";
            // 
            // lbBaseVolt3
            // 
            resources.ApplyResources(this.lbBaseVolt3, "lbBaseVolt3");
            this.lbBaseVolt3.BackColor = System.Drawing.Color.Red;
            this.lbBaseVolt3.ForeColor = System.Drawing.Color.Black;
            this.lbBaseVolt3.Name = "lbBaseVolt3";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // tboBaseCurrent
            // 
            this.tboBaseCurrent.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboBaseCurrent, "tboBaseCurrent");
            this.tboBaseCurrent.Name = "tboBaseCurrent";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.ForeColor = System.Drawing.Color.Blue;
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbSyncKHz, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.tboSyncKHz, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label17, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label19, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbSyncMHz, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.tboSyncMHz, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tboSyncVolt48, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tboSyncVolt5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbSyncVolt48, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbSyncVolt5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbSyncVolt3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tboSyncVolt3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // lbSyncKHz
            // 
            resources.ApplyResources(this.lbSyncKHz, "lbSyncKHz");
            this.lbSyncKHz.BackColor = System.Drawing.Color.Red;
            this.lbSyncKHz.ForeColor = System.Drawing.Color.Black;
            this.lbSyncKHz.Name = "lbSyncKHz";
            // 
            // tboSyncKHz
            // 
            this.tboSyncKHz.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboSyncKHz, "tboSyncKHz");
            this.tboSyncKHz.Name = "tboSyncKHz";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // lbSyncMHz
            // 
            resources.ApplyResources(this.lbSyncMHz, "lbSyncMHz");
            this.lbSyncMHz.BackColor = System.Drawing.Color.Red;
            this.lbSyncMHz.ForeColor = System.Drawing.Color.Black;
            this.lbSyncMHz.Name = "lbSyncMHz";
            // 
            // tboSyncMHz
            // 
            this.tboSyncMHz.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboSyncMHz, "tboSyncMHz");
            this.tboSyncMHz.Name = "tboSyncMHz";
            // 
            // tboSyncVolt48
            // 
            this.tboSyncVolt48.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboSyncVolt48, "tboSyncVolt48");
            this.tboSyncVolt48.Name = "tboSyncVolt48";
            // 
            // tboSyncVolt5
            // 
            this.tboSyncVolt5.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboSyncVolt5, "tboSyncVolt5");
            this.tboSyncVolt5.Name = "tboSyncVolt5";
            // 
            // lbSyncVolt48
            // 
            resources.ApplyResources(this.lbSyncVolt48, "lbSyncVolt48");
            this.lbSyncVolt48.BackColor = System.Drawing.Color.Red;
            this.lbSyncVolt48.ForeColor = System.Drawing.Color.Black;
            this.lbSyncVolt48.Name = "lbSyncVolt48";
            // 
            // lbSyncVolt5
            // 
            resources.ApplyResources(this.lbSyncVolt5, "lbSyncVolt5");
            this.lbSyncVolt5.BackColor = System.Drawing.Color.Red;
            this.lbSyncVolt5.ForeColor = System.Drawing.Color.Black;
            this.lbSyncVolt5.Name = "lbSyncVolt5";
            // 
            // lbSyncVolt3
            // 
            resources.ApplyResources(this.lbSyncVolt3, "lbSyncVolt3");
            this.lbSyncVolt3.BackColor = System.Drawing.Color.Red;
            this.lbSyncVolt3.ForeColor = System.Drawing.Color.Black;
            this.lbSyncVolt3.Name = "lbSyncVolt3";
            // 
            // tboSyncVolt3
            // 
            this.tboSyncVolt3.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboSyncVolt3, "tboSyncVolt3");
            this.tboSyncVolt3.Name = "tboSyncVolt3";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.ForeColor = System.Drawing.Color.Blue;
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.label27, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label28, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lable, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label29, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tboEtagCurTrans, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tboEtagCurSleep, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tboEtagVolt3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbEtagCurrTrans, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbEtagCurSleep, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbEtagVolt3, 2, 1);
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // lable
            // 
            resources.ApplyResources(this.lable, "lable");
            this.lable.Name = "lable";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // tboEtagCurTrans
            // 
            this.tboEtagCurTrans.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboEtagCurTrans, "tboEtagCurTrans");
            this.tboEtagCurTrans.Name = "tboEtagCurTrans";
            // 
            // tboEtagCurSleep
            // 
            this.tboEtagCurSleep.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboEtagCurSleep, "tboEtagCurSleep");
            this.tboEtagCurSleep.Name = "tboEtagCurSleep";
            // 
            // tboEtagVolt3
            // 
            this.tboEtagVolt3.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.tboEtagVolt3, "tboEtagVolt3");
            this.tboEtagVolt3.Name = "tboEtagVolt3";
            // 
            // lbEtagCurrTrans
            // 
            resources.ApplyResources(this.lbEtagCurrTrans, "lbEtagCurrTrans");
            this.lbEtagCurrTrans.BackColor = System.Drawing.Color.Red;
            this.lbEtagCurrTrans.ForeColor = System.Drawing.Color.Black;
            this.lbEtagCurrTrans.Name = "lbEtagCurrTrans";
            // 
            // lbEtagCurSleep
            // 
            resources.ApplyResources(this.lbEtagCurSleep, "lbEtagCurSleep");
            this.lbEtagCurSleep.BackColor = System.Drawing.Color.Red;
            this.lbEtagCurSleep.ForeColor = System.Drawing.Color.Black;
            this.lbEtagCurSleep.Name = "lbEtagCurSleep";
            // 
            // lbEtagVolt3
            // 
            resources.ApplyResources(this.lbEtagVolt3, "lbEtagVolt3");
            this.lbEtagVolt3.BackColor = System.Drawing.Color.Red;
            this.lbEtagVolt3.ForeColor = System.Drawing.Color.Black;
            this.lbEtagVolt3.Name = "lbEtagVolt3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Tool_Test_Ontrak_Pannel.Properties.Resources.Logo_Ontrak_140_80;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel6);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.btOpenOsci, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btCloseOsci, 0, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // btOpenOsci
            // 
            resources.ApplyResources(this.btOpenOsci, "btOpenOsci");
            this.btOpenOsci.Name = "btOpenOsci";
            this.btOpenOsci.UseVisualStyleBackColor = true;
            this.btOpenOsci.Click += new System.EventHandler(this.btOpenHantek_Click);
            // 
            // btCloseOsci
            // 
            resources.ApplyResources(this.btCloseOsci, "btCloseOsci");
            this.btCloseOsci.Name = "btCloseOsci";
            this.btCloseOsci.UseVisualStyleBackColor = true;
            this.btCloseOsci.Click += new System.EventHandler(this.btCloseOsci_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox6);
            this.panel3.Controls.Add(this.groupBox7);
            this.panel3.Controls.Add(this.groupBox8);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // fMain_Pannel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "fMain_Pannel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboBaseVolt3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboBaseCurrent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboBaseVolt5;
        private System.Windows.Forms.Label lbBaseVolt3;
        private System.Windows.Forms.Label lbBaseVolt5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbBaseCur;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lbEtagVolt3;
        private System.Windows.Forms.Label lbEtagCurSleep;
        private System.Windows.Forms.TextBox tboEtagVolt3;
        private System.Windows.Forms.TextBox tboEtagCurSleep;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbEtagCurrTrans;
        private System.Windows.Forms.TextBox tboEtagCurTrans;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbBaseMHz;
        private System.Windows.Forms.TextBox tboBaseSyncMHz;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btOpenOsci;
        private System.Windows.Forms.Button btCloseOsci;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbBaseKHz;
        private System.Windows.Forms.TextBox tboBaseSyncKHz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSyncKHz;
        private System.Windows.Forms.TextBox tboSyncKHz;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbSyncMHz;
        private System.Windows.Forms.TextBox tboSyncMHz;
        private System.Windows.Forms.TextBox tboSyncVolt48;
        private System.Windows.Forms.TextBox tboSyncVolt5;
        private System.Windows.Forms.Label lbSyncVolt48;
        private System.Windows.Forms.Label lbSyncVolt5;
        private System.Windows.Forms.Label lbSyncVolt3;
        private System.Windows.Forms.TextBox tboSyncVolt3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}

