using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Data.SqlClient;

namespace CustomList
{
    public partial class Form1 : Form
    {
        #region variables
        SqlConnection connection;
        private Table table;
        private string connectionLine;
        #endregion

        #region Constructor

        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            table = new Table();
            InitializeComponent();
            connectionLine = ConnectionVal();
        }
        #endregion


        #region entryBoxes
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        public string ConnectionVal()
        {
            return ConfigurationManager.ConnectionStrings["ListDatabase"].ConnectionString;
        }

        #region buttons
        /*private void AddCategory_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Entry VALUES (@Entry, null, 7, 'Hello', 2012-02-11)";
<<<<<<< HEAD
=======

>>>>>>> d5fd9b717afdbfebdb48ea738a2caa3145498eb8
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Entry", InsNameBox.Text);
                command.ExecuteScalar();
            }
<<<<<<< HEAD
            //ShowCategory();
            ShowEntries();
=======

            //ShowCategory();
            ShowEntries();

>>>>>>> d5fd9b717afdbfebdb48ea738a2caa3145498eb8
            
        }
        private void Add_Entry_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CategoryEntry VALUES (@CategoryId, @EntryId)";
<<<<<<< HEAD
=======

>>>>>>> d5fd9b717afdbfebdb48ea738a2caa3145498eb8
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@CategoryId", listCat.SelectedValue);
                command.Parameters.AddWithValue("@EntryId", listEntries.SelectedValue);
                command.ExecuteScalar();
            }
<<<<<<< HEAD
            ShowEntries();
=======

            ShowEntries();

>>>>>>> d5fd9b717afdbfebdb48ea738a2caa3145498eb8
        }
        private void AddEntry_Click(object sender, EventArgs e)
        {
            // missing an entry for images as well
            // table.Category(0) is a place holder. Instead of a 0 it will later
            // be the index of the actual category we want to query
            /*  InOutUtils.InsertBasicEntry(table.GetCategory(0),
                  EntryNameInput.Text, 
                  ScoreEntry.Text, 
                  descriptionEntry.Text);*/

<<<<<<< HEAD
        /*using(connection = new SqlConnection(connectionLine))
        using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Category",connectionLine))
        {

        }
    }*/
=======
            /*using(connection = new SqlConnection(connectionLine))
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Category",connectionLine))
            {
              
            }
        }*/
>>>>>>> d5fd9b717afdbfebdb48ea738a2caa3145498eb8

        // later here we will have buttons for removal and modification

        #endregion
        /*public void SetData(string name, string image, double score, string des, string date)
        {
            string query = "INSERT INTO Entry VALUES (@Entry, @image, @score, @des, @date)";
<<<<<<< HEAD
=======

>>>>>>> d5fd9b717afdbfebdb48ea738a2caa3145498eb8
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Entry", name);
                command.Parameters.AddWithValue("@image", image);
                command.Parameters.AddWithValue("@score", score);
                command.Parameters.AddWithValue("@des", des);
                command.Parameters.AddWithValue("@date", date);
                command.ExecuteScalar();
            }
<<<<<<< HEAD
=======

>>>>>>> d5fd9b717afdbfebdb48ea738a2caa3145498eb8
            //ShowCategory();
            ShowEntries();
        }
        public List<Entry> GetDataByCategory(string CategoryName)
        {
            int CatId;
            string query = "SELECT a.Id FROM Category a WHERE a.name =@catname";
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue(@"catname", CategoryName);
                CatId = Convert.ToInt32(command.ExecuteScalar());
            }
            return ShowCategoryEntries(CatId);
<<<<<<< HEAD
=======

>>>>>>> d5fd9b717afdbfebdb48ea738a2caa3145498eb8
        }
        private void ShowCategory()
        {
            using(connection = new SqlConnection(connectionLine))
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Category", connection))
            {
                DataTable catTable = new DataTable();
                adapter.Fill(catTable);
<<<<<<< HEAD
=======

>>>>>>> d5fd9b717afdbfebdb48ea738a2caa3145498eb8
                listCat.DisplayMember = "name";
                listCat.ValueMember = "Id";
                listCat.DataSource = catTable;
            }
        }
        private void ShowEntries()
        {
            using (connection = new SqlConnection(connectionLine))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Entry", connection))
            {
                DataTable entTable = new DataTable();
                adapter.Fill(entTable);
<<<<<<< HEAD
=======

>>>>>>> d5fd9b717afdbfebdb48ea738a2caa3145498eb8
                listEntries.DisplayMember = "name";
                listEntries.ValueMember = "Id";
                listEntries.DataSource = entTable;
            }
        }
        private List<Entry> ShowCategoryEntries(int Id)
        {
            List<Entry> data = new List<Entry>();
            string query = "SELECT a.name FROM Entry a INNER JOIN CategoryEntry b ON a.Id = b.EntryId " +
                "WHERE b.CategoryId = @CategoryId";
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@CategoryId", Id);
                DataTable catEntTable = new DataTable();
                adapter.Fill(catEntTable);
<<<<<<< HEAD
=======

>>>>>>> d5fd9b717afdbfebdb48ea738a2caa3145498eb8
                /*listCatEnt.DisplayMember = "name";
                listCatEnt.ValueMember = "Id";
                listCatEnt.DataSource = catEntTable;
                foreach(DataRow dr in catEntTable.Rows)
                {
                    Entry entry = new Entry(dr.ToString());
                    data.Add(entry);
                }
            }
            return data;
        }*/
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

          );

        private void Form1_Load(object sender, EventArgs e)
        {
            Region = new Region(new Rectangle(0, 0, Width, Height));
            /*ShowCategory();
            ShowEntries();
            ShowCategory();*/
            //ShowCategory();
            //ShowCategoryEntries();
        }

        private void b_Dashboard_Click(object sender, EventArgs e)
        {
            pn_Nav.Visible = true;
            pn_Nav.Width = b_Dashboard.Width;
            pn_Nav.Top = b_Dashboard.Top;
            pn_Nav.Left = b_Dashboard.Left;
            b_Dashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pn_Nav.Visible = true;
            pn_Nav.Width = button1.Width;
            pn_Nav.Top = button1.Top;
            pn_Nav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void b_TvSeries_Click(object sender, EventArgs e)
        {
            pn_Nav.Visible = true;
            pn_Nav.Width = b_TvSeries.Width;
            pn_Nav.Top = b_TvSeries.Top;
            pn_Nav.Left = b_TvSeries.Left;
            b_TvSeries.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pn_Nav.Visible = true;
            pn_Nav.Width = b_TvSeries.Width;
            pn_Nav.Top = button3.Top;
            pn_Nav.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void b_custom_Click(object sender, EventArgs e)
        {
            pn_Nav.Visible = true;
            pn_Nav.Width = b_custom.Width;
            pn_Nav.Top = b_custom.Top;
            pn_Nav.Left = b_custom.Left;
            b_custom.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void b_Dashboard_Leave(object sender, EventArgs e)
        {
            b_Dashboard.BackColor = Color.FromArgb(23, 30, 54);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(23, 30, 54);
        }

        private void b_TvSeries_Leave(object sender, EventArgs e)
        {
            b_TvSeries.BackColor = Color.FromArgb(23, 30, 54);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(23, 30, 54);
        }

        private void b_custom_Leave(object sender, EventArgs e)
        {
            b_custom.BackColor = Color.FromArgb(23, 30, 54);
        }

        /*private void listEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCategoryEntries();
        }*/
    }
}