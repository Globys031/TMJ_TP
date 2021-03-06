﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace CustomList
{
    public static class DatabaseClass
    {
        public static string ConnectionVal()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            char[] toTrim = { 'b', 'i', 'n', '\\', '\\', 'D', 'e', 'b', 'u', 'g', '\\', '\\' };
            path = path.TrimEnd(toTrim);
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            return ConfigurationManager.ConnectionStrings["ListDatabase"].ConnectionString;
        }
        public static string connectionLine = ConnectionVal();
        static SqlConnection connection;

        #region buttons

        #endregion
        public static void SetData(string Category, string name, int score, string des, string date, byte[] image = null)
        {
            int CatId = FindCategoryId(Category);
            string query = "IF NOT EXISTS (SELECT * FROM Entry a INNER JOIN CategoryEntry b ON a.Id = b.EntryId " +
                "WHERE b.CategoryId = " + CatId + " AND a.name = @name) BEGIN" +
                " INSERT INTO Entry (name, image, score, description, date_of_entry)" +
                " VALUES (@name, @image, @score, @description, @date_of_entry); SELECT SCOPE_IDENTITY() END";
            int newID;
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@name", name);
                if(image == null)
                    command.Parameters.AddWithValue("@image", new byte[0]);
                else
                    command.Parameters.AddWithValue("@image", image);
                command.Parameters.AddWithValue("@score", score);
                command.Parameters.AddWithValue("@description", des);
                command.Parameters.AddWithValue("@date_of_entry", date);
                newID = Convert.ToInt32(command.ExecuteScalar());
            }
            if(newID != 0)
                ConnectEntryAndCategory(Category, newID);
        }
        public static int FindCategoryId(string Category)
        {
            int CatId = 0;
            string query = "SELECT a.Id FROM Category a WHERE a.name =@catname";
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue(@"catname", Category);
                if (command != null)
                    CatId = Convert.ToInt32(command.ExecuteScalar());
            }

            return CatId;
        }
        private static void ConnectEntryAndCategory(string Category, int entryId)
        {
            int CatId = FindCategoryId(Category);
            if(CatId == 0)
            {
                CatId = SetCategory(Category);
                InsertCatEnt(CatId, entryId);
            }
            else InsertCatEnt(CatId, entryId);
        }
        public static int SetCategory(string Category)
        {
            string query = "INSERT INTO Category (name) VALUES (@name); SELECT SCOPE_IDENTITY()";
            using(connection = new SqlConnection(connectionLine))
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue(@"name", Category);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        private static void InsertCatEnt(int CatId, int entryId)
        {
            string query = "INSERT INTO CategoryEntry (CategoryId, EntryId) VALUES (@CategoryId, @EntryId)";
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue(@"CategoryId", CatId);
                command.Parameters.AddWithValue(@"EntryId", entryId);
                command.ExecuteScalar();
            }
        }
        public static List<Entry> GetDataByCategory(string CategoryName, string sortQuery)
        {
            int CatId = FindCategoryId(CategoryName);
            if (CatId != 0)
                return ShowCategoryEntries(CatId, sortQuery);
            else return null;
          
        }
        private static List<Entry> ShowCategoryEntries(int Id, string sortquery)
        {
            List<Entry> data = new List<Entry>();
            string query = "SELECT * FROM Entry a INNER JOIN CategoryEntry b ON a.Id = b.EntryId " +
                "WHERE b.CategoryId = @CategoryId" + sortquery;
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@CategoryId", Id);
                DataTable catEntTable = new DataTable();
                adapter.Fill(catEntTable);
                foreach (DataRow dr in catEntTable.Rows)
                {
                    string name = dr[1].ToString();
                    byte[] image = null;
                    if (!(dr[2] is DBNull))// is not
                        image = (byte[])dr[2];
                    int score = int.Parse(dr[3].ToString());
                    string des = dr[4].ToString();
                    string date = dr[5].ToString();
                    int count = int.Parse(dr[6].ToString());
                    Entry entry = new Entry(name, image, score, des, date, count);
                    data.Add(entry);
                }
            }
            return data;
        }
        public static void RemoveCategory(string Category)
        {
            string query = "DELETE FROM Category WHERE name = @name";
            using (connection = new SqlConnection(connectionLine))
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue(@"name", Category);
                command.ExecuteNonQuery();
            }
        }
        public static void RemoveEntry(string category, string entryName)
        {
            int CatId = FindCategoryId(category);
            string query = "DELETE e FROM Entry e " +
                "INNER JOIN CategoryEntry c ON c.CategoryId = @catId WHERE e.Id = c.EntryId AND e.name = @name";
            using(connection = new SqlConnection(connectionLine))
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue(@"name", entryName);
                command.Parameters.AddWithValue(@"catId", CatId);
                command.ExecuteNonQuery();
            }
        }
        public static List<Entry> SortEntries(string Category, int entryIndex, bool ascending)
        {
            string query;
            if (ascending)
                query = " ORDER BY " + entryIndex + ";";
            else query = " ORDER BY " + entryIndex + " DESC;";
            return GetDataByCategory(Category, query);
        }

        /// <summary>
        /// Returns every entry that has the speicfied string in its name.
        /// If name = "abc" then it'll return antries with the name of
        /// "abc", "abcdef", "defabcfg" and so on
        /// </summary>
        /// <param name="Id">Category ID</param>
        /// <param name="name">The name of the entry to find</param>
        /// <returns></returns>
        public static List<Entry> GetCategoryEntry(int Id, string entryName)
        {
            string query = "SELECT Entry.* " +
                "FROM Entry " +
                "INNER JOIN CategoryEntry " +
                "ON Entry.Id = CategoryEntry.EntryId " +
                "WHERE Entry.name " +
                "LIKE '%" + entryName + "%' " +
                "AND CategoryEntry.CategoryId = " + Id;
            List<Entry> data = new List<Entry>();
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@entryName", entryName);
                command.Parameters.AddWithValue("@categoryId", Id);
                DataTable catEntTable = new DataTable();
                adapter.Fill(catEntTable);
                foreach (DataRow dr in catEntTable.Rows)
                {
                    string name = dr[1].ToString();
                    byte[] image = null;
                    if (!(dr[2] is DBNull))// is not
                        image = (byte[])dr[2];
                    int score = int.Parse(dr[3].ToString());
                    string des = dr[4].ToString();
                    string date = dr[5].ToString();
                    int count = int.Parse(dr[6].ToString());
                    Entry entry = new Entry(name, image, score, des, date, count);
                    data.Add(entry);
                }
            }
            return data;
        }
        public static List<string> GetCategoriesList()
        {
            List<string> catList = new List<string>();
            string query = "SELECT Category.name FROM Category";
            using(connection = new SqlConnection(connectionLine))
            using(SqlCommand command = new SqlCommand(query, connection))
            using(SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                DataTable catTable = new DataTable();
                adapter.Fill(catTable);
                foreach (DataRow dr in catTable.Rows)
                {
                    string name = dr[0].ToString();
                    catList.Add(name);
                }
            }
            return catList;
        }
        public static void UpdateEntries(string category, string oldName, string newName, int newScore, string newDes, string newDate, int count, byte[] newImage = null)
        {
            int CatID = FindCategoryId(category);
            string query = "UPDATE Entry " +
                "SET name = @name, image = @image, score = @score, description = @des, date_of_entry = @date, watch_count = @count " +
                "FROM Entry INNER JOIN CategoryEntry ON CategoryEntry.CategoryId = @catID AND CategoryEntry.EntryId = Entry.Id " +
                "WHERE Entry.name = @nameSearch";
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@catID", CatID);
                command.Parameters.AddWithValue("@nameSearch", oldName);
                command.Parameters.AddWithValue("@name", newName);
                if (newImage == null)
                    command.Parameters.AddWithValue("@image", new byte[0]);
                else command.Parameters.AddWithValue("@image", newImage);
                command.Parameters.AddWithValue("@score", newScore);
                command.Parameters.AddWithValue("@des", newDes);
                command.Parameters.AddWithValue("@date", newDate);
                command.Parameters.AddWithValue("@count", count);
                command.ExecuteScalar();
            }
        }
        public static void RemoveAllEntries()
        {
            string query = "DELETE FROM Entry";
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteScalar();
            }
        }
        public static void RemoveNonMandatoryCategories()
        {
            string query = "DELETE FROM Category " +
                "WHERE Category.name != @name1 AND Category.name != @name2 AND Category.name != @name3";
            using (connection = new SqlConnection(connectionLine))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@name1", "Movies");
                command.Parameters.AddWithValue("@name2", "TV_Series");
                command.Parameters.AddWithValue("@name3", "Anime");
                command.ExecuteScalar();
            }
        }
    }
}
