namespace x_prj_biblio
{
    partial class Manage_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Books));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView_Livre = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Delete_Book = new System.Windows.Forms.Button();
            this.Edit_Book = new System.Windows.Forms.Button();
            this.Add_Book = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Livre)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(13, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(568, 59);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category";
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(441, 21);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 31);
            this.button5.TabIndex = 21;
            this.button5.Text = "Category";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 21);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(399, 30);
            this.textBox2.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(589, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(571, 59);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Research";
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(436, 21);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(127, 31);
            this.button8.TabIndex = 19;
            this.button8.Text = "Research";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 30);
            this.textBox1.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(100, 513);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 37);
            this.button7.TabIndex = 37;
            this.button7.Text = "Refresh";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Livre
            // 
            this.dataGridView_Livre.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView_Livre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Livre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Livre.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Livre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Livre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Livre.Location = new System.Drawing.Point(13, 94);
            this.dataGridView_Livre.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Livre.Name = "dataGridView_Livre";
            this.dataGridView_Livre.ReadOnly = true;
            this.dataGridView_Livre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Livre.Size = new System.Drawing.Size(1147, 391);
            this.dataGridView_Livre.TabIndex = 36;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(906, 513);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 37);
            this.button6.TabIndex = 35;
            this.button6.Text = "Cancel";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(733, 513);
            this.button4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 37);
            this.button4.TabIndex = 34;
            this.button4.Text = "Print Book";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Delete_Book
            // 
            this.Delete_Book.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Book.Image")));
            this.Delete_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_Book.Location = new System.Drawing.Point(557, 513);
            this.Delete_Book.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Delete_Book.Name = "Delete_Book";
            this.Delete_Book.Size = new System.Drawing.Size(144, 37);
            this.Delete_Book.TabIndex = 33;
            this.Delete_Book.Text = "Delete Book";
            this.Delete_Book.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Book.UseVisualStyleBackColor = true;
            this.Delete_Book.Click += new System.EventHandler(this.Delete_Book_Click);
            // 
            // Edit_Book
            // 
            this.Edit_Book.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Book.Image")));
            this.Edit_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Book.Location = new System.Drawing.Point(398, 513);
            this.Edit_Book.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Edit_Book.Name = "Edit_Book";
            this.Edit_Book.Size = new System.Drawing.Size(131, 37);
            this.Edit_Book.TabIndex = 32;
            this.Edit_Book.Text = "Edit Book";
            this.Edit_Book.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit_Book.UseVisualStyleBackColor = true;
            this.Edit_Book.Click += new System.EventHandler(this.Edit_Book_Click);
            // 
            // Add_Book
            // 
            this.Add_Book.Image = ((System.Drawing.Image)(resources.GetObject("Add_Book.Image")));
            this.Add_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Book.Location = new System.Drawing.Point(238, 513);
            this.Add_Book.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Add_Book.Name = "Add_Book";
            this.Add_Book.Size = new System.Drawing.Size(129, 37);
            this.Add_Book.TabIndex = 31;
            this.Add_Book.Text = "Add_Book";
            this.Add_Book.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_Book.UseVisualStyleBackColor = true;
            this.Add_Book.Click += new System.EventHandler(this.Add_Book_Click);
            // 
            // Manage_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 578);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView_Livre);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Delete_Book);
            this.Controls.Add(this.Edit_Book);
            this.Controls.Add(this.Add_Book);
            this.Name = "Manage_Books";
            this.Text = "Manage_Books";
            this.Load += new System.EventHandler(this.Manage_Books_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Livre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView_Livre;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Delete_Book;
        private System.Windows.Forms.Button Edit_Book;
        private System.Windows.Forms.Button Add_Book;
    }
}