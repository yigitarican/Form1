using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form1
{

    public partial class Form8 : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=YIGITARICAN\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");
        private SqlCommand command;
        public List<CurrentUser> liste = new List<CurrentUser>();

        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            open.Filter = string.Format("{0}{1}{2} ({3})|{3}", open.Filter, "", "All Files", "*.*");

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                open.Filter = string.Format("{0}{1}{2} ({3})|{3}", open.Filter, "|", codecName, c.FilenameExtension);
            }

            open.FilterIndex = 1;
            open.RestoreDirectory = true;
            open.Multiselect = false;

            if(open.ShowDialog() == DialogResult.OK)
            {
                pp.Image = Image.FromFile(open.FileName);
                liste[0].profilePicture = open.FileName;
            }

            connection.Open();
            command = new SqlCommand("update userTable set ProfilePicture='"+open.FileName+"' where ID='" + this.liste[0].UserID + "'", connection);
            liste[0].profilePicture = open.FileName;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if(this.liste[0].profilePicture != "")
            {
                pp.Image = Image.FromFile(this.liste[0].profilePicture);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pp.Image = null;
            connection.Open();
            command = new SqlCommand("update userTable set ProfilePicture= null where ID='" + this.liste[0].UserID + "'", connection);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
