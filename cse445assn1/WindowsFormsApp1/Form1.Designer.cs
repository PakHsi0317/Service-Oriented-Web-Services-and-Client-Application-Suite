namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxf2c = new System.Windows.Forms.TextBox();
            this.btnc2f = new System.Windows.Forms.Button();
            this.btnf2c = new System.Windows.Forms.Button();
            this.piValueLabel2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCvertString = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBox = new System.Windows.Forms.TextBox();
            this.btngo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.calTB1 = new System.Windows.Forms.TextBox();
            this.calTB2 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.multiBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.symLabel = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxc2f = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEncrypted = new System.Windows.Forms.Label();
            this.lblDecrypted = new System.Windows.Forms.Label();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxf2c
            // 
            this.textBoxf2c.Location = new System.Drawing.Point(405, 640);
            this.textBoxf2c.Name = "textBoxf2c";
            this.textBoxf2c.Size = new System.Drawing.Size(151, 26);
            this.textBoxf2c.TabIndex = 4;
            this.textBoxf2c.TextChanged += new System.EventHandler(this.textBoxf2c_TextChanged);
            // 
            // btnc2f
            // 
            this.btnc2f.BackColor = System.Drawing.Color.LightGray;
            this.btnc2f.Location = new System.Drawing.Point(594, 613);
            this.btnc2f.Name = "btnc2f";
            this.btnc2f.Size = new System.Drawing.Size(75, 24);
            this.btnc2f.TabIndex = 5;
            this.btnc2f.Text = "btnc2f";
            this.btnc2f.UseVisualStyleBackColor = false;
            this.btnc2f.Click += new System.EventHandler(this.btnc2f_Click);
            // 
            // btnf2c
            // 
            this.btnf2c.BackColor = System.Drawing.Color.LightGray;
            this.btnf2c.Location = new System.Drawing.Point(594, 642);
            this.btnf2c.Name = "btnf2c";
            this.btnf2c.Size = new System.Drawing.Size(75, 23);
            this.btnf2c.TabIndex = 6;
            this.btnf2c.Text = "btnf2c";
            this.btnf2c.UseVisualStyleBackColor = false;
            this.btnf2c.Click += new System.EventHandler(this.btnf2c_Click);
            // 
            // piValueLabel2
            // 
            this.piValueLabel2.AutoSize = true;
            this.piValueLabel2.Location = new System.Drawing.Point(177, 206);
            this.piValueLabel2.Name = "piValueLabel2";
            this.piValueLabel2.Size = new System.Drawing.Size(0, 20);
            this.piValueLabel2.TabIndex = 2;
            this.piValueLabel2.Click += new System.EventHandler(this.piLabel_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(690, 640);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(450, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCvertString
            // 
            this.btnCvertString.BackColor = System.Drawing.Color.LightGray;
            this.btnCvertString.Location = new System.Drawing.Point(1097, 613);
            this.btnCvertString.Name = "btnCvertString";
            this.btnCvertString.Size = new System.Drawing.Size(75, 23);
            this.btnCvertString.TabIndex = 8;
            this.btnCvertString.Text = "btnCvertString";
            this.btnCvertString.UseVisualStyleBackColor = false;
            this.btnCvertString.Click += new System.EventHandler(this.btnCvertString_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-1, -2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1268, 609);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // webBox
            // 
            this.webBox.Location = new System.Drawing.Point(12, 12);
            this.webBox.Name = "webBox";
            this.webBox.Size = new System.Drawing.Size(544, 26);
            this.webBox.TabIndex = 10;
            // 
            // btngo
            // 
            this.btngo.BackColor = System.Drawing.Color.LightGray;
            this.btngo.Location = new System.Drawing.Point(594, 9);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(97, 32);
            this.btngo.TabIndex = 11;
            this.btngo.Text = "Google";
            this.btngo.UseVisualStyleBackColor = false;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // calTB1
            // 
            this.calTB1.Location = new System.Drawing.Point(886, 18);
            this.calTB1.Name = "calTB1";
            this.calTB1.Size = new System.Drawing.Size(95, 26);
            this.calTB1.TabIndex = 13;
            this.calTB1.TextChanged += new System.EventHandler(this.calTB1_TextChanged);
            // 
            // calTB2
            // 
            this.calTB2.Location = new System.Drawing.Point(1118, 18);
            this.calTB2.Name = "calTB2";
            this.calTB2.Size = new System.Drawing.Size(115, 26);
            this.calTB2.TabIndex = 14;
            this.calTB2.TextChanged += new System.EventHandler(this.calTB2_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(886, 80);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(984, 80);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(75, 23);
            this.subBtn.TabIndex = 16;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // multiBtn
            // 
            this.multiBtn.Location = new System.Drawing.Point(1065, 81);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.Size = new System.Drawing.Size(75, 23);
            this.multiBtn.TabIndex = 17;
            this.multiBtn.Text = "*";
            this.multiBtn.UseVisualStyleBackColor = true;
            this.multiBtn.Click += new System.EventHandler(this.multiBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(1161, 78);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(72, 26);
            this.divBtn.TabIndex = 18;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // symLabel
            // 
            this.symLabel.AutoSize = true;
            this.symLabel.Location = new System.Drawing.Point(330, 441);
            this.symLabel.Name = "symLabel";
            this.symLabel.Size = new System.Drawing.Size(0, 20);
            this.symLabel.TabIndex = 19;
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Location = new System.Drawing.Point(342, 491);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(0, 20);
            this.resultLable.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1061, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 21;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1067, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 22;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxc2f
            // 
            this.textBoxc2f.Location = new System.Drawing.Point(405, 610);
            this.textBoxc2f.Name = "textBoxc2f";
            this.textBoxc2f.Size = new System.Drawing.Size(151, 26);
            this.textBoxc2f.TabIndex = 3;
            this.textBoxc2f.TextChanged += new System.EventHandler(this.textBoxc2f_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Please enter a string for enryption:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(801, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1085, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.AutoSize = true;
            this.lblEncrypted.Location = new System.Drawing.Point(799, 295);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(252, 20);
            this.lblEncrypted.TabIndex = 26;
            this.lblEncrypted.Text = "The encrtpted string looks like this:";
            this.lblEncrypted.Click += new System.EventHandler(this.lblEncrypted_Click);
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Location = new System.Drawing.Point(797, 337);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(297, 20);
            this.lblDecrypted.TabIndex = 27;
            this.lblDecrypted.Text = "Check if the decrypted string is correct-->";
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.BackColor = System.Drawing.Color.White;
            this.lblEn.Location = new System.Drawing.Point(1081, 317);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(0, 20);
            this.lblEn.TabIndex = 28;
            this.lblEn.Click += new System.EventHandler(this.lblEn_Click);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.BackColor = System.Drawing.Color.White;
            this.lblDe.Location = new System.Drawing.Point(1114, 366);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(0, 20);
            this.lblDe.TabIndex = 29;
            this.lblDe.Click += new System.EventHandler(this.lblDe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(851, 887);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-5, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Convert Celsius temperature to Fahrenheit temperature";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-5, 640);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Convert Fahrenheit temperature to Celsius temperature";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(685, 610);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(339, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Sort a string of numbers, separated by comma:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(799, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Calculator";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1546, 1050);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblEn);
            this.Controls.Add(this.lblDecrypted);
            this.Controls.Add(this.lblEncrypted);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.symLabel);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.multiBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.calTB2);
            this.Controls.Add(this.calTB1);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.webBox);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnCvertString);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnf2c);
            this.Controls.Add(this.btnc2f);
            this.Controls.Add(this.textBoxf2c);
            this.Controls.Add(this.textBoxc2f);
            this.Controls.Add(this.piValueLabel2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label piValueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxf2c;
        private System.Windows.Forms.Button btnc2f;
        private System.Windows.Forms.Button btnf2c;
        private System.Windows.Forms.Label piValueLabel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCvertString;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox webBox;
        private System.Windows.Forms.Button btngo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox calTB1;
        private System.Windows.Forms.TextBox calTB2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button multiBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Label symLabel;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxc2f;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEncrypted;
        private System.Windows.Forms.Label lblDecrypted;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

