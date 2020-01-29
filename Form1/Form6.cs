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
using System.Net.Mail;


namespace Form1
{
    public partial class AddCategory : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=YIGITARICAN\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");
        private SqlCommand command;
        public List<CurrentUser> liste = new List<CurrentUser>();
        public int mcID;

        public AddCategory()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Adds New Main Category or Category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (tbMC.ReadOnly) //Adds category
            {
                command = new SqlCommand("insert into Category(CategoryName,MainCategoryID,isActive) values('"+tbCat.Text+"','"+mcID+"',1) ", connection);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                command = new SqlCommand("select CategoryID from Category where CategoryName='"+tbCat.Text+"'", connection);
                int CatID = (int)command.ExecuteScalar();
                command = new SqlCommand("insert into userCategories(UserID,CategoryID) values('"+this.liste[0].UserID+"','"+CatID+ "') ", connection);
            }
            else //Adds main category
            {
                command = new SqlCommand("insert into MainCategory(MainCategoryName,UserID,isActive) values('"+tbMC.Text+"','"+this.liste[0].UserID+"',1)", connection);
            }
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
