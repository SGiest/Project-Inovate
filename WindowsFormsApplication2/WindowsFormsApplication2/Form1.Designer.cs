namespace WindowsFormsApplication2
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
            this.BtnConHW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSchOn2 = new System.Windows.Forms.Button();
            this.LblSch2 = new System.Windows.Forms.Label();
            this.BtnSchOff2 = new System.Windows.Forms.Button();
            this.BtnSchOn1 = new System.Windows.Forms.Button();
            this.BtnSchOff1 = new System.Windows.Forms.Button();
            this.LblSch1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnHueOn1 = new System.Windows.Forms.Button();
            this.LblHue1 = new System.Windows.Forms.Label();
            this.CmbHue1 = new System.Windows.Forms.ComboBox();
            this.BtnHueOff = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Login.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConHW
            // 
            this.BtnConHW.Location = new System.Drawing.Point(122, 58);
            this.BtnConHW.Name = "BtnConHW";
            this.BtnConHW.Size = new System.Drawing.Size(75, 23);
            this.BtnConHW.TabIndex = 0;
            this.BtnConHW.Text = "Connect";
            this.BtnConHW.UseVisualStyleBackColor = true;
            this.BtnConHW.Click += new System.EventHandler(this.BtnConHW_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pass";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 249);
            this.tabControl1.TabIndex = 6;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.textBox2);
            this.Login.Controls.Add(this.textBox1);
            this.Login.Controls.Add(this.BtnConHW);
            this.Login.Controls.Add(this.label2);
            this.Login.Controls.Add(this.label1);
            this.Login.Location = new System.Drawing.Point(4, 22);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(567, 223);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Innovate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "sieger.van.der.iest@student.stenden.com";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.BtnSchOn2);
            this.groupBox2.Controls.Add(this.LblSch2);
            this.groupBox2.Controls.Add(this.BtnSchOff2);
            this.groupBox2.Controls.Add(this.BtnSchOn1);
            this.groupBox2.Controls.Add(this.BtnSchOff1);
            this.groupBox2.Controls.Add(this.LblSch1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Switches";
            // 
            // BtnSchOn2
            // 
            this.BtnSchOn2.Location = new System.Drawing.Point(119, 44);
            this.BtnSchOn2.Name = "BtnSchOn2";
            this.BtnSchOn2.Size = new System.Drawing.Size(35, 25);
            this.BtnSchOn2.TabIndex = 22;
            this.BtnSchOn2.Text = "ON";
            this.BtnSchOn2.UseVisualStyleBackColor = true;
            this.BtnSchOn2.Click += new System.EventHandler(this.BtnSchOn2_Click);
            // 
            // LblSch2
            // 
            this.LblSch2.AutoSize = true;
            this.LblSch2.Location = new System.Drawing.Point(10, 50);
            this.LblSch2.Name = "LblSch2";
            this.LblSch2.Size = new System.Drawing.Size(61, 13);
            this.LblSch2.TabIndex = 21;
            this.LblSch2.Text = "Schakelaar";
            // 
            // BtnSchOff2
            // 
            this.BtnSchOff2.Location = new System.Drawing.Point(160, 45);
            this.BtnSchOff2.Name = "BtnSchOff2";
            this.BtnSchOff2.Size = new System.Drawing.Size(35, 25);
            this.BtnSchOff2.TabIndex = 20;
            this.BtnSchOff2.Text = "OFF";
            this.BtnSchOff2.UseVisualStyleBackColor = true;
            this.BtnSchOff2.Click += new System.EventHandler(this.BtnSchOff2_Click);
            // 
            // BtnSchOn1
            // 
            this.BtnSchOn1.Location = new System.Drawing.Point(120, 15);
            this.BtnSchOn1.Name = "BtnSchOn1";
            this.BtnSchOn1.Size = new System.Drawing.Size(35, 25);
            this.BtnSchOn1.TabIndex = 19;
            this.BtnSchOn1.Text = "ON";
            this.BtnSchOn1.UseVisualStyleBackColor = true;
            this.BtnSchOn1.Click += new System.EventHandler(this.BtnSchon1_Click);
            // 
            // BtnSchOff1
            // 
            this.BtnSchOff1.Location = new System.Drawing.Point(160, 15);
            this.BtnSchOff1.Name = "BtnSchOff1";
            this.BtnSchOff1.Size = new System.Drawing.Size(35, 25);
            this.BtnSchOff1.TabIndex = 18;
            this.BtnSchOff1.Text = "OFF";
            this.BtnSchOff1.UseVisualStyleBackColor = true;
            this.BtnSchOff1.Click += new System.EventHandler(this.BtnSchOff1_Click);
            // 
            // LblSch1
            // 
            this.LblSch1.AutoSize = true;
            this.LblSch1.Location = new System.Drawing.Point(10, 20);
            this.LblSch1.Name = "LblSch1";
            this.LblSch1.Size = new System.Drawing.Size(61, 13);
            this.LblSch1.TabIndex = 17;
            this.LblSch1.Text = "Schakelaar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnHueOn1);
            this.groupBox1.Controls.Add(this.LblHue1);
            this.groupBox1.Controls.Add(this.CmbHue1);
            this.groupBox1.Controls.Add(this.BtnHueOff);
            this.groupBox1.Location = new System.Drawing.Point(218, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HUE Lamps";
            // 
            // BtnHueOn1
            // 
            this.BtnHueOn1.Location = new System.Drawing.Point(90, 20);
            this.BtnHueOn1.Name = "BtnHueOn1";
            this.BtnHueOn1.Size = new System.Drawing.Size(35, 25);
            this.BtnHueOn1.TabIndex = 1;
            this.BtnHueOn1.Text = "ON";
            this.BtnHueOn1.UseVisualStyleBackColor = true;
            this.BtnHueOn1.Click += new System.EventHandler(this.BtnHueOn1_Click);
            // 
            // LblHue1
            // 
            this.LblHue1.AutoSize = true;
            this.LblHue1.Location = new System.Drawing.Point(10, 25);
            this.LblHue1.Name = "LblHue1";
            this.LblHue1.Size = new System.Drawing.Size(27, 13);
            this.LblHue1.TabIndex = 13;
            this.LblHue1.Text = "Hue";
            // 
            // CmbHue1
            // 
            this.CmbHue1.FormattingEnabled = true;
            this.CmbHue1.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Cyan",
            "Blue"});
            this.CmbHue1.Location = new System.Drawing.Point(130, 21);
            this.CmbHue1.Name = "CmbHue1";
            this.CmbHue1.Size = new System.Drawing.Size(75, 21);
            this.CmbHue1.TabIndex = 14;
            // 
            // BtnHueOff
            // 
            this.BtnHueOff.Location = new System.Drawing.Point(210, 20);
            this.BtnHueOff.Name = "BtnHueOff";
            this.BtnHueOff.Size = new System.Drawing.Size(35, 25);
            this.BtnHueOff.TabIndex = 2;
            this.BtnHueOff.Text = "OFF";
            this.BtnHueOff.UseVisualStyleBackColor = true;
            this.BtnHueOff.Click += new System.EventHandler(this.BtnHueOff1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thermometer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current temp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Current Hum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 270);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConHW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnHueOff;
        private System.Windows.Forms.Button BtnHueOn1;
        private System.Windows.Forms.Label LblHue1;
        private System.Windows.Forms.ComboBox CmbHue1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblSch2;
        private System.Windows.Forms.Button BtnSchOff2;
        private System.Windows.Forms.Button BtnSchOn1;
        private System.Windows.Forms.Button BtnSchOff1;
        private System.Windows.Forms.Label LblSch1;
        private System.Windows.Forms.Button BtnSchOn2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

