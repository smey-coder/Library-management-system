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
using System.Web;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class AddBookForm : UserControl
    {

        private int bookId = 0;
       
        public AddBookForm()
        {
            InitializeComponent();
            displayBooks();

        }
       

        private void label5_Click(object sender, EventArgs e)
        {

        }
         public void refreshDate()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => displayBooks()));
                return;
            }
            displayBooks();
        }
        public void ClearTextBoxes()
        {
            txtBookTitle.Clear();
            txtAuthor.Clear();
            comboBox_Status.SelectedIndex = -1;
            dateTime_Book.Value = DateTime.Now;
            pictureBox_book.Image = null;
            txtBookTitle.Focus();
        }
        //Upload Image to Books_directory
        public string imageUpload()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string booksDirectory = Path.Combine(baseDirectory, "Books_directory");

            // Ensure Books_directory exists
            if (!Directory.Exists(booksDirectory))
            {
                Directory.CreateDirectory(booksDirectory);
            }

            // Validate PictureBox image
            if (string.IsNullOrEmpty(pictureBox_book.ImageLocation) || !File.Exists(pictureBox_book.ImageLocation))
            {
                MessageBox.Show("Invalid image selected. Please choose a valid image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Keep original file extension
            string extension = Path.GetExtension(pictureBox_book.ImageLocation);

            // Create a unique file name (fix caching issue)
            string imageName = txtBookTitle.Text.Trim() + "_" + DateTime.Now.Ticks + extension;
            string relativePath = Path.Combine("Books_directory", imageName);
            string fullPath = Path.Combine(baseDirectory, relativePath);

            try
            {
                // Copy file into memory and write new image
                byte[] imageBytes = File.ReadAllBytes(pictureBox_book.ImageLocation);
                File.WriteAllBytes(fullPath, imageBytes);

                // Force PictureBox to reload new image
                pictureBox_book.Image = null;
                pictureBox_book.Image = Image.FromFile(fullPath);

                return relativePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        private void btn_bookAdd_Click(object sender, EventArgs e)
        {
            string bookTitle = txtBookTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string status = comboBox_Status.Text.Trim();
            DateTime today = DateTime.Now;
           
            if (pictureBox_book.Image == null || bookTitle == "" || author == "" || dateTime_Book.Value == null || status == "")
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string imagePath = imageUpload();
            if (imagePath == null)
            {
                return; // Error already shown
            }
            Database database = new Database();
            string connection = database.GetConnection().ConnectionString;
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string query = "INSERT INTO Books (bookTitle, author, image, status, date_created) VALUES (@bookName, @author, @image, @status, @date_created)";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@bookName", bookTitle);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@image", imagePath);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("date_created", today);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Book {bookTitle} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayBooks();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           
        }
        public void displayBooks()
        {
            BookList bookList = new BookList();
            List<BookList> listData = bookList.GetAllBooks();

            dataGridView_add_book.DataSource = listData;
        }
       

        private void btn_bookImport_Click(object sender, EventArgs e)
        {
            String imagePath = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All Files (*.*)|*.*";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    pictureBox_book.ImageLocation = imagePath;
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_bookClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btn_bookDelete_Click(object sender, EventArgs e)
        {
            if(bookId == 0)
            {
                MessageBox.Show("Please select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                
                Database database = new Database();
                string connection = database.GetConnection().ConnectionString;
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string query = "DELETE FROM Books WHERE ID = @bookId";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Book {bookId} deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayBooks();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dataGridView_add_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_add_book.Rows[e.RowIndex];

                bookId = (int)row.Cells[0].Value;
                txtBookTitle.Text = row.Cells[1].Value.ToString();
                txtAuthor.Text = row.Cells[2].Value.ToString();
                string imagePath = row.Cells[3].Value.ToString();
                if (File.Exists(imagePath))
                    pictureBox_book.Image = Image.FromFile(imagePath);
                else
                    pictureBox_book.Image = null;
                comboBox_Status.Text = row.Cells[4].Value.ToString();
                dateTime_Book.Value = DateTime.Parse(row.Cells[5].Value.ToString());
            }
        }

        private void btn_bookUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Are you sure you want to update this ID: {bookId}?", "Cfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string bookTitle = txtBookTitle.Text.Trim();
                string author = txtAuthor.Text.Trim();
                string status = comboBox_Status.Text.Trim();
                DateTime today = DateTime.Now;
                if (pictureBox_book.Image == null || bookTitle == "" || author == "" || dateTime_Book.Value == null || status == "")
                {
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string imagePath = imageUpload();
                if (imagePath == null)
                {
                    return; // Error already shown
                }if(bookId == 0)
                {
                    MessageBox.Show("Please select a book to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Database database = new Database();
                    string connection = database.GetConnection().ConnectionString;
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();
                        string query = "UPDATE Books SET bookTitle = @bookName, author = @author, image = @image, status = @status, date_updated = @date_updated WHERE ID = @bookId";
                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookName", bookTitle);
                            cmd.Parameters.AddWithValue("@author", author);
                            cmd.Parameters.AddWithValue("@image", imagePath);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@date_updated", today);
                            cmd.Parameters.AddWithValue("@bookId", bookId);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayBooks();
                                ClearTextBoxes();
                                bookId = 0; // Reset bookId after update
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

        private void btn_addBook_refresh_Click(object sender, EventArgs e)
        {
            displayBooks();
        }

        private void txtSearchbyName_TextChanged(object sender, EventArgs e)
        {
            string searchTeat = txtSearchbyName.Text.Trim();
            Database database = new Database();
            string connection = database.GetConnection().ConnectionString;
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string query = "SELECT * FROM Books WHERE bookTitle LIKE @searchText OR author LIKE @searchText";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchTeat + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_add_book.DataSource = dt;
                }
            }

        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
