namespace Library_management_system
{
    partial class Main_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnAddbook = new System.Windows.Forms.Button();
            this.btnDashboad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Exit_menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.dashboard1 = new Library_management_system.Dashboard();
            this.addBookForm1 = new Library_management_system.AddBookForm();
            this.borrorwBookForm1 = new Library_management_system.BorrorwBookForm();
            this.returnBookForm1 = new Library_management_system.ReturnBookForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReturnBook);
            this.panel1.Controls.Add(this.btnBorrowBook);
            this.panel1.Controls.Add(this.btnAddbook);
            this.panel1.Controls.Add(this.btnDashboad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 730);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Image = global::Library_management_system.Properties.Resources.icons8_log_out_40;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(10, 640);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(171, 51);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReturnBook.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.Black;
            this.btnReturnBook.Image = global::Library_management_system.Properties.Resources.icons8_return_book_40;
            this.btnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.Location = new System.Drawing.Point(10, 447);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(171, 54);
            this.btnReturnBook.TabIndex = 7;
            this.btnReturnBook.Text = "Return Books";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBorrowBook.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnBorrowBook.FlatAppearance.BorderSize = 0;
            this.btnBorrowBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBorrowBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.ForeColor = System.Drawing.Color.Black;
            this.btnBorrowBook.Image = global::Library_management_system.Properties.Resources.icons8_borrow_book_40;
            this.btnBorrowBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowBook.Location = new System.Drawing.Point(10, 360);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(171, 53);
            this.btnBorrowBook.TabIndex = 6;
            this.btnBorrowBook.Text = "Borrow Books";
            this.btnBorrowBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnAddbook
            // 
            this.btnAddbook.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddbook.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAddbook.FlatAppearance.BorderSize = 0;
            this.btnAddbook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddbook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAddbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddbook.ForeColor = System.Drawing.Color.Black;
            this.btnAddbook.Image = global::Library_management_system.Properties.Resources.icons8_add_book_40;
            this.btnAddbook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddbook.Location = new System.Drawing.Point(10, 272);
            this.btnAddbook.Name = "btnAddbook";
            this.btnAddbook.Size = new System.Drawing.Size(171, 52);
            this.btnAddbook.TabIndex = 5;
            this.btnAddbook.Text = "Add Books";
            this.btnAddbook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddbook.UseVisualStyleBackColor = false;
            this.btnAddbook.Click += new System.EventHandler(this.btnAddbook_Click);
            // 
            // btnDashboad
            // 
            this.btnDashboad.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDashboad.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnDashboad.FlatAppearance.BorderSize = 0;
            this.btnDashboad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDashboad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDashboad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboad.ForeColor = System.Drawing.Color.Black;
            this.btnDashboad.Image = global::Library_management_system.Properties.Resources.icons8_dashboard_40;
            this.btnDashboad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboad.Location = new System.Drawing.Point(10, 187);
            this.btnDashboad.Name = "btnDashboad";
            this.btnDashboad.Size = new System.Drawing.Size(171, 51);
            this.btnDashboad.TabIndex = 4;
            this.btnDashboad.Text = "Dashboards";
            this.btnDashboad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboad.UseVisualStyleBackColor = false;
            this.btnDashboad.Click += new System.EventHandler(this.btnDashboad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_management_system.Properties.Resources.icons8_library_100__1_;
            this.pictureBox1.Location = new System.Drawing.Point(37, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(194, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(897, 48);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(197, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 51);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.btn_Exit_menu);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(191, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1155, 48);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_Exit_menu
            // 
            this.btn_Exit_menu.BackColor = System.Drawing.Color.Red;
            this.btn_Exit_menu.Location = new System.Drawing.Point(1068, 7);
            this.btn_Exit_menu.Name = "btn_Exit_menu";
            this.btn_Exit_menu.Size = new System.Drawing.Size(75, 32);
            this.btn_Exit_menu.TabIndex = 4;
            this.btn_Exit_menu.Text = "X";
            this.btn_Exit_menu.UseVisualStyleBackColor = false;
            this.btn_Exit_menu.Click += new System.EventHandler(this.btn_Exit_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Library Management System";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_main.Controls.Add(this.dashboard1);
            this.panel_main.Controls.Add(this.addBookForm1);
            this.panel_main.Controls.Add(this.borrorwBookForm1);
            this.panel_main.Controls.Add(this.returnBookForm1);
            this.panel_main.Location = new System.Drawing.Point(191, 45);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1155, 685);
            this.panel_main.TabIndex = 3;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1155, 685);
            this.dashboard1.TabIndex = 3;
            // 
            // addBookForm1
            // 
            this.addBookForm1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addBookForm1.Location = new System.Drawing.Point(0, 0);
            this.addBookForm1.Name = "addBookForm1";
            this.addBookForm1.Size = new System.Drawing.Size(1155, 685);
            this.addBookForm1.TabIndex = 2;
            // 
            // borrorwBookForm1
            // 
            this.borrorwBookForm1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.borrorwBookForm1.Location = new System.Drawing.Point(0, 0);
            this.borrorwBookForm1.Name = "borrorwBookForm1";
            this.borrorwBookForm1.Size = new System.Drawing.Size(1155, 685);
            this.borrorwBookForm1.TabIndex = 1;
            // 
            // returnBookForm1
            // 
            this.returnBookForm1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.returnBookForm1.Location = new System.Drawing.Point(0, -1);
            this.returnBookForm1.Name = "returnBookForm1";
            this.returnBookForm1.Size = new System.Drawing.Size(1155, 685);
            this.returnBookForm1.TabIndex = 0;
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1346, 730);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_menu";
            this.Text = "Main_menu";
            this.Load += new System.EventHandler(this.Main_menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDashboad;
        private System.Windows.Forms.Button btn_Exit_menu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnAddbook;
        private System.Windows.Forms.Panel panel_main;
        private Dashboard dashboard1;
        private AddBookForm addBookForm1;
        private BorrorwBookForm borrorwBookForm1;
        private ReturnBookForm returnBookForm1;
    }
}