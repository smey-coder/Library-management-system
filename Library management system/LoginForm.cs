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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            txtPassowrd.UseSystemPasswordChar = true;
            txtPassowrd.MaxLength = 20;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtUsername.Text) || String.IsNullOrWhiteSpace(txtPassowrd.Text))
            {
                MessageBox.Show("Please input value in the all textBox", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Database database = new Database();

                string connection = database.GetConnection().ConnectionString;

                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string query = "select * from Users where username = @usern and password = @pass";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassowrd.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Main_menu openForm = new Main_menu();
                            openForm.Show();
                            this.Hide();
                            
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }
        private void checkBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPass.Checked)
            {
                txtPassowrd.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassowrd.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure you want to close this app?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnsingUp_Click(object sender, EventArgs e)
        {
            SignUpForm singUpForm = new SignUpForm();
            singUpForm.Show();
            this.Hide();
        }
    }
}
