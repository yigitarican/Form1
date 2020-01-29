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
    /// This form opens after clicking adding new note button.
    /// </summary>
    public partial class NewNote : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=YIGITARICAN\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");
        private SqlCommand command;
        private SqlDataReader reader;
        public List<CurrentUser> liste = new List<CurrentUser>();
        private bool firsttime1 = true;
        private bool firsttime2 = true;
        public int MainCatID;
        private int CatID;

        public NewNote()
        {
            InitializeComponent();
        }

        #region Fill events

        /// <summary>
        /// Fills combobox with main category names.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_Load(object sender, EventArgs e)
        {
            fillMainCategoryCB(this.liste[0]);
            MainScreen form1 = new MainScreen();
        }

        /// <summary>
        /// Fills second combobox with subcategory names wrt their main category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbMC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMC1.SelectedItem != null)
            {
                getIDofMainCategory();
                fillCatCB(liste[0]);
            }
            else
            {
                cbCat1.Enabled = false;
            }
        }

        /// <summary>
        /// fills main category combobox
        /// </summary>
        /// <param name="currentUser"></param>
        public void fillMainCategoryCB(CurrentUser currentUser)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            cbMC1.Items.Clear();
            command = new SqlCommand("select * from MainCategory where MainCategory.UserID = '"+currentUser.UserID+"'", connection);
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbMC1.Items.Add(reader["MainCategoryName"]);
            }
            connection.Close();
        }

        /// <summary>
        /// Fills category combobox
        /// </summary>
        /// <param name="currentUser"></param>
        public void fillCatCB(CurrentUser currentUser)
        {
            if (connection.State == ConnectionState.Closed) 
            {
                connection.Open();
            }
            cbCat1.Text = "Alt Kategori Seçin";
            cbCat1.Items.Clear();
            command = new SqlCommand("select Category.CategoryName, Category.MainCategoryID, userCategories.UserID from Category inner join userCategories on Category.CategoryID = userCategories.CategoryID where MainCategoryID='" + MainCatID + "' and UserID='"+currentUser.UserID+"' ", connection);
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbCat1.Items.Add(reader["CategoryName"]);
            }
            connection.Close();
        }  

        #endregion


        #region Click Events

        /// <summary>
        /// Places text cursor at the beginning of the header box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (firsttime1)
            {
                tbHeader.Select(0, 0);
            }
            
        }

        /// <summary>
        /// Clears initial header when user types something.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbHeader_TextChanged(object sender, EventArgs e)
        {
            if (firsttime1)
            {
                tbHeader.Clear();
                firsttime1 = false;
            }
        }

        /// <summary>
        /// If user remove what it writes completely, it fills header TB with initial header("Başlık").
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbHeader_KeyUp(object sender, KeyEventArgs e)
        {
            if(Convert.ToInt32(e.KeyCode) == 8)
            {
                if(tbHeader.Text == "")
                {
                    tbHeader.Text = "Başlık";
                    firsttime1 = true;
                }
            }
        }

        private void rtbNote_TextChanged(object sender, EventArgs e)
        {
            if (firsttime2)
            {
                rtbNote.Clear();
                firsttime2 = false;
            }
        }

        private void rtbNote_Click(object sender, EventArgs e)
        {
            if (firsttime2)
            {
                rtbNote.Select(0, 0);
            }
        }

        private void rtbNote_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 8)
            {
                if (rtbNote.Text == "")
                {
                    rtbNote.Text = "Yeni bir not ekleyin.";
                    firsttime2 = true;
                }
            }
        }
        #endregion


        /// <summary>
        /// Adds new note and closes this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCat1.SelectedItem != null && cbMC1.SelectedItem != null)
                {
                    getIDofCategory();
                    connection.Open();
                    command = new SqlCommand("insert into NotesTable(NoteHeader,Notes,UserID,CategoryID,isActive) values('" + tbHeader.Text + "','" + rtbNote.Text + "','" + liste[0].UserID + "','" + CatID + "',1)", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bir kategori veya ana kategori seçilmemiş.", "Uyarı");
                }
            }
            catch
            {
                MessageBox.Show("Karakter sınırını aştınız. Karakter sınırı: 50","Uyarı");
            }
        }

        #region Main Category and Category ID get functions

        /// <summary>
        /// Gets ID of the Main Category selected in combobox.
        /// </summary>
        private void getIDofMainCategory()
        {
            connection.Open();
            command = new SqlCommand("select * from MainCategory where MainCategoryName='" + cbMC1.SelectedItem + "'", connection);
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                MainCatID = int.Parse(reader["MainCategoryID"].ToString());
            }
            connection.Close();
        }

        /// <summary>
        /// Gets ID of the category selected in category combobox.
        /// </summary>
        private void getIDofCategory()
        {
            connection.Open();
            command = new SqlCommand("select * from Category where CategoryName='" + cbCat1.SelectedItem + "'", connection);
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                CatID = int.Parse(reader["CategoryID"].ToString());
            }
            connection.Close();
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddCategory form6 = new AddCategory();
            form6.liste.Add(this.liste[0]);
            form6.tbCat.ReadOnly = true;
            form6.ShowDialog();   
            fillMainCategoryCB(liste[0]);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                AddCategory form6 = new AddCategory();
                form6.liste.Add(this.liste[0]);
                form6.mcID = MainCatID;
                form6.tbMC.Text = cbMC1.SelectedItem.ToString();
                form6.tbMC.ReadOnly = true;
                form6.ShowDialog();
                fillCatCB(liste[0]);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Lütfen yaratacağınız kategorinin ana kategorisini seçin veya yeni bir ana kategori yaratın.","Uyarı"); 
            }
        }


    }

}
