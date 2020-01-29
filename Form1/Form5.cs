using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form1
{
    public partial class ResetPassword : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=YIGITARICAN\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");
        private SqlCommand command;
        private SqlDataReader reader;

        public ResetPassword()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Şifreyi Yenileme butonuna basma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (isUserExist() && newPword1.Text == newPword2.Text)
            {
                connection.Open();
                command = new SqlCommand("update userTable set Password='"+newPword1.Text+"' where UserName='"+userName.Text+"' ",connection);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show("Şifreniz başarıyla değiştirildi.", "Uyarı");
                connection.Close();
                this.Close();
            }
            else if(newPword1.Text != newPword2.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor.", "Uyarı");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve PIN eşleşmiyor", "Uyarı");
            }
            connection.Close();
        }

        /// <summary>
        /// Girilen kullanıcı adı doğru mu yanlış mı?
        /// </summary>
        /// <returns></returns>
        private bool isUserExist()
        {
            try
            {
                command = new SqlCommand("select UserName,passwordResetPIN from userTable where UserName='" + userName.Text + "' and passwordResetPIN='" + int.Parse(resetPin.Text) + "' ", connection);
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    connection.Close();
                    return true;
                }
                return false;
            }
            catch(FormatException ex)
            {
                MessageBox.Show("PIN değeriniz sadece sayılardan oluşmalıdır.", "Uyarı");
                connection.Close();
                return false;
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Şifre sıfırlama pininiz.",infoPB);
        }

        #region girilen yeni şifreleri karşılaştırma

        private void newPword2_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (newPword1.Text != newPword2.Text)
            {
                passwordPB.Image = Image.FromFile(@"C:\Users\yigit.arican\source\repos\Form1\Form1\Resources\wrongPassword.png");
            }
            else
            {
                passwordPB.Image = Image.FromFile(@"C:\Users\yigit.arican\source\repos\Form1\Form1\Resources\passwordCorrect.png");
            }
            timer1.Stop();
        }

        #endregion
    }
}
