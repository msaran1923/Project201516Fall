namespace proje
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.rbtnHashtag = new System.Windows.Forms.RadioButton();
            this.rbtnKelime = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTweets = new System.Windows.Forms.ListBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtspellcheck = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(336, 23);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(482, 20);
            this.txtAra.TabIndex = 0;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(838, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(98, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // rbtnHashtag
            // 
            this.rbtnHashtag.AutoSize = true;
            this.rbtnHashtag.Location = new System.Drawing.Point(441, 49);
            this.rbtnHashtag.Name = "rbtnHashtag";
            this.rbtnHashtag.Size = new System.Drawing.Size(63, 17);
            this.rbtnHashtag.TabIndex = 2;
            this.rbtnHashtag.TabStop = true;
            this.rbtnHashtag.Text = "# ile ara";
            this.rbtnHashtag.UseVisualStyleBackColor = true;
            // 
            // rbtnKelime
            // 
            this.rbtnKelime.AutoSize = true;
            this.rbtnKelime.Location = new System.Drawing.Point(633, 49);
            this.rbtnKelime.Name = "rbtnKelime";
            this.rbtnKelime.Size = new System.Drawing.Size(87, 17);
            this.rbtnKelime.TabIndex = 3;
            this.rbtnKelime.TabStop = true;
            this.rbtnKelime.Text = "Kelime ile ara";
            this.rbtnKelime.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arama";
            // 
            // lstTweets
            // 
            this.lstTweets.FormattingEnabled = true;
            this.lstTweets.Location = new System.Drawing.Point(281, 75);
            this.lstTweets.Name = "lstTweets";
            this.lstTweets.Size = new System.Drawing.Size(657, 446);
            this.lstTweets.TabIndex = 5;
            this.lstTweets.SelectedIndexChanged += new System.EventHandler(this.lstTweets_SelectedIndexChanged);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(838, 542);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // txtspellcheck
            // 
            this.txtspellcheck.Location = new System.Drawing.Point(106, 75);
            this.txtspellcheck.Multiline = true;
            this.txtspellcheck.Name = "txtspellcheck";
            this.txtspellcheck.Size = new System.Drawing.Size(143, 20);
            this.txtspellcheck.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 583);
            this.Controls.Add(this.txtspellcheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.lstTweets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnKelime);
            this.Controls.Add(this.rbtnHashtag);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RadioButton rbtnHashtag;
        private System.Windows.Forms.RadioButton rbtnKelime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTweets;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtspellcheck;
    }
}

