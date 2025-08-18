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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sign up Form";
            txt_Register_Pss.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Regi_showPass.Checked)
            {
                txt_Register_Pss.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Register_Pss.UseSystemPasswordChar = true;
            }

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Data
            string email = txt_Regi_EmailAddress.Text.Trim();
            string username = txt_Register_User.Text.Trim();
            string password = txt_Register_Pss.Text.Trim();

            if(email == "" || username == "" || password == "")
            {
                MessageBox.Show("Please input data in textfile!", "Wanring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Database database = new Database();
                string connection = database.GetConnection().ConnectionString;
                using (SqlConnection connectSelect = new SqlConnection(connection))
                {
                    // Check if the email already exists
                   
                    connectSelect.Open();
                    string checkEmailQuery = "SELECT COUNT(*) FROM Users WHERE email = @Email And username = @username";
                    using(SqlCommand cmd = new SqlCommand(checkEmailQuery, connectSelect))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@username", username);
                        int count = (int)cmd.ExecuteScalar();
                        if(count > 0)
                        {
                            MessageBox.Show("This email or username is already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            using (SqlConnection connectInsert = new SqlConnection(connection))
                            {
                                connectInsert.Open();
                                string rigesterQuery = "INSERT INTO Users (email, username, password, date_created) VALUES(@email, @user, @pass, @date)";
                                using (SqlCommand cmdInsert = new SqlCommand(rigesterQuery, connectInsert))
                                {
                                    cmdInsert.Parameters.AddWithValue("@email", email);
                                    cmdInsert.Parameters.AddWithValue("@user", username);
                                    cmdInsert.Parameters.AddWithValue("@pass", password);
                                    DateTime today = DateTime.Now;
                                    cmdInsert.Parameters.AddWithValue("date", today.ToString("dd-MMM-yyyy"));

                                    cmdInsert.ExecuteNonQuery();
                                    MessageBox.Show("Register successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clerTextBox();
                                }
                            }
                        }
                    }
                   
                }
                
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Regi_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure you want to close this app?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Clear textBox
        private void clerTextBox()
        {
            txt_Register_Pss.Clear();
            txt_Register_User.Clear();
            txt_Regi_EmailAddress.Clear();
            txt_Regi_EmailAddress.Focus();
        }
    }
}
