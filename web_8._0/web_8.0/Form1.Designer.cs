namespace web_8._0
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_f = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_idi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(19, 103);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1017, 507);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btn_f
            // 
            this.btn_f.Location = new System.Drawing.Point(916, 12);
            this.btn_f.Name = "btn_f";
            this.btn_f.Size = new System.Drawing.Size(75, 42);
            this.btn_f.TabIndex = 1;
            this.btn_f.Text = "naprijed";
            this.btn_f.UseVisualStyleBackColor = true;
            this.btn_f.Click += new System.EventHandler(this.btn_f_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(839, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(71, 42);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "nazad";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(760, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(73, 42);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "kuća";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_idi
            // 
            this.btn_idi.Location = new System.Drawing.Point(423, 35);
            this.btn_idi.Name = "btn_idi";
            this.btn_idi.Size = new System.Drawing.Size(75, 23);
            this.btn_idi.TabIndex = 5;
            this.btn_idi.Text = "Idi";
            this.btn_idi.UseVisualStyleBackColor = true;
            this.btn_idi.Click += new System.EventHandler(this.btn_idi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adresa stranice";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_idi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_f);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_f;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_idi;
        private System.Windows.Forms.Label label1;
    }
}

