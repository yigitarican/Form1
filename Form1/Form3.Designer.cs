namespace Form1
{
    partial class NewNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNote));
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.cbMC1 = new System.Windows.Forms.ComboBox();
            this.tbHeader = new System.Windows.Forms.TextBox();
            this.cbCat1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbNote
            // 
            this.rtbNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbNote.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rtbNote.Location = new System.Drawing.Point(-1, 71);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(562, 405);
            this.rtbNote.TabIndex = 0;
            this.rtbNote.Text = "Yeni bir not ekleyin";
            this.rtbNote.Click += new System.EventHandler(this.rtbNote_Click);
            this.rtbNote.TextChanged += new System.EventHandler(this.rtbNote_TextChanged);
            this.rtbNote.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbNote_KeyUp);
            // 
            // cbMC1
            // 
            this.cbMC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMC1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbMC1.FormattingEnabled = true;
            this.cbMC1.Items.AddRange(new object[] {
            "Haberler"});
            this.cbMC1.Location = new System.Drawing.Point(0, 41);
            this.cbMC1.Name = "cbMC1";
            this.cbMC1.Size = new System.Drawing.Size(147, 24);
            this.cbMC1.TabIndex = 2;
            this.cbMC1.Text = "Ana Kategori Seçin";
            this.cbMC1.SelectedIndexChanged += new System.EventHandler(this.cbMC1_SelectedIndexChanged);
            // 
            // tbHeader
            // 
            this.tbHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbHeader.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbHeader.Location = new System.Drawing.Point(-1, 0);
            this.tbHeader.Multiline = true;
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.Size = new System.Drawing.Size(562, 35);
            this.tbHeader.TabIndex = 3;
            this.tbHeader.Text = "Başlık";
            this.tbHeader.Click += new System.EventHandler(this.textBox1_Click);
            this.tbHeader.TextChanged += new System.EventHandler(this.tbHeader_TextChanged);
            this.tbHeader.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbHeader_KeyUp);
            // 
            // cbCat1
            // 
            this.cbCat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCat1.ForeColor = System.Drawing.Color.Black;
            this.cbCat1.FormattingEnabled = true;
            this.cbCat1.Location = new System.Drawing.Point(202, 41);
            this.cbCat1.Name = "cbCat1";
            this.cbCat1.Size = new System.Drawing.Size(147, 24);
            this.cbCat1.TabIndex = 4;
            this.cbCat1.Text = "Alt Kategori Seçin";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(462, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Form1.Properties.Resources.add;
            this.pictureBox2.Location = new System.Drawing.Point(355, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 24);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Form1.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(153, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 24);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 475);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCat1);
            this.Controls.Add(this.tbHeader);
            this.Controls.Add(this.cbMC1);
            this.Controls.Add(this.rtbNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewNote";
            this.Text = "Yeni Not";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNote;
        public System.Windows.Forms.ComboBox cbMC1;
        private System.Windows.Forms.TextBox tbHeader;
        public System.Windows.Forms.ComboBox cbCat1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}