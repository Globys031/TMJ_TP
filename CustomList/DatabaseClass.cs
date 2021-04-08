using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomList
{
    public static class DatabaseClass
    {
        public static string ConnectionVal()
        {
            
            return ConfigurationManager.ConnectionStrings["ListDatabase"].ConnectionString;
        }
        public static string connectionLine = ConnectionVal();
        static SqlConnection connection;

        #region buttons

        #endregion
        public static void SetData(string name, string image, double score, string des, string date)
        {
            string query = "INSERT INTO Entry VALUES (@Entry, @image, @score, @des, @date)";

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

            //ShowCategory();
            //ShowEntries();
        }
        public static List<Entry> GetDataByCategory(string CategoryName)
        {
            int CatId;
            string query = "SELECT a.Id FROM Category a WHERE a.name =@catname";
            using (connection = new SqlConnection(ConnectionVal()))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue(@"catname", CategoryName);
                CatId = Convert.ToInt32(command.ExecuteScalar());
            }
            return ShowCategoryEntries(CatId);

        }
        private static List<Entry> ShowCategoryEntries(int Id)
        {
            List<Entry> data = new List<Entry>();
            string query = "SELECT * FROM Entry a INNER JOIN CategoryEntry b ON a.Id = b.EntryId " +
                "WHERE b.CategoryId = @CategoryId";
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@CategoryId", Id);
                DataTable catEntTable = new DataTable();
                adapter.Fill(catEntTable);

                /*listCatEnt.DisplayMember = "name";
                listCatEnt.ValueMember = "Id";
                listCatEnt.DataSource = catEntTable;*/
                foreach (DataRow dr in catEntTable.Rows)
                {

                    //Entry entry = new Entry(dr.ItemArray[0].ToString());
                    string name = dr[1].ToString();
                    string image = dr[2].ToString();
                    double score = double.Parse(dr[3].ToString());
                    string des = dr[4].ToString();
                    string date = dr[5].ToString();
                    Entry entry = new Entry(name, image, score, des, date);
                    data.Add(entry);
                }
            }
            return data;
        }
    }
}
