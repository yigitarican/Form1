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
    public partial class Register : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=YIGITARICAN\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");
        private SqlCommand command;
        private SqlDataReader reader;
        private bool isVisible = false;

        public Register()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows info after hover on info logo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Şifrenizi değiştirmek için kullanacağınız PIN kodu. NOT:Sadece sayı içermelidir.",infoPB);
        }

        /// <summary>
        /// Masks password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbEye_Click(object sender, EventArgs e)
        {
            if (!isVisible)
            {
                passwordTB.PasswordChar = '\0';
                pbEye.Image = Image.FromFile(@"C:\Users\yigit.arican\source\repos\Form1\Form1\Resources\eyeClosed.png");
                isVisible = true;
            }
            else
            {
                passwordTB.PasswordChar = '*';
                pbEye.Image = Image.FromFile(@"C:\Users\yigit.arican\source\repos\Form1\Form1\Resources\eyeOpened.png");
                isVisible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event happens after clicking register button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string gender = "";
            if(manBtn.Checked)
            {
                gender = manBtn.Text;

            }else if (womanBtn.Checked)
            {
                gender = womanBtn.Text;
            }
            try
            {
                if (usernameTB.Text.Length != 0 && passwordTB.Text.Length != 0)
                {
                    connection.Open();
                    if (!isUserNameTaken())
                    {
                        connection.Open();
                        command = new SqlCommand("insert into userTable(UserName,Password,Name,Surname,passwordResetPIN,Gender,Email) values('" + usernameTB.Text + "','" + passwordTB.Text + "','" + nameTB.Text + "','" + surnameTB.Text + "','" + int.Parse(resetPIN.Text) + "','"+gender+"','"+mailTB.Text+"')", connection);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Kullanıcı kaydı başarılı.", "Kullanıcı Kaydı");
                        this.Close();
                    }
                }
                else if (usernameTB.Text.Length == 0 && passwordTB.Text.Length == 0)
                {
                    MessageBox.Show("Kullanıcı adı ve şifre alanı boş olamaz. ", "Uyarı");

                }
                else if (usernameTB.Text.Length == 0)
                {
                    MessageBox.Show("Kullanıcı adı alanı boş olamaz.", "Uyarı");
                }
                else
                {
                    MessageBox.Show("Şifre alanı boş olamaz.", "Uyarı");
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("PIN kodunuz sadece numaralardan oluşmalıdır.", "Uyarı");
                connection.Close();
            }
        }

        /// <summary>
        /// Checks whether username is taken or not
        /// </summary>
        /// <returns></returns>
        private bool isUserNameTaken() //Checks whether username is taken or not
        {
            command = new SqlCommand("select UserName from userTable where UserName='"+usernameTB.Text+"' ", connection);
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show("Kullanıcı adı zaten alınmış.", "Uyarı");
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
    }
}
