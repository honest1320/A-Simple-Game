namespace MyProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.organikBtn = new System.Windows.Forms.Button();
            this.oragnikBosalt = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.kagitBtn = new System.Windows.Forms.Button();
            this.kagitBosalt = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.camBtn = new System.Windows.Forms.Button();
            this.camBosalt = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.metalBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.puanKutusu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.yeniOyun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATIK   KUTULARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Ivory;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 121);
            this.listBox1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(220, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.splitContainer1.Panel1.Controls.Add(this.organikBtn);
            this.splitContainer1.Panel1.Controls.Add(this.oragnikBosalt);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.splitContainer1.Panel2.Controls.Add(this.kagitBtn);
            this.splitContainer1.Panel2.Controls.Add(this.kagitBosalt);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar2);
            this.splitContainer1.Panel2.Controls.Add(this.listBox2);
            this.splitContainer1.Size = new System.Drawing.Size(305, 218);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 3;
            // 
            // organikBtn
            // 
            this.organikBtn.BackColor = System.Drawing.Color.White;
            this.organikBtn.Enabled = false;
            this.organikBtn.Location = new System.Drawing.Point(5, 3);
            this.organikBtn.Name = "organikBtn";
            this.organikBtn.Size = new System.Drawing.Size(139, 37);
            this.organikBtn.TabIndex = 5;
            this.organikBtn.Text = "ORGANİK   ATIK";
            this.organikBtn.UseVisualStyleBackColor = false;
            this.organikBtn.Click += new System.EventHandler(this.organikBtn_Click);
            // 
            // oragnikBosalt
            // 
            this.oragnikBosalt.Enabled = false;
            this.oragnikBosalt.Location = new System.Drawing.Point(3, 192);
            this.oragnikBosalt.Name = "oragnikBosalt";
            this.oragnikBosalt.Size = new System.Drawing.Size(141, 23);
            this.oragnikBosalt.TabIndex = 4;
            this.oragnikBosalt.Text = "BOŞALT";
            this.oragnikBosalt.UseVisualStyleBackColor = true;
            this.oragnikBosalt.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(3, 170);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(141, 26);
            this.progressBar1.TabIndex = 3;
            // 
            // kagitBtn
            // 
            this.kagitBtn.BackColor = System.Drawing.Color.White;
            this.kagitBtn.Enabled = false;
            this.kagitBtn.Location = new System.Drawing.Point(-1, 3);
            this.kagitBtn.Name = "kagitBtn";
            this.kagitBtn.Size = new System.Drawing.Size(146, 37);
            this.kagitBtn.TabIndex = 4;
            this.kagitBtn.Text = "KAĞIT";
            this.kagitBtn.UseVisualStyleBackColor = false;
            this.kagitBtn.Click += new System.EventHandler(this.kagitBtn_Click);
            // 
            // kagitBosalt
            // 
            this.kagitBosalt.Enabled = false;
            this.kagitBosalt.Location = new System.Drawing.Point(3, 192);
            this.kagitBosalt.Name = "kagitBosalt";
            this.kagitBosalt.Size = new System.Drawing.Size(148, 23);
            this.kagitBosalt.TabIndex = 3;
            this.kagitBosalt.Text = "BOŞALT";
            this.kagitBosalt.UseVisualStyleBackColor = true;
            this.kagitBosalt.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.Lime;
            this.progressBar2.Location = new System.Drawing.Point(5, 170);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(146, 26);
            this.progressBar2.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Ivory;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(5, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(146, 121);
            this.listBox2.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(220, 273);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.splitContainer2.Panel1.Controls.Add(this.camBtn);
            this.splitContainer2.Panel1.Controls.Add(this.camBosalt);
            this.splitContainer2.Panel1.Controls.Add(this.progressBar3);
            this.splitContainer2.Panel1.Controls.Add(this.listBox3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.splitContainer2.Panel2.Controls.Add(this.metalBtn);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(this.progressBar4);
            this.splitContainer2.Panel2.Controls.Add(this.listBox4);
            this.splitContainer2.Size = new System.Drawing.Size(305, 256);
            this.splitContainer2.SplitterDistance = 149;
            this.splitContainer2.TabIndex = 4;
            // 
            // camBtn
            // 
            this.camBtn.BackColor = System.Drawing.Color.White;
            this.camBtn.Enabled = false;
            this.camBtn.Location = new System.Drawing.Point(3, 3);
            this.camBtn.Name = "camBtn";
            this.camBtn.Size = new System.Drawing.Size(143, 39);
            this.camBtn.TabIndex = 4;
            this.camBtn.Text = "CAM";
            this.camBtn.UseVisualStyleBackColor = false;
            this.camBtn.Click += new System.EventHandler(this.camBtn_Click);
            // 
            // camBosalt
            // 
            this.camBosalt.Enabled = false;
            this.camBosalt.Location = new System.Drawing.Point(3, 222);
            this.camBosalt.Name = "camBosalt";
            this.camBosalt.Size = new System.Drawing.Size(143, 28);
            this.camBosalt.TabIndex = 3;
            this.camBosalt.Text = "BOŞALT";
            this.camBosalt.UseVisualStyleBackColor = true;
            this.camBosalt.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.Color.Lime;
            this.progressBar3.Location = new System.Drawing.Point(3, 198);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(143, 23);
            this.progressBar3.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Ivory;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(3, 45);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(143, 147);
            this.listBox3.TabIndex = 0;
            // 
            // metalBtn
            // 
            this.metalBtn.BackColor = System.Drawing.Color.White;
            this.metalBtn.Enabled = false;
            this.metalBtn.Location = new System.Drawing.Point(3, 3);
            this.metalBtn.Name = "metalBtn";
            this.metalBtn.Size = new System.Drawing.Size(146, 36);
            this.metalBtn.TabIndex = 3;
            this.metalBtn.Text = "METAL";
            this.metalBtn.UseVisualStyleBackColor = false;
            this.metalBtn.Click += new System.EventHandler(this.metalBtn_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(3, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 31);
            this.button4.TabIndex = 2;
            this.button4.Text = "BOŞALT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar4
            // 
            this.progressBar4.ForeColor = System.Drawing.Color.Lime;
            this.progressBar4.Location = new System.Drawing.Point(3, 198);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(146, 23);
            this.progressBar4.TabIndex = 1;
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.Ivory;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(3, 45);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(146, 147);
            this.listBox4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.puanKutusu);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.yeniOyun);
            this.panel1.Location = new System.Drawing.Point(12, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 334);
            this.panel1.TabIndex = 6;
            // 
            // puanKutusu
            // 
            this.puanKutusu.BackColor = System.Drawing.Color.MintCream;
            this.puanKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.puanKutusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puanKutusu.Location = new System.Drawing.Point(16, 208);
            this.puanKutusu.Name = "puanKutusu";
            this.puanKutusu.Size = new System.Drawing.Size(162, 74);
            this.puanKutusu.TabIndex = 9;
            this.puanKutusu.Text = "0";
            this.puanKutusu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.MintCream;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 68);
            this.label8.TabIndex = 8;
            this.label8.Text = "60";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "SÜRE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "PUAN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(31, 294);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "ÇIKIŞ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // yeniOyun
            // 
            this.yeniOyun.BackColor = System.Drawing.Color.DarkSlateGray;
            this.yeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeniOyun.Location = new System.Drawing.Point(16, 14);
            this.yeniOyun.Name = "yeniOyun";
            this.yeniOyun.Size = new System.Drawing.Size(162, 55);
            this.yeniOyun.TabIndex = 0;
            this.yeniOyun.Text = "YENI OYUN";
            this.yeniOyun.UseVisualStyleBackColor = false;
            this.yeniOyun.Click += new System.EventHandler(this.yeniOyun_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 176);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(537, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " ATIK TOPLAMA";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button oragnikBosalt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button kagitBosalt;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button camBosalt;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button yeniOyun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label puanKutusu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button organikBtn;
        private System.Windows.Forms.Button kagitBtn;
        private System.Windows.Forms.Button camBtn;
        private System.Windows.Forms.Button metalBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

