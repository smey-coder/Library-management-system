using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class BorrowBook_List
    {
        string connection = "Data Source=DESKTOP-3MCTVIH;Persist Security Info=True;User ID=sa;Initial Catalog=Library management system;Password=hello";
        public int id { set; get; }
        public string BorrowID { set; get; }
        public string CustomerName{ set; get; }
        public string Contact { set; get; }
        public string Email { set; get; }
        public int BookId { set; get; }
        public string Author { set; get; }
        public string Status { set; get; }
        public string Image { set; get; }
        public string BorrowDate { set; get; }
        public string ReturnDate { set; get; } 
        public string InsertDate { set; get; }
        public string UpdateDate { set; get; }
        public string DeleteDate { set; get; } 
        
        public List<BorrowBook_List> borrowListData()
        {
            List<BorrowBook_List> borrowList = new List<BorrowBook_List>();
            using(SqlConnection connect= new SqlConnection(connection))
            {
                connect.Open();
                string query = "SELECT * FROM Borrows";

                using(SqlCommand cmd = new SqlCommand(query, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        BorrowBook_List borrow = new BorrowBook_List();

                        borrow.id = (int)reader["id"];
                        borrow.BorrowID = reader["borrow_id"].ToString();
                        borrow.CustomerName = reader["customer_name"].ToString();
                        borrow.Contact = reader["contact"].ToString();
                        borrow.Email = reader["email"].ToString();
                        borrow.BookId = (int)reader["book_id"];
                        borrow.Author = reader["author"].ToString();
                        borrow.Status = reader["status"].ToString();
                        borrow.Image = reader["image"].ToString();
                        borrow.BorrowDate = reader["borrow_dated"] == DBNull.Value ? null : DateTime.TryParse(reader["borrow_dated"].ToString(), out var dateBorrow) ? dateBorrow.ToString("MM-dd-yyyy") : null;
                        borrow.ReturnDate = reader["return_dated"] == DBNull.Value ? null : DateTime.TryParse(reader["return_dated"].ToString(), out var dateReturn) ? dateReturn.ToString("MM-dd-yyyy") : null;
                        borrow.InsertDate = reader["date_inserted"] == DBNull.Value ? null : DateTime.TryParse(reader["date_inserted"].ToString(), out var dateInsert) ? dateInsert.ToString("MM-dd-yyyy") : null;
                        borrow.UpdateDate = reader["date_updated"] == DBNull.Value ? null : DateTime.TryParse(reader["date_updated"].ToString(), out var dateDelete) ? dateDelete.ToString("MM-dd-yyyy") : null;
                        borrow.DeleteDate = reader["date_deleted"] == DBNull.Value ? null : DateTime.TryParse(reader["date_deleted"].ToString(), out var dateUpdate) ? dateUpdate.ToString("MM-dd-yyyy") : null;
                        
                        borrowList.Add(borrow);
                    }
                }
            }
            return borrowList;
        }
    }
}
