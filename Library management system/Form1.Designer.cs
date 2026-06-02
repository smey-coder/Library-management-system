namespace Library_management_system
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.run_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_run = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library management system";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-3, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 29);
            this.panel1.TabIndex = 1;
            // 
            // run_panel
            // 
            this.run_panel.BackColor = System.Drawing.Color.White;
            this.run_panel.Location = new System.Drawing.Point(0, 421);
            this.run_panel.Name = "run_panel";
            this.run_panel.Size = new System.Drawing.Size(43, 29);
            this.run_panel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_management_system.Properties.Resources.icons8_library_100;
            this.pictureBox1.Location = new System.Drawing.Point(299, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer_run
            // 
            this.timer_run.Enabled = true;
            this.timer_run.Interval = 20;
            this.timer_run.Tick += new System.EventHandler(this.timer_run_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.run_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel run_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_run;
    }
}

