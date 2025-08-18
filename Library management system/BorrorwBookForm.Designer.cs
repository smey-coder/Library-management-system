namespace Library_management_system
{
    partial class BorrorwBookForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_borrow_searchByBook = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_borrowBook_refresh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_borrow_book = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_br_author = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_borrowClear = new System.Windows.Forms.Button();
            this.btn_borrowDelete = new System.Windows.Forms.Button();
            this.btn_borrowUpdate = new System.Windows.Forms.Button();
            this.btn_borrowAdd = new System.Windows.Forms.Button();
            this.comboBox_borrowStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTime_borrow_return = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTime_borrow = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_br_BookTitle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBorrowID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_borrow = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_borrow_book)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_borrow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_borrow_searchByBook);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btn_borrowBook_refresh);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dataGridView_borrow_book);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 379);
            this.panel1.TabIndex = 0;
            // 
            // txt_borrow_searchByBook
            // 
            this.txt_borrow_searchByBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_borrow_searchByBook.Location = new System.Drawing.Point(495, 7);
            this.txt_borrow_searchByBook.Name = "txt_borrow_searchByBook";
            this.txt_borrow_searchByBook.Size = new System.Drawing.Size(283, 28);
            this.txt_borrow_searchByBook.TabIndex = 27;
            this.txt_borrow_searchByBook.TextChanged += new System.EventHandler(this.txt_borrow_searchByBook_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(296, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Search by book name:";
            // 
            // btn_borrowBook_refresh
            // 
            this.btn_borrowBook_refresh.BackColor = System.Drawing.Color.Blue;
            this.btn_borrowBook_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrowBook_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_borrowBook_refresh.Location = new System.Drawing.Point(1008, 3);
            this.btn_borrowBook_refresh.Name = "btn_borrowBook_refresh";
            this.btn_borrowBook_refresh.Size = new System.Drawing.Size(119, 36);
            this.btn_borrowBook_refresh.TabIndex = 25;
            this.btn_borrowBook_refresh.Text = "Refresh";
            this.btn_borrowBook_refresh.UseVisualStyleBackColor = false;
            this.btn_borrowBook_refresh.Click += new System.EventHandler(this.btn_borrowBook_refresh_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "All Borrow Books";
            // 
            // dataGridView_borrow_book
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_borrow_book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_borrow_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_borrow_book.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_borrow_book.EnableHeadersVisualStyles = false;
            this.dataGridView_borrow_book.Location = new System.Drawing.Point(3, 42);
            this.dataGridView_borrow_book.Name = "dataGridView_borrow_book";
            this.dataGridView_borrow_book.ReadOnly = true;
            this.dataGridView_borrow_book.RowHeadersWidth = 51;
            this.dataGridView_borrow_book.RowTemplate.Height = 24;
            this.dataGridView_borrow_book.Size = new System.Drawing.Size(1124, 325);
            this.dataGridView_borrow_book.TabIndex = 0;
            this.dataGridView_borrow_book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_borrow_book_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt_br_author);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btn_borrowClear);
            this.panel2.Controls.Add(this.btn_borrowDelete);
            this.panel2.Controls.Add(this.btn_borrowUpdate);
            this.panel2.Controls.Add(this.btn_borrowAdd);
            this.panel2.Controls.Add(this.pictureBox_borrow);
            this.panel2.Controls.Add(this.comboBox_borrowStatus);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dateTime_borrow_return);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dateTime_borrow);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox_br_BookTitle);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtContact);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBorrowID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 273);
            this.panel2.TabIndex = 1;
            // 
            // txt_br_author
            // 
            this.txt_br_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_br_author.Location = new System.Drawing.Point(501, 71);
            this.txt_br_author.Name = "txt_br_author";
            this.txt_br_author.Size = new System.Drawing.Size(224, 28);
            this.txt_br_author.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(923, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Image";
            // 
            // btn_borrowClear
            // 
            this.btn_borrowClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_borrowClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrowClear.ForeColor = System.Drawing.Color.White;
            this.btn_borrowClear.Location = new System.Drawing.Point(747, 218);
            this.btn_borrowClear.Name = "btn_borrowClear";
            this.btn_borrowClear.Size = new System.Drawing.Size(143, 46);
            this.btn_borrowClear.TabIndex = 22;
            this.btn_borrowClear.Text = "CLEAR";
            this.btn_borrowClear.UseVisualStyleBackColor = false;
            this.btn_borrowClear.Click += new System.EventHandler(this.btn_borrowClear_Click);
            // 
            // btn_borrowDelete
            // 
            this.btn_borrowDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_borrowDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrowDelete.ForeColor = System.Drawing.Color.White;
            this.btn_borrowDelete.Location = new System.Drawing.Point(559, 218);
            this.btn_borrowDelete.Name = "btn_borrowDelete";
            this.btn_borrowDelete.Size = new System.Drawing.Size(143, 46);
            this.btn_borrowDelete.TabIndex = 21;
            this.btn_borrowDelete.Text = "DELETE";
            this.btn_borrowDelete.UseVisualStyleBackColor = false;
            this.btn_borrowDelete.Click += new System.EventHandler(this.btn_borrowDelete_Click);
            // 
            // btn_borrowUpdate
            // 
            this.btn_borrowUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_borrowUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrowUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_borrowUpdate.Location = new System.Drawing.Point(356, 218);
            this.btn_borrowUpdate.Name = "btn_borrowUpdate";
            this.btn_borrowUpdate.Size = new System.Drawing.Size(143, 46);
            this.btn_borrowUpdate.TabIndex = 20;
            this.btn_borrowUpdate.Text = "UPDATE";
            this.btn_borrowUpdate.UseVisualStyleBackColor = false;
            this.btn_borrowUpdate.Click += new System.EventHandler(this.btn_borrowUpdate_Click);
            // 
            // btn_borrowAdd
            // 
            this.btn_borrowAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_borrowAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrowAdd.ForeColor = System.Drawing.Color.White;
            this.btn_borrowAdd.Location = new System.Drawing.Point(157, 218);
            this.btn_borrowAdd.Name = "btn_borrowAdd";
            this.btn_borrowAdd.Size = new System.Drawing.Size(143, 46);
            this.btn_borrowAdd.TabIndex = 19;
            this.btn_borrowAdd.Text = "ADD";
            this.btn_borrowAdd.UseVisualStyleBackColor = false;
            this.btn_borrowAdd.Click += new System.EventHandler(this.btn_borrowAdd_Click);
            // 
            // comboBox_borrowStatus
            // 
            this.comboBox_borrowStatus.FormattingEnabled = true;
            this.comboBox_borrowStatus.Location = new System.Drawing.Point(883, 173);
            this.comboBox_borrowStatus.Name = "comboBox_borrowStatus";
            this.comboBox_borrowStatus.Size = new System.Drawing.Size(135, 24);
            this.comboBox_borrowStatus.TabIndex = 17;
            this.comboBox_borrowStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox_borrowStatus_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(799, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Status:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateTime_borrow_return
            // 
            this.dateTime_borrow_return.CustomFormat = "dd-MMM-yyyy";
            this.dateTime_borrow_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_borrow_return.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_borrow_return.Location = new System.Drawing.Point(501, 168);
            this.dateTime_borrow_return.Name = "dateTime_borrow_return";
            this.dateTime_borrow_return.Size = new System.Drawing.Size(224, 27);
            this.dateTime_borrow_return.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Return:";
            // 
            // dateTime_borrow
            // 
            this.dateTime_borrow.CustomFormat = "dd-MMM-yyyy";
            this.dateTime_borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_borrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_borrow.Location = new System.Drawing.Point(501, 117);
            this.dateTime_borrow.Name = "dateTime_borrow";
            this.dateTime_borrow.Size = new System.Drawing.Size(224, 27);
            this.dateTime_borrow.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Borrow:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Author:";
            // 
            // comboBox_br_BookTitle
            // 
            this.comboBox_br_BookTitle.FormattingEnabled = true;
            this.comboBox_br_BookTitle.Location = new System.Drawing.Point(501, 17);
            this.comboBox_br_BookTitle.Name = "comboBox_br_BookTitle";
            this.comboBox_br_BookTitle.Size = new System.Drawing.Size(224, 24);
            this.comboBox_br_BookTitle.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Book Title:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(164, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 28);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(164, 112);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(212, 28);
            this.txtContact.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact #:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(164, 63);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(212, 28);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtBorrowID
            // 
            this.txtBorrowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowID.Location = new System.Drawing.Point(164, 11);
            this.txtBorrowID.Name = "txtBorrowID";
            this.txtBorrowID.Size = new System.Drawing.Size(212, 28);
            this.txtBorrowID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrow ID:";
            // 
            // pictureBox_borrow
            // 
            this.pictureBox_borrow.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_borrow.Location = new System.Drawing.Point(883, 11);
            this.pictureBox_borrow.Name = "pictureBox_borrow";
            this.pictureBox_borrow.Size = new System.Drawing.Size(135, 122);
            this.pictureBox_borrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_borrow.TabIndex = 18;
            this.pictureBox_borrow.TabStop = false;
            // 
            // BorrorwBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BorrorwBookForm";
            this.Size = new System.Drawing.Size(1155, 685);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_borrow_book)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_borrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBorrowID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_br_BookTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_borrowClear;
        private System.Windows.Forms.Button btn_borrowDelete;
        private System.Windows.Forms.Button btn_borrowUpdate;
        private System.Windows.Forms.Button btn_borrowAdd;
        private System.Windows.Forms.PictureBox pictureBox_borrow;
        private System.Windows.Forms.ComboBox comboBox_borrowStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTime_borrow_return;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTime_borrow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView_borrow_book;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_br_author;
        private System.Windows.Forms.Button btn_borrowBook_refresh;
        private System.Windows.Forms.TextBox txt_borrow_searchByBook;
        private System.Windows.Forms.Label label12;
    }
}
