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
            this.bt_Cate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Sear = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView_Livre = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Delete_Book = new System.Windows.Forms.Button();
            this.Edit_Book = new System.Windows.Forms.Button();
            this.Add_Book = new System.Windows.Forms.Button();
            this.cb_Cate = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Livre)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Cate);
            this.groupBox2.Controls.Add(this.bt_Cate);
            this.groupBox2.Location = new System.Drawing.Point(161, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 48);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category";
            // 
            // bt_Cate
            // 
            this.bt_Cate.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cate.Image")));
            this.bt_Cate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cate.Location = new System.Drawing.Point(271, 16);
            this.bt_Cate.Name = "bt_Cate";
            this.bt_Cate.Size = new System.Drawing.Size(89, 25);
            this.bt_Cate.TabIndex = 21;
            this.bt_Cate.Text = "Category";
            this.bt_Cate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Cate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Sear);
            this.groupBox1.Controls.Add(this.tb_Search);
            this.groupBox1.Location = new System.Drawing.Point(532, 27);
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
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(376, 23);
            this.tb_Search.TabIndex = 18;
            this.tb_Search.Click += new System.EventHandler(this.tb_Search_Click);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(257, 462);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 30);
            this.button7.TabIndex = 46;
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
            this.dataGridView_Livre.Location = new System.Drawing.Point(161, 80);
            this.dataGridView_Livre.Name = "dataGridView_Livre";
            this.dataGridView_Livre.ReadOnly = true;
            this.dataGridView_Livre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Livre.Size = new System.Drawing.Size(860, 362);
            this.dataGridView_Livre.TabIndex = 45;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(791, 462);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 30);
            this.button6.TabIndex = 44;
            this.button6.Text = "Cancel";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(685, 462);
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
            this.Delete_Book.Location = new System.Drawing.Point(577, 462);
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
            this.Edit_Book.Location = new System.Drawing.Point(469, 462);
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
            this.Add_Book.Location = new System.Drawing.Point(362, 462);
            this.Add_Book.Margin = new System.Windows.Forms.Padding(5);
            this.Add_Book.Name = "Add_Book";
            this.Add_Book.Size = new System.Drawing.Size(97, 30);
            this.Add_Book.TabIndex = 40;
            this.Add_Book.Text = "Add_Book";
            this.Add_Book.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_Book.UseVisualStyleBackColor = true;
            // 
            // cb_Cate
            // 
            this.cb_Cate.FormattingEnabled = true;
            this.cb_Cate.Location = new System.Drawing.Point(6, 19);
            this.cb_Cate.Name = "cb_Cate";
            this.cb_Cate.Size = new System.Drawing.Size(259, 21);
            this.cb_Cate.TabIndex = 22;
            // 
            // Books_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView_Livre);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Delete_Book);
            this.Controls.Add(this.Edit_Book);
            this.Controls.Add(this.Add_Book);
            this.Name = "Books_Control";
            this.Size = new System.Drawing.Size(1189, 525);
            this.Load += new System.EventHandler(this.Books_Control_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Livre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_Cate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Sear;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView_Livre;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Delete_Book;
        private System.Windows.Forms.Button Edit_Book;
        private System.Windows.Forms.Button Add_Book;
        private System.Windows.Forms.ComboBox cb_Cate;
    }
}
