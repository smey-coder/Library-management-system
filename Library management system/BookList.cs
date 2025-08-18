using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class BookList 
    {
        string connection = "Data Source=DESKTOP-3MCTVIH;Persist Security Info=True;User ID=sa;Initial Catalog=Library management system;Password=hello";
        public int id { set; get; }
        public string bookTitle { set; get; }
        public string author { set; get; }
        public string image { set; get; }
        public string status { set; get; }
        public string date_inserted { set; get; }
        public string date_updated { set; get; }
       
        public List<BookList> GetAllBooks()
        {
            List<BookList> books = new List<BookList>();
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string query = "SELECT * FROM Books";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        BookList book = new BookList();
                        book.id = (int)reader["ID"];
                        book.author = reader["author"].ToString();
                        book.bookTitle = reader["bookTitle"].ToString();
                        book.image = reader["image"].ToString();
                        book.status = reader["status"].ToString();
                        book.date_inserted = reader["date_created"] == DBNull.Value ? null : DateTime.TryParse(reader["date_created"].ToString(), out var dateInsert) ? dateInsert.ToString("MM-dd-yyyy") : null;
                        book.date_updated = reader["date_updated"] == DBNull.Value ? null : DateTime.TryParse(reader["date_updated"].ToString(), out var dateUpdate) ? dateUpdate.ToString("MM-dd-yyyy") : null;
                        books.Add(book);
                    }
                }
            }
            return books;
        }

    }
}
