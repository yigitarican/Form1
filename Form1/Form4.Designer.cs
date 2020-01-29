namespace Form1
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resetPIN = new System.Windows.Forms.TextBox();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.infoPB = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.manBtn = new System.Windows.Forms.RadioButton();
            this.womanBtn = new System.Windows.Forms.RadioButton();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(63, 63);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(148, 22);
            this.nameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(266, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(60, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre:";
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(269, 63);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(148, 22);
            this.surnameTB.TabIndex = 5;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(63, 158);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(354, 22);
            this.usernameTB.TabIndex = 6;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(63, 318);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(354, 22);
            this.passwordTB.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Location = new System.Drawing.Point(81, 503);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(151, 31);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Kaydol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(269, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 31);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(60, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "PIN:";
            // 
            // resetPIN
            // 
            this.resetPIN.Location = new System.Drawing.Point(63, 410);
            this.resetPIN.MaxLength = 4;
            this.resetPIN.Name = "resetPIN";
            this.resetPIN.PasswordChar = '*';
            this.resetPIN.Size = new System.Drawing.Size(103, 22);
            this.resetPIN.TabIndex = 13;
            // 
            // pbEye
            // 
            this.pbEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEye.Image = global::Form1.Properties.Resources.eyeOpened;
            this.pbEye.Location = new System.Drawing.Point(423, 318);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(33, 30);
            this.pbEye.TabIndex = 9;
            this.pbEye.TabStop = false;
            this.pbEye.Click += new System.EventHandler(this.pbEye_Click);
            // 
            // infoPB
            // 
            this.infoPB.Image = global::Form1.Properties.Resources.infoPic;
            this.infoPB.Location = new System.Drawing.Point(172, 410);
            this.infoPB.Name = "infoPB";
            this.infoPB.Size = new System.Drawing.Size(26, 24);
            this.infoPB.TabIndex = 8;
            this.infoPB.TabStop = false;
            this.infoPB.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cinsiyet:";
            // 
            // manBtn
            // 
            this.manBtn.AutoSize = true;
            this.manBtn.Location = new System.Drawing.Point(291, 411);
            this.manBtn.Name = "manBtn";
            this.manBtn.Size = new System.Drawing.Size(65, 21);
            this.manBtn.TabIndex = 15;
            this.manBtn.TabStop = true;
            this.manBtn.Text = "Erkek";
            this.manBtn.UseVisualStyleBackColor = true;
            // 
            // womanBtn
            // 
            this.womanBtn.AutoSize = true;
            this.womanBtn.Location = new System.Drawing.Point(291, 438);
            this.womanBtn.Name = "womanBtn";
            this.womanBtn.Size = new System.Drawing.Size(65, 21);
            this.womanBtn.TabIndex = 16;
            this.womanBtn.TabStop = true;
            this.womanBtn.Text = "Kadın";
            this.womanBtn.UseVisualStyleBackColor = true;
            // 
            // mailTB
            // 
            this.mailTB.Location = new System.Drawing.Point(63, 234);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(354, 22);
            this.mailTB.TabIndex = 17;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(60, 202);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 17);
            this.email.TabIndex = 18;
            this.email.Text = "Email:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 569);
            this.Controls.Add(this.email);
            this.Controls.Add(this.mailTB);
            this.Controls.Add(this.womanBtn);
            this.Controls.Add(this.manBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resetPIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pbEye);
            this.Controls.Add(this.infoPB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Kullanıcı Kaydı";
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.PictureBox infoPB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbEye;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resetPIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton manBtn;
        private System.Windows.Forms.RadioButton womanBtn;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.Label email;
    }
}