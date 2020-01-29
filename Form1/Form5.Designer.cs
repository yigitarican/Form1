namespace Form1
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.userName = new System.Windows.Forms.TextBox();
            this.newPword1 = new System.Windows.Forms.TextBox();
            this.newPword2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resetPin = new System.Windows.Forms.TextBox();
            this.resetPinLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.passwordPB = new System.Windows.Forms.PictureBox();
            this.infoPB = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.passwordPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(50, 52);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(285, 22);
            this.userName.TabIndex = 0;
            // 
            // newPword1
            // 
            this.newPword1.Location = new System.Drawing.Point(50, 130);
            this.newPword1.Name = "newPword1";
            this.newPword1.PasswordChar = '*';
            this.newPword1.Size = new System.Drawing.Size(285, 22);
            this.newPword1.TabIndex = 1;
            // 
            // newPword2
            // 
            this.newPword2.Location = new System.Drawing.Point(50, 210);
            this.newPword2.Name = "newPword2";
            this.newPword2.PasswordChar = '*';
            this.newPword2.Size = new System.Drawing.Size(285, 22);
            this.newPword2.TabIndex = 2;
            this.newPword2.TextChanged += new System.EventHandler(this.newPword2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yeni Şifre Tekrar:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(86, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Şifreyi Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetPin
            // 
            this.resetPin.Location = new System.Drawing.Point(50, 291);
            this.resetPin.MaxLength = 4;
            this.resetPin.Name = "resetPin";
            this.resetPin.PasswordChar = '*';
            this.resetPin.Size = new System.Drawing.Size(285, 22);
            this.resetPin.TabIndex = 8;
            // 
            // resetPinLabel
            // 
            this.resetPinLabel.AutoSize = true;
            this.resetPinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetPinLabel.Location = new System.Drawing.Point(47, 260);
            this.resetPinLabel.Name = "resetPinLabel";
            this.resetPinLabel.Size = new System.Drawing.Size(36, 18);
            this.resetPinLabel.TabIndex = 9;
            this.resetPinLabel.Text = "PIN:";
            // 
            // passwordPB
            // 
            this.passwordPB.Location = new System.Drawing.Point(341, 210);
            this.passwordPB.Name = "passwordPB";
            this.passwordPB.Size = new System.Drawing.Size(33, 30);
            this.passwordPB.TabIndex = 10;
            this.passwordPB.TabStop = false;
            // 
            // infoPB
            // 
            this.infoPB.Image = global::Form1.Properties.Resources.infoPic;
            this.infoPB.Location = new System.Drawing.Point(341, 291);
            this.infoPB.Name = "infoPB";
            this.infoPB.Size = new System.Drawing.Size(33, 30);
            this.infoPB.TabIndex = 7;
            this.infoPB.TabStop = false;
            this.infoPB.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 426);
            this.Controls.Add(this.passwordPB);
            this.Controls.Add(this.resetPinLabel);
            this.Controls.Add(this.resetPin);
            this.Controls.Add(this.infoPB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPword2);
            this.Controls.Add(this.newPword1);
            this.Controls.Add(this.userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPassword";
            this.Text = "Şifreyi Yenile";
            ((System.ComponentModel.ISupportInitialize)(this.passwordPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox newPword1;
        private System.Windows.Forms.TextBox newPword2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox infoPB;
        private System.Windows.Forms.TextBox resetPin;
        private System.Windows.Forms.Label resetPinLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox passwordPB;
        private System.Windows.Forms.Timer timer1;
    }
}