namespace x_prj_biblio
{
    partial class Books_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books_Control));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Cate = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Sear = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.DG_book = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.Delete_Book = new System.Windows.Forms.Button();
            this.Edit_Book = new System.Windows.Forms.Button();
            this.Add_Book = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_Uname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Cate);
            this.groupBox2.Location = new System.Drawing.Point(11, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 48);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category";
            // 
            // cb_Cate
            // 
            this.cb_Cate.FormattingEnabled = true;
            this.cb_Cate.Location = new System.Drawing.Point(6, 19);
            this.cb_Cate.Name = "cb_Cate";
            this.cb_Cate.Size = new System.Drawing.Size(313, 21);
            this.cb_Cate.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Sear);
            this.groupBox1.Controls.Add(this.tb_Search);
            this.groupBox1.Location = new System.Drawing.Point(342, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 48);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for  a Book";
            // 
            // bt_Sear
            // 
            this.bt_Sear.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sear.Image")));
            this.bt_Sear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Sear.Location = new System.Drawing.Point(388, 15);
            this.bt_Sear.Name = "bt_Sear";
            this.bt_Sear.Size = new System.Drawing.Size(95, 25);
            this.bt_Sear.TabIndex = 19;
            this.bt_Sear.Text = "Search";
            this.bt_Sear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Sear.UseVisualStyleBackColor = true;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(6, 17);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(376, 20);
            this.tb_Search.TabIndex = 18;
            this.tb_Search.Click += new System.EventHandler(this.tb_Search_Click);
            // 
            // DG_book
            // 
            this.DG_book.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DG_book.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_book.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_book.Location = new System.Drawing.Point(11, 134);
            this.DG_book.Name = "DG_book";
            this.DG_book.ReadOnly = true;
            this.DG_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_book.Size = new System.Drawing.Size(820, 302);
            this.DG_book.TabIndex = 45;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(342, 445);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 30);
            this.button4.TabIndex = 43;
            this.button4.Text = "Print Book";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Delete_Book
            // 
            this.Delete_Book.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Book.Image")));
            this.Delete_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_Book.Location = new System.Drawing.Point(234, 445);
            this.Delete_Book.Margin = new System.Windows.Forms.Padding(5);
            this.Delete_Book.Name = "Delete_Book";
            this.Delete_Book.Size = new System.Drawing.Size(98, 30);
            this.Delete_Book.TabIndex = 42;
            this.Delete_Book.Text = "Delete Book";
            this.Delete_Book.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Book.UseVisualStyleBackColor = true;
            // 
            // Edit_Book
            // 
            this.Edit_Book.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Book.Image")));
            this.Edit_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Book.Location = new System.Drawing.Point(126, 445);
            this.Edit_Book.Margin = new System.Windows.Forms.Padding(5);
            this.Edit_Book.Name = "Edit_Book";
            this.Edit_Book.Size = new System.Drawing.Size(98, 30);
            this.Edit_Book.TabIndex = 41;
            this.Edit_Book.Text = "Edit Book";
            this.Edit_Book.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit_Book.UseVisualStyleBackColor = true;
            // 
            // Add_Book
            // 
            this.Add_Book.Image = ((System.Drawing.Image)(resources.GetObject("Add_Book.Image")));
            this.Add_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Book.Location = new System.Drawing.Point(19, 445);
            this.Add_Book.Margin = new System.Windows.Forms.Padding(5);
            this.Add_Book.Name = "Add_Book";
            this.Add_Book.Size = new System.Drawing.Size(97, 30);
            this.Add_Book.TabIndex = 40;
            this.Add_Book.Text = "Add_Book";
            this.Add_Book.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_Book.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 445);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 30);
            this.button1.TabIndex = 53;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 445);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 30);
            this.button2.TabIndex = 52;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(678, 445);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 30);
            this.button3.TabIndex = 51;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(627, 445);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 30);
            this.button5.TabIndex = 50;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_Uname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 484);
            this.panel1.TabIndex = 55;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel21.Location = new System.Drawing.Point(28, 47);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(115, 10);
            this.panel21.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(24, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 20);
            this.label20.TabIndex = 56;
            this.label20.Text = "Books Info";
            // 
            // tb_Uname
            // 
            this.tb_Uname.Location = new System.Drawing.Point(28, 265);
            this.tb_Uname.Name = "tb_Uname";
            this.tb_Uname.Size = new System.Drawing.Size(160, 20);
            this.tb_Uname.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "Writer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Title";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 421);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Zon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 67;
            this.label4.Text = "Publish Date";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 369);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 68;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 317);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.DG_book);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.Delete_Book);
            this.panel2.Controls.Add(this.Edit_Book);
            this.panel2.Controls.Add(this.Add_Book);
            this.panel2.Location = new System.Drawing.Point(320, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 484);
            this.panel2.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(11, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 10);
            this.panel3.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Books List";
            // 
            // Books_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Books_Control";
            this.Size = new System.Drawing.Size(1189, 525);
            this.Load += new System.EventHandler(this.Books_Control_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Sear;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.DataGridView DG_book;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Delete_Book;
        private System.Windows.Forms.Button Edit_Book;
        private System.Windows.Forms.Button Add_Book;
        private System.Windows.Forms.ComboBox cb_Cate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Uname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
    }
}
