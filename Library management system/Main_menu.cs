using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Main menu";
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_menu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure you want to close this app?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDashboad_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addBookForm1.Visible = false;
            borrorwBookForm1.Visible = false;
            returnBookForm1.Visible = false;
            AddBookForm open = addBookForm1;
            BorrorwBookForm borrowOpen = borrorwBookForm1;
            ReturnBookForm returnOpen = returnBookForm1;
            if (open != null && borrowOpen != null && returnOpen != null)
            {
                open.refreshDate();
                borrowOpen.refreshDate();
                returnOpen.refreshDate();
            }
        }

        private void btnAddbook_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBookForm1.Visible = true;
            borrorwBookForm1.Visible = false;
            returnBookForm1.Visible = false;
            AddBookForm open = addBookForm1;
            if (open != null)
            {
                open.refreshDate();
            }
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBookForm1.Visible = false;
            returnBookForm1.Visible = false;
            borrorwBookForm1.Visible = true;
            BorrorwBookForm open = borrorwBookForm1;
            if(open != null)
            {
                open.refreshDate();
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBookForm1.Visible = false;
            returnBookForm1.Visible = true;
            borrorwBookForm1.Visible = false;
            ReturnBookForm open = returnBookForm1;
            if (open != null)
            {
                open.refreshDate();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm open = new LoginForm();
            open.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
