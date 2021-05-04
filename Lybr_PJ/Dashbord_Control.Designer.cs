namespace x_prj_biblio
{
    partial class Dashbord_Control
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
            this.DG_Autor = new System.Windows.Forms.DataGridView();
            this.DG_Book = new System.Windows.Forms.DataGridView();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.DG_Late = new System.Windows.Forms.DataGridView();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Autor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Late)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Autor
            // 
            this.DG_Autor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Autor.Location = new System.Drawing.Point(820, 73);
            this.DG_Autor.Name = "DG_Autor";
            this.DG_Autor.Size = new System.Drawing.Size(339, 295);
            this.DG_Autor.TabIndex = 31;
            // 
            // DG_Book
            // 
            this.DG_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Book.Location = new System.Drawing.Point(433, 73);
            this.DG_Book.Name = "DG_Book";
            this.DG_Book.Size = new System.Drawing.Size(339, 295);
            this.DG_Book.TabIndex = 30;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel21.Location = new System.Drawing.Point(433, 47);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(194, 10);
            this.panel21.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(429, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 20);
            this.label20.TabIndex = 28;
            this.label20.Text = "Books";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel19.Location = new System.Drawing.Point(31, 47);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(194, 10);
            this.panel19.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(27, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Late";
            // 
            // DG_Late
            // 
            this.DG_Late.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Late.Location = new System.Drawing.Point(31, 73);
            this.DG_Late.Name = "DG_Late";
            this.DG_Late.Size = new System.Drawing.Size(339, 295);
            this.DG_Late.TabIndex = 25;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel20.Location = new System.Drawing.Point(820, 47);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(194, 10);
            this.panel20.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(816, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "Autors";
            // 
            // Dashbord_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DG_Autor);
            this.Controls.Add(this.DG_Book);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DG_Late);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.label19);
            this.Name = "Dashbord_Control";
            this.Size = new System.Drawing.Size(1189, 525);
            this.Load += new System.EventHandler(this.Dashbord_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Autor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Late)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Autor;
        private System.Windows.Forms.DataGridView DG_Book;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DG_Late;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label19;
    }
}
