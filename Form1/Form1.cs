using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Form1
{
    /// <summary>
    /// Application form.
    /// </summary>
    public partial class MainScreen : Form
    {
        #region Global Variables 
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileButton;
        private ToolStripMenuItem exitButton;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem appButton;
        private ToolStripMenuItem helpButtonTop;
        private NotifyIcon notifyIcon1;
        private IContainer components;

        private SqlConnection connection = new SqlConnection(@"Data Source=YIGITARICAN\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True");
        private SqlCommand command;
        private SqlDataReader reader;
        private DataTable dataTable;
        private SqlDataAdapter adapter;
        private BindingSource myTableBindingSource;
        private Panel panel1;
        private Label lbl1;
        private Panel panel2;
        private Button button1;
        private TreeView tree1;
        private Panel panel4;
        private ListBox lb1;
        private Panel panel5;
        public TextBox headerTB1;
        private RichTextBox rtb1;
        public List<CurrentUser> liste = new List<CurrentUser>();
        private List<string> temp = new List<string>();
        private Button update;
        private Button delete;
        private Button create;
        private ToolTip toolTip1;
        private Button button2;
        private PictureBox pbID;
        private ToolStripMenuItem yeniNotEkleToolStripMenuItem;
        private Panel panel6;
        private Label topicLabel;
        private TextBox searchBox;
        private Button button3;
        private Button mailButton;
        private ToolStripMenuItem oturumuKapatToolStripMenuItem;
        public TextBox categorySubTB;
        public TextBox categoryTB1;
        SelectedNote note = new SelectedNote();
        private GroupBox groupBox1;
        private Button button4;
        private DataGridView dgv1;
        public object[] info = new object[5];
        string strSavePath = @"C:\MyFolder\";
        DataTable dataTable2 = new DataTable();
        private Button button5;
        MailNote mailNote = new MailNote();
        public Common common;
        TreeNode root = new TreeNode("  \nKategori");
        private Button rescue;
        private bool firstTime = true;

        public CurrentUser cu { get; set; }

        #endregion

        public MainScreen()
        {
            InitializeComponent();
        }

        

        #region Written by Comp.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniNotEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oturumuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpButtonTop = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tree1 = new System.Windows.Forms.TreeView();
            this.create = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.mailButton = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.topicLabel = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.categorySubTB = new System.Windows.Forms.TextBox();
            this.categoryTB1 = new System.Windows.Forms.TextBox();
            this.headerTB1 = new System.Windows.Forms.TextBox();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.myTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rescue = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTableBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniNotEkleToolStripMenuItem,
            this.oturumuKapatToolStripMenuItem,
            this.exitButton});
            this.fileButton.Name = "fileButton";
            resources.ApplyResources(this.fileButton, "fileButton");
            // 
            // yeniNotEkleToolStripMenuItem
            // 
            this.yeniNotEkleToolStripMenuItem.Name = "yeniNotEkleToolStripMenuItem";
            resources.ApplyResources(this.yeniNotEkleToolStripMenuItem, "yeniNotEkleToolStripMenuItem");
            this.yeniNotEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniNotEkleToolStripMenuItem_Click);
            // 
            // oturumuKapatToolStripMenuItem
            // 
            this.oturumuKapatToolStripMenuItem.Name = "oturumuKapatToolStripMenuItem";
            resources.ApplyResources(this.oturumuKapatToolStripMenuItem, "oturumuKapatToolStripMenuItem");
            this.oturumuKapatToolStripMenuItem.Click += new System.EventHandler(this.oturumuKapatToolStripMenuItem_Click);
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appButton,
            this.helpButtonTop});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // appButton
            // 
            resources.ApplyResources(this.appButton, "appButton");
            this.appButton.Name = "appButton";
            this.appButton.Click += new System.EventHandler(this.appButton_Click);
            // 
            // helpButtonTop
            // 
            resources.ApplyResources(this.helpButtonTop, "helpButtonTop");
            this.helpButtonTop.Name = "helpButtonTop";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tree1);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deletedNotes);
            // 
            // tree1
            // 
            this.tree1.BackColor = System.Drawing.SystemColors.Control;
            this.tree1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.tree1, "tree1");
            this.tree1.Name = "tree1";
            this.tree1.ShowLines = false;
            this.tree1.ShowPlusMinus = false;
            this.tree1.ShowRootLines = false;
            this.tree1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree1_NodeMouseClick);
            // 
            // create
            // 
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.create, "create");
            this.create.Image = global::Form1.Properties.Resources.ekleme;
            this.create.Name = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            this.create.MouseHover += new System.EventHandler(this.create_MouseHover);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.listAllNotes);
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Name = "lbl1";
            // 
            // mailButton
            // 
            this.mailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.mailButton, "mailButton");
            this.mailButton.Image = global::Form1.Properties.Resources.sendMail;
            this.mailButton.Name = "mailButton";
            this.mailButton.UseVisualStyleBackColor = true;
            this.mailButton.Click += new System.EventHandler(this.mailButton_Click);
            this.mailButton.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.update, "update");
            this.update.Image = global::Form1.Properties.Resources.düzenleme;
            this.update.Name = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            this.update.MouseHover += new System.EventHandler(this.update_MouseHover);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.delete, "delete");
            this.delete.Image = global::Form1.Properties.Resources.deleteNote;
            this.delete.Name = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            this.delete.MouseHover += new System.EventHandler(this.delete_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pbID);
            this.panel2.Controls.Add(this.lbl1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pbID
            // 
            this.pbID.Image = global::Form1.Properties.Resources.ID;
            resources.ApplyResources(this.pbID, "pbID");
            this.pbID.Name = "pbID";
            this.pbID.TabStop = false;
            this.pbID.Click += new System.EventHandler(this.pbID_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.lb1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.searchBox);
            this.panel6.Controls.Add(this.topicLabel);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Image = global::Form1.Properties.Resources.magnifier;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Name = "searchBox";
            // 
            // topicLabel
            // 
            resources.ApplyResources(this.topicLabel, "topicLabel");
            this.topicLabel.Name = "topicLabel";
            // 
            // lb1
            // 
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lb1, "lb1");
            this.lb1.FormattingEnabled = true;
            this.lb1.Name = "lb1";
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.dgv1);
            this.panel5.Controls.Add(this.categorySubTB);
            this.panel5.Controls.Add(this.categoryTB1);
            this.panel5.Controls.Add(this.headerTB1);
            this.panel5.Controls.Add(this.rtb1);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv1, "dgv1");
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 24;
            // 
            // categorySubTB
            // 
            this.categorySubTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.categorySubTB, "categorySubTB");
            this.categorySubTB.Name = "categorySubTB";
            this.categorySubTB.ReadOnly = true;
            // 
            // categoryTB1
            // 
            this.categoryTB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.categoryTB1, "categoryTB1");
            this.categoryTB1.Name = "categoryTB1";
            this.categoryTB1.ReadOnly = true;
            // 
            // headerTB1
            // 
            this.headerTB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.headerTB1, "headerTB1");
            this.headerTB1.Name = "headerTB1";
            // 
            // rtb1
            // 
            this.rtb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb1.EnableAutoDragDrop = true;
            resources.ApplyResources(this.rtb1, "rtb1");
            this.rtb1.Name = "rtb1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rescue);
            this.groupBox1.Controls.Add(this.mailButton);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.delete);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rescue
            // 
            this.rescue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rescue.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rescue, "rescue");
            this.rescue.Image = global::Form1.Properties.Resources.recover;
            this.rescue.Name = "rescue";
            this.rescue.UseVisualStyleBackColor = true;
            this.rescue.Click += new System.EventHandler(this.rescue_Click);
            this.rescue.MouseHover += new System.EventHandler(this.rescue_MouseHover);
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTableBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void appButton_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }


        #region Note Create Operations

        /// <summary>
        /// Creates new note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void create_Click(object sender, EventArgs e)
        {
            NewNote form3 = new NewNote();
            form3.liste.Add(this.liste[0]);
            form3.ShowDialog();
            loadDropDownMenu();
        }

        private void yeniNotEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_Click(sender, e);
        }

        #endregion

        #region Lists categories dropdown menu

        /// <summary>
        /// Tıklanan alt kategoriye ait notları listbox'ta listeler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level > 1)
            {
                lb1.Items.Clear();
                isConnectionOpen();
                command = new SqlCommand("select NotesTable.NoteID, NotesTable.NoteHeader, NotesTable.Notes,MainCategory.MainCategoryName, Category.CategoryName, userTable.UserName from NotesTable inner join Category on NotesTable.CategoryID = Category.CategoryID   inner  join userTable on NotesTable.UserID = userTable.ID inner join MainCategory on MainCategory.MainCategoryID = Category.MainCategoryID where ID='" + liste[0].UserID + "' and CategoryName='" + e.Node.Text + "' and MainCategoryName='" + e.Node.Parent.Text + "' and NotesTable.isActive = 1", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lb1.Items.Add(reader["Notes"]);
                }
                topicLabel.Text = e.Node.Text + "(" + lb1.Items.Count.ToString() + " not)" ;
                connection.Close();
            }
        }

        #endregion

        #region Silme işlemleri 

        /// <summary>
        /// Deletes selected note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Notu silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (lb1.SelectedItem != null && dialogResult == DialogResult.OK)
            {
                if(note.isActive)
                {
                    isConnectionOpen();
                    command = new SqlCommand("update NotesTable set isActive=0 where NoteID=@id", connection);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id", note.NoteID);
                    command.ExecuteNonQuery();
                    connection.Close();
                    headerTB1.Clear();
                    categoryTB1.Clear();
                    rtb1.Clear();
                    listAllNotes(sender, e);
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Bu not zaten silinmiş.", "Uyarı");
                }
            }
            else if(lb1.SelectedItem != null)
            {
                MessageBox.Show("Herhangi bir not seçilmemiş.", "Uyarı");
            }

        }

        #endregion

        #region Hover(Mouse ile belirli nesnelerin üzerine gidince açıklama yazısı çıkma olayı)

        private void create_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Yeni not eklemek için tıklayın.", create);
        }

        private void update_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Seçili notu düzenlemek için tıklayın.", update);
        }

        private void delete_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Seçili notu silmek için tıklayın.", delete);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Seçili notu mail olarak gönderin.", mailButton);
        }

        #endregion

        #region Update Operations

        /// <summary>
        /// Edits selected note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedItem != null )
            {
                if (note.isActive)
                {
                    note.updateDate = DateTime.Now;
                    note.updatedBy = liste[0].UserName;
                    isConnectionOpen();
                    command = new SqlCommand("update NotesTable set NoteHeader='" + headerTB1.Text + "', Notes='" + rtb1.Text + "', updateDate='" + note.updateDate.ToString() + "',updatedBy='" + liste[0].UserName + "' where NoteID=@id and NotesTable.isActive=1 ", connection);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id", note.NoteID);
                    command.ExecuteNonQuery();
                    connection.Close();
                    listAllNotes(sender, e);
                }
                else
                {
                    MessageBox.Show("Silinmiş bir notu düzenleyemezsiniz.","Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Herhangi bir not seçilmemiş.", "Uyarı");
            }
        }

        #endregion

        #region Page/section Load

        /// <summary>
        /// All notes button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listAllNotes(object sender, EventArgs e)
        {
            rescue.Visible = false;
            lb1.Items.Clear();
            isConnectionOpen();
            command = new SqlCommand("select NotesTable.NoteID, NotesTable.NoteHeader, NotesTable.Notes,MainCategory.MainCategoryName, Category.CategoryName, userTable.UserName, NotesTable.isActive from NotesTable inner join Category on NotesTable.CategoryID = Category.CategoryID   inner  join userTable on NotesTable.UserID = userTable.ID inner join MainCategory on MainCategory.MainCategoryID = Category.MainCategoryID where ID='" + liste[0].UserID + "' and NotesTable.isActive=1", connection);
            command.CommandType = CommandType.Text;
            dataTable = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                lb1.Items.Add(dr["Notes"]);
            }
            topicLabel.Text = "Tüm Notlar(" + lb1.Items.Count.ToString() + " Not)";
            connection.Close();
        }

        /// <summary>
        /// Lists deleted notes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deletedNotes(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            isConnectionOpen();
            command = new SqlCommand("select * from NotesTable where UserID='" + liste[0].UserID + "' and isActive=0", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lb1.Items.Add(reader["Notes"]);
            }
            connection.Close();
            topicLabel.Text = "Silinmiş notlar(" + lb1.Items.Count.ToString() + " Not)";
            rescue.Visible = true;
        }

        /// <summary>
        /// Actions done when a new MailScreen form opens. List categories and main categories respectively also adds rows to datatable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            
            topicLabel.Text = "";
            lbl1.Text = "Hoşgeldiniz, " + liste[0].Name + " " + liste[0].Surname;
            loadDropDownMenu();
            listAllNotes(sender,e);
            dataTable2.Columns.Add("Adı");
            dataTable2.Columns.Add("Yolu");
            dataTable2.Columns.Add("Kaydet");
        }

        /// <summary>
        /// Displays data at richtextbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rtb1.Clear();
                isConnectionOpen();
                command = new SqlCommand("select NotesTable.NoteID, NotesTable.NoteHeader,Notes,MainCategory.MainCategoryName, NotesTable.CategoryID, Category.CategoryName, NotesTable.isActive, userTable.UserName from NotesTable inner join Category on Category.CategoryID = NotesTable.CategoryID inner join userTable on userTable.ID = NotesTable.UserID inner join MainCategory on Category.MainCategoryID = MainCategory.MainCategoryID where ID='" + liste[0].UserID + "'", connection);
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (lb1.SelectedItem.ToString() == reader["Notes"].ToString())
                    {
                        note.NoteID = (int)reader["NoteID"];
                        note.Notes = reader["Notes"].ToString();
                        note.UserID = liste[0].UserID;
                        note.CategoryID = (int)reader["CategoryID"];
                        note.isActive = (bool)reader["isActive"];
                        note.createDate = DateTime.Now;
                        note.createdBy = reader["UserName"].ToString();

                        headerTB1.Text = reader["NoteHeader"].ToString();
                        categoryTB1.Text = reader["MainCategoryName"].ToString();
                        categorySubTB.Text = reader["CategoryName"].ToString();
                        rtb1.Text += reader["Notes"];
                    }
                }
                connection.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Algılanamayan hata.", "Uyarı");
                connection.Close();
            }
        }

        /// <summary>
        /// Loads dropdown menu.
        /// </summary>
        private void loadDropDownMenu()
        {
            if (firstTime)
            {
                tree1.Nodes.Add(root);
                firstTime = false;
            }
            else {
                root.Nodes.Clear();
            }
            isConnectionOpen();
            command = new SqlCommand("select * from MainCategory where MainCategory.UserID='" + liste[0].UserID + "'", connection);
            dataTable = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            foreach (DataRow data in dataTable.Rows) //Insert main categories.
            {
                root.Nodes.Add(data["MainCategoryName"].ToString());
            }

            foreach (TreeNode node in root.Nodes) //Insert subcategories with respect to their main categories.
            {
                isConnectionOpen();
                command = new SqlCommand("select Category.CategoryName, userCategories.UserID, Category.MainCategoryID, MainCategory.MainCategoryName from Category inner join userCategories on Category.CategoryID = userCategories.CategoryID inner join MainCategory on Category.MainCategoryID = MainCategory.MainCategoryID where userCategories.UserID= '" + this.liste[0].UserID + "'", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["MainCategoryName"].ToString() == node.Text)
                    {
                        node.Nodes.Add(reader["CategoryName"].ToString());
                    }
                }
                connection.Close();
            }
        }
        #endregion

        #region Attachment upload operations.

        /// <summary>
        /// Add file button under datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if(lb1.SelectedItem != null)
            {
                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "Select file";
                fdlg.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                fdlg.Filter = string.Format("{0}{1}{2} ({3})|{3}", fdlg.Filter, "", "All Files", "*.*");
                // Code for image filter  
                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                foreach (ImageCodecInfo c in codecs)
                {
                    string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                    fdlg.Filter = string.Format("{0}{1}{2} ({3})|{3}", fdlg.Filter, "|", codecName, c.FilenameExtension);
                }
                // Code for files filter  
                fdlg.Filter = fdlg.Filter + "|CSV Files (*.csv)|*.csv";
                fdlg.Filter = fdlg.Filter + "|Excel Files (.xls ,.xlsx)|  *.xls ;*.xlsx";
                fdlg.Filter = fdlg.Filter + "|PDF Files (.pdf)|*.pdf";
                fdlg.Filter = fdlg.Filter + "|Text Files (*.txt)|*.txt";
                fdlg.Filter = fdlg.Filter + "|Word Files (.docx ,.doc)|*.docx;*.doc";
                fdlg.Filter = fdlg.Filter + "|XML Files (*.xml)|*.xml";

                fdlg.FilterIndex = 1;
                fdlg.RestoreDirectory = true;
                fdlg.Multiselect = true;
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in fdlg.FileNames)
                    {
                        if (file != string.Empty)
                        {
                            DataRow drRow = dataTable2.NewRow();
                            drRow["Adı"] = Path.GetFileNameWithoutExtension(file);
                            drRow["Yolu"] = file;
                            mailNote.attachments.Add(file);
                            drRow["Kaydet"] = strSavePath + RenameFile(file);
                            dataTable2.Rows.Add(drRow);
                        }
                    }
                }
                dgv1.DataSource = dataTable2;

                if (dataTable2.Rows.Count > 0)
                {
                    if (!Directory.Exists(strSavePath))
                    {
                        Directory.CreateDirectory(strSavePath);
                    }

                    for (int i = 0; i < dgv1.Rows.Count; i++)
                    {
                        try
                        {
                            string oldPath = dgv1.Rows[i].Cells["filePath"].Value.ToString();
                            string fileSavePath = dgv1.Rows[i].Cells["fileSavePath"].Value.ToString();
                            File.Copy(oldPath, fileSavePath, true);
                            
                        }
                        catch { }
                    }
                    dgv1.DataSource = dataTable2;
                }
            }
            else
            {
                MessageBox.Show("Lütfen dosya eklemek istediğiniz notu seçiniz.", "Uyarı");
            }
        }

        /// <summary>
        /// Renames file to save in different location.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public string RenameFile(string filePath)
        {
            string strExt = Path.GetExtension(filePath);
            string fileName = Guid.NewGuid().ToString("N") + strExt;
            return fileName;
        }

        #endregion

        #region Mail Sending Operations

        /// <summary>
        /// Clicking mail sending button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mailButton_Click(object sender, EventArgs e)
        {
            if (note.isActive)
            {
                if (lb1.SelectedItem != null)
                {
                    mailNote.noteRTB.Text = rtb1.Text;
                    insertData();
                    mailNote.infos.Add(info);
                    mailNote.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen mail olarak göndermek istediğiniz notu seçin.", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Silinmiş bir notu mail olarak gönderemezsiniz.","Uyarı");
            }
        }

        /// <summary>
        /// Gets the note properties like header, content etc. from text boxes in order to use it in MailNote form.
        /// </summary>
        public void insertData()
        {
            info[0] = headerTB1.Text;
            info[1] = DateTime.Now.ToString();
            info[2] = categoryTB1.Text;
            info[3] = categorySubTB.Text;
            info[4] = rtb1.Text;
        }

        #endregion


        /// <summary>
        /// Search notes contains words in searchbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if(searchBox.Text.Length != 0)
            {
                temp.Clear();
                foreach (string item in lb1.Items)
                {
                    if (item.Contains(searchBox.Text))
                    {
                        temp.Add(item);
                    }
                }

                lb1.Items.Clear();

                foreach (string item in temp)
                {
                    lb1.Items.Add(item);
                }
            }
            else if(topicLabel.Text.Contains("Silinmiş notlar"))
            {
                deletedNotes(sender, e);
            }
            else
            {
                listAllNotes(sender,e);
            }
        }


        /// <summary>
        /// User logout tool strip menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Oturumu Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                UserLogin userLogin = new UserLogin();
                userLogin.Show();
            }
        }

        /// <summary>
        /// Checks whether connection is open or closed.
        /// </summary>
        private void isConnectionOpen()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataTable2.Rows.Clear();
            dgv1.DataSource = dataTable2;
        }

        private void rescue_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Silinmiş bir notunuzu kurtarın.", rescue);
        }

        private void rescue_Click(object sender, EventArgs e)
        {
            isConnectionOpen();
            command = new SqlCommand("update NotesTable set isActive=1 where NoteID=@id",connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", note.NoteID);
            command.ExecuteNonQuery();
            connection.Close();
            deletedNotes(sender,e);
        }

        private void pbID_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.liste.Add(liste[0]);
            connection.Open();
            command = new SqlCommand("select * from userTable where ID='" + liste[0].UserID + "'", connection);
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                form8.nameSurname.Text = reader["Name"] + " " + reader["Surname"];
                form8.userName.Text = reader["userName"].ToString();
                form8.mail.Text = reader["Email"].ToString();
            }
            connection.Close();
            form8.ShowDialog();
        }
    } 
}
