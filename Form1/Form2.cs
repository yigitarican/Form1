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
    /// <summary>
    /// User login form appears at the very beginning of the program.
    /// </summary>
    public partial class UserLogin : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=YIGITARICAN\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");
        private SqlCommand command;
        private SqlDataReader reader;
        public  CurrentUser currentUser;
        private bool isVisible = false;

        public UserLogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// User login buttton click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand("select * from userTable where UserName = '"+tbUserName.Text+"' and Password='"+tbPassword.Text+"'",connection);
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["UserName"].ToString() == tbUserName.Text && reader["Password"].ToString() == tbPassword.Text)
                {
                    currentUser = new CurrentUser()
                    {
                        UserID = int.Parse(reader["ID"].ToString()),
                        UserName = reader["UserName"].ToString(),
                        Password = reader["Password"].ToString(),
                        Name = reader["Name"].ToString(),
                        Surname = reader["Surname"].ToString(),
                        profilePicture = reader["ProfilePicture"].ToString(),
                    };

                    MessageBox.Show("Merhaba " + currentUser.Name + " " + currentUser.Surname + ".", "Giriş başarılı");
                    this.Hide();
                    MainScreen form1 = new MainScreen();
                    form1.liste.Add(currentUser);
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifreniz yanlış.", "Giriş Başarısız");
                }
            }
            connection.Close();
        }

        /// <summary>
        /// In password textbox, after click enter button it automatically logins(if password is correct.).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                button1_Click(sender, e);
            }
        }

        /// <summary>
        /// Creates register form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            Register form4 = new Register();
            form4.Show();
        }

        /// <summary>
        /// Removes password mask or masks password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb2_Click(object sender, EventArgs e)
        {
            if (!isVisible)
            {
                tbPassword.PasswordChar = '\0';
                pb2.Image = Image.FromFile(@"C:\Users\yigit.arican\source\repos\Form1\Form1\Resources\eyeClosed.png");
                isVisible = true;
            }
            else
            {
                tbPassword.PasswordChar = '*';
                pb2.Image = Image.FromFile(@"C:\Users\yigit.arican\source\repos\Form1\Form1\Resources\eyeOpened.png");
                isVisible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ResetPassword form5 = new ResetPassword();
            form5.Show();
        }
    }
}
