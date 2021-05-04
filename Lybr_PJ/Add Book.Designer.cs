namespace x_prj_biblio
{
    partial class Add_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Book));
            this.But_Ok = new System.Windows.Forms.Button();
            this.B_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.T6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.T5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.T4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.T3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // But_Ok
            // 
            this.But_Ok.Image = ((System.Drawing.Image)(resources.GetObject("But_Ok.Image")));
            this.But_Ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_Ok.Location = new System.Drawing.Point(253, 272);
            this.But_Ok.Name = "But_Ok";
            this.But_Ok.Size = new System.Drawing.Size(75, 30);
            this.But_Ok.TabIndex = 8;
            this.But_Ok.Text = "OK";
            this.But_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.But_Ok.UseVisualStyleBackColor = true;
            this.But_Ok.Click += new System.EventHandler(this.But_Ok_Click);
            // 
            // B_cancel
            // 
            this.B_cancel.Image = ((System.Drawing.Image)(resources.GetObject("B_cancel.Image")));
            this.B_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_cancel.Location = new System.Drawing.Point(370, 272);
            this.B_cancel.Name = "B_cancel";
            this.B_cancel.Size = new System.Drawing.Size(75, 30);
            this.B_cancel.TabIndex = 7;
            this.B_cancel.Text = "Cancel";
            this.B_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_cancel.UseVisualStyleBackColor = true;
            this.B_cancel.Click += new System.EventHandler(this.B_cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.T6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.T5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.T4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.T3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 255);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Writer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Book Category:";
            // 
            // T6
            // 
            this.T6.Location = new System.Drawing.Point(189, 166);
            this.T6.Name = "T6";
            this.T6.Size = new System.Drawing.Size(92, 20);
            this.T6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity of Book";
            // 
            // T5
            // 
            this.T5.Location = new System.Drawing.Point(189, 131);
            this.T5.Name = "T5";
            this.T5.Size = new System.Drawing.Size(211, 20);
            this.T5.TabIndex = 9;
            this.T5.TextChanged += new System.EventHandler(this.T_B_Number_page_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of pages:";
            // 
            // T4
            // 
            this.T4.Location = new System.Drawing.Point(189, 27);
            this.T4.Name = "T4";
            this.T4.Size = new System.Drawing.Size(211, 20);
            this.T4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Book Editor: ";
            // 
            // T3
            // 
            this.T3.Location = new System.Drawing.Point(189, 99);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(211, 20);
            this.T3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Title:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(189, 200);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 313);
            this.Controls.Add(this.But_Ok);
            this.Controls.Add(this.B_cancel);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_Book";
            this.Text = "Add_Book";
            this.Load += new System.EventHandler(this.Add_Book_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button But_Ok;
        private System.Windows.Forms.Button B_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox T6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox T5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox T4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox T3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}