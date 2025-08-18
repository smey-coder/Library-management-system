using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class ReturnBookForm : UserControl
    {
        public ReturnBookForm()
        {
            InitializeComponent();
            LoadBorrowedBooks();
        }
        private void clearTextField()
        {
            borrowId = 0;
            txt_return_borID.Clear();
            txt_return_name.Clear();
            txt_return_contact.Clear();
            txt_return_email.Clear();
            txt_return_bookTitle.Clear();
            txt_return_author.Clear();
            pictureBox_return_book.Image = null;
            dateTime_return_date.Value = DateTime.Now;
            txt_return_borID.Focus();
        }
        public void refreshDate()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => LoadBorrowedBooks()));
                return;
            }
            LoadBorrowedBooks();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadBorrowedBooks()
        {
            BorrowBook_List borrowBookList = new BorrowBook_List();
            List<BorrowBook_List> borrowedBooks = borrowBookList.borrowListData();
            dataGridView_return_book.DataSource = borrowedBooks
            .Where(b => b.Status != "Returned")
            .ToList();

        }
        private void dataGridView_return_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row
            {
                DataGridViewRow row = dataGridView_return_book.Rows[e.RowIndex];

                borrowId = Convert.ToInt32(row.Cells[0].Value);
                txt_return_borID.Text = row.Cells[1].Value?.ToString();
                txt_return_name.Text = row.Cells[2].Value?.ToString();
                txt_return_contact.Text = row.Cells[3].Value?.ToString();
                txt_return_email.Text = row.Cells[4].Value?.ToString();
                txt_return_bookTitle.Text = row.Cells[5].Value?.ToString();
                txt_return_author.Text = row.Cells[6].Value?.ToString();
                txt_returnStatus.Text = row.Cells[7].Value.ToString();

                string imagePath = row.Cells[8].Value.ToString();
                if (File.Exists(imagePath))
                    pictureBox_return_book.Image = Image.FromFile(imagePath);
                else
                    pictureBox_return_book.Image = null;

                if (row.Cells[9].Value != null && DateTime.TryParse(row.Cells[9].Value.ToString(), out DateTime borrowDate))
                {
                    dateTime_return_date.Value = borrowDate;
                }
                else
                {
                    dateTime_return_date.Value = DateTime.Now;
                }
            }

        }

        public int borrowId = 0;
        private void btnReturn_Click(object sender, EventArgs e)
        {
                if (borrowId == 0)
                {
                    MessageBox.Show("Please select a borrow to return.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Database database = new Database();
                string connection = database.GetConnection().ConnectionString;
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    if (connect.State == ConnectionState.Open)
                    {
                    
                        string query = "UPDATE Borrows SET status = @status, return_dated = @dateReturn, date_deleted = @dateDeleted WHERE id = @borrowId";
                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                        DateTime today = DateTime.Now;
                            cmd.Parameters.AddWithValue("@borrowId", borrowId);
                            cmd.Parameters.AddWithValue("@status", "Returned");
                            cmd.Parameters.AddWithValue("@dateReturn", today);
                            cmd.Parameters.AddWithValue("@dateDeleted", today);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearTextField();
                                LoadBorrowedBooks();
                            }
                            else
                            {
                                MessageBox.Show("Failed to return the book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextField();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
