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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void timer_run_Tick(object sender, EventArgs e)
        {
            run_panel.Width += 6;

            if(run_panel.Width >= 753)
            {
                timer_run.Stop();
                LoginForm openForm = new LoginForm();
                openForm.Show();
                this.Hide();
                     
            }
        }
    }
}
