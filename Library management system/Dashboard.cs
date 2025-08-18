using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void label_avalibleBook_Click(object sender, EventArgs e)
        {

        }
        private void LoadDashboardData()
        {
            try
            {
                Database database = new Database();
                string connection = database.GetConnection().ConnectionString;
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    // Available Books
                    label_avalibleBook.Text = GetScalarValue(conn, "SELECT COUNT(id) FROM Books WHERE status = 'Available'").ToString();

                    // Borrowed Books
                    label_borrorwBook.Text = GetScalarValue(conn, "SELECT COUNT(id) FROM Borrows WHERE  status = 'Not Return'").ToString();

                    label_returnBook.Text = GetScalarValue(conn, "SELECT COUNT(id) FROM Borrows WHERE status = 'Returned'").ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }

        private object GetScalarValue(SqlConnection conn, string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return cmd.ExecuteScalar();
            }
        }
    }
}
