using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class BorrorwBookForm : UserControl
    {
        string connection = "Data Source=DESKTOP-3MCTVIH;Persist Security Info=True;User ID=sa;Initial Catalog=Library management system;Password=hello";

        public int borrowId = 0;
        
        public BorrorwBookForm()
        {
            InitializeComponent();
            LoadBorrowedBooks();
            LoadBookName();
            txt_br_author.ReadOnly = true;
            comboBox_borrowStatus.Items.AddRange(new string[] { "Return", "Not Return" });

        }
        public void ClearFields()
        {
            txtBorrowID.Clear();
            txtCustomerName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            comboBox_br_BookTitle.SelectedIndex = -1;
            txt_br_author.Clear();
            pictureBox_borrow.Image = null;
            txtBorrowID.Focus();
            dateTime_borrow.Value = DateTime.Now;
            dateTime_borrow_return.Value = DateTime.Now;

            

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

        private void LoadBorrowedBooks()
        {
            BorrowBook_List borrowBookList = new BorrowBook_List();
            List<BorrowBook_List> borrowedBooks = borrowBookList.borrowListData();
            dataGridView_borrow_book.DataSource = borrowedBooks;
        }
        public void LoadBookName()
        {      
            using (SqlConnection connect = new SqlConnection(connection))
            {
                
                string query = "SELECT id, bookTitle, author, image FROM Books";
                SqlDataAdapter cDate = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                cDate.Fill(table);
                comboBox_br_BookTitle.DataSource = table;
                comboBox_br_BookTitle.DisplayMember = "bookTitle";
                comboBox_br_BookTitle.ValueMember = "id";
                txt_br_author.DataBindings.Add("Text", comboBox_br_BookTitle.DataSource, "author");
                pictureBox_borrow.DataBindings.Add("ImageLocation", comboBox_br_BookTitle.DataSource, "image");

            }
        }


        private void btn_borrowAdd_Click(object sender, EventArgs e)
        {
            string borrow_Id = txtBorrowID.Text.Trim();
            string customerName = txtCustomerName.Text.Trim();
            string contact = txtContact.Text.Trim();
            string email = txtEmail.Text.Trim();
            string bookId = comboBox_br_BookTitle.SelectedValue.ToString();
            string author = txt_br_author.Text.Trim();
            string status = comboBox_borrowStatus.Text.Trim();
            string image = pictureBox_borrow.ImageLocation;

            if(borrow_Id == "" || customerName == "" || contact == "" || email == "" || bookId == "" || author == "" || status == "" || image == null)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string query = "INSERT INTO Borrows (borrow_id, customer_name, contact, email, book_id, author, status, image, borrow_dated, return_dated, date_inserted) VALUES (@borrowId, @customerName, @contact, @email, @bookId, @author, @status, @image, @BorrowDate, @ReturnDate, @InsertDate)";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        DateTime borrowDate = dateTime_borrow.Value;
                        DateTime returnDate = dateTime_borrow_return.Value;
                        DateTime insertDate = DateTime.Now;
                        cmd.Parameters.AddWithValue("@borrowId", borrow_Id);
                        cmd.Parameters.AddWithValue("@customerName", customerName);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.Parameters.AddWithValue("@BorrowDate", borrowDate);
                        cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                        cmd.Parameters.AddWithValue("@InsertDate", insertDate);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Book by: {customerName} borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBorrowedBooks();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to borrow book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void btn_borrowUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to update this ID: {borrowId}?", "Cfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string borrow_Id = txtBorrowID.Text.Trim();
                string customerName = txtCustomerName.Text.Trim();
                string contact = txtContact.Text.Trim();
                string email = txtEmail.Text.Trim();
                string bookId = comboBox_br_BookTitle.SelectedValue.ToString();
                string author = txt_br_author.Text.Trim();
                string status = comboBox_borrowStatus.Text.Trim();
                string image = pictureBox_borrow.ImageLocation;

                if (borrow_Id == "" || customerName == "" || contact == "" || email == "" || bookId == "" || author == "" || status == "" || image == null)
                {
                    MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    Database database = new Database();
                    string connection = database.GetConnection().ConnectionString;
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();
                        string query = @"UPDATE Borrows 
                                                        SET borrow_id = @borrowID, 
                                                            customer_name = @customerName, 
                                                            contact = @contact, 
                                                            email = @email,  
                                                            book_id = @book_id, 
                                                            author = @author, 
                                                            status = @status, 
                                                            image = @image, 
                                                            borrow_dated = @borrowDate, 
                                                            return_dated = @returnDate, 
                                                            date_updated = @dateUpdated 
                                                        WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            DateTime borrowDate = dateTime_borrow.Value;
                            DateTime returnDate = dateTime_borrow_return.Value;
                            DateTime borrowUpdate = DateTime.Now;
                            cmd.Parameters.AddWithValue("@id", borrowId);
                            cmd.Parameters.AddWithValue("@borrowID", borrow_Id);
                            cmd.Parameters.AddWithValue("@customerName", customerName);
                            cmd.Parameters.AddWithValue("@contact", contact);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@book_id", bookId);
                            cmd.Parameters.AddWithValue("@author", author);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@image", image);
                            cmd.Parameters.AddWithValue("@borrowDate", borrowDate);
                            cmd.Parameters.AddWithValue("@returnDate", returnDate);
                            cmd.Parameters.AddWithValue("@dateUpdated", borrowUpdate);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Borrow updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadBorrowedBooks();
                                ClearFields();
                                borrowId = 0; // Reset bookId after update
                            }
                            else
                            {
                                MessageBox.Show("Failed to update book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                    }
                }

            }
        }
        
        private void dataGridView_borrow_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_borrow_book.Rows[e.RowIndex];

                borrowId = (int)row.Cells[0].Value;
                txtBorrowID.Text = row.Cells[1].Value.ToString();
                txtCustomerName.Text = row.Cells[2].Value.ToString();
                txtContact.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                comboBox_br_BookTitle.Text = row.Cells[5].Value.ToString();
                txt_br_author.Text = row.Cells[6].Value.ToString();

                comboBox_borrowStatus.Text = row.Cells[7].Value.ToString();
                string imagePath = row.Cells[8].Value.ToString();
                if (File.Exists(imagePath))
                    pictureBox_borrow.Image = Image.FromFile(imagePath);
                else
                    pictureBox_borrow.Image = null;

                // Safely parse and assign borrow date
                if (row.Cells[9].Value != null && DateTime.TryParse(row.Cells[9].Value.ToString(), out DateTime borrowDate))
                    dateTime_borrow.Value = borrowDate;
                else
                    dateTime_borrow.Value = DateTime.Now;

                // Safely parse and assign return date
                if (row.Cells[11].Value != null && DateTime.TryParse(row.Cells[10].Value.ToString(), out DateTime returnDate))
                    dateTime_borrow_return.Value = returnDate;
                else
                    dateTime_borrow_return.Value = DateTime.Now;
            }
        }

        private void btn_borrowClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btn_borrowDelete_Click(object sender, EventArgs e)
        {
            if (borrowId == 0)
            {
                MessageBox.Show("Please select a borrow to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                Database database = new Database();
                string connection = database.GetConnection().ConnectionString;
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string query = "DELETE FROM Borrows WHERE id = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@ID", borrowId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Borrow deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBorrowedBooks();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete borrow.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void comboBox_borrowStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_borrowBook_refresh_Click(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void txt_borrow_searchByBook_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_borrow_searchByBook.Text.Trim();

            // Prevent unnecessary queries for empty search
            if (string.IsNullOrEmpty(searchText))
            {
                dataGridView_borrow_book.DataSource = null; 
                return;
            }

            try
            {
                Database database = new Database();
                using (SqlConnection connect = database.GetConnection())
                {
                    connect.Open();

                    string query = @"
                SELECT 
                    Borrows.id, 
                    Borrows.borrow_id,  
                    Borrows.customer_name,
                    Borrows.contact,
                    Borrows.email,
                    Books.bookTitle,
                    Books.author, 
                    Borrows.status,  
                    Borrows.image,
                    Borrows.borrow_dated, 
                    Borrows.return_dated,
                    Borrows.date_inserted, 
                    Borrows.date_updated, 
                    Borrows.date_deleted
                FROM Borrows
                INNER JOIN Books ON Books.id = Borrows.book_id
                WHERE Books.bookTitle LIKE @searchText";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView_borrow_book.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
