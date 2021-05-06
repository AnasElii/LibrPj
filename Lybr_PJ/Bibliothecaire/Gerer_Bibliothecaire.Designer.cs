namespace x_prj_biblio
{
    partial class Gerer_Bibliothecaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerer_Bibliothecaire));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            
            this.bibliothecaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.codeBiblDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomBiblDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomBiblDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseBiblDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneBiblDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motDePassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.bibliothecaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeBiblDataGridViewTextBoxColumn,
            this.nomBiblDataGridViewTextBoxColumn,
            this.prenomBiblDataGridViewTextBoxColumn,
            this.adresseBiblDataGridViewTextBoxColumn,
            this.telephoneBiblDataGridViewTextBoxColumn,
            this.utilisateurDataGridViewTextBoxColumn,
            this.motDePassDataGridViewTextBoxColumn,
            this.permissionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bibliothecaireBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(687, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ajouter Bibliothecaire";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);            
            // 
            // bibliothecaireBindingSource
            // 
            this.bibliothecaireBindingSource.DataMember = "Bibliothecaire";            
            // 
            // bibliothecaireTableAdapter
            //             
            // 
            // codeBiblDataGridViewTextBoxColumn
            // 
            this.codeBiblDataGridViewTextBoxColumn.DataPropertyName = "CodeBibl";
            this.codeBiblDataGridViewTextBoxColumn.HeaderText = "CodeBibl";
            this.codeBiblDataGridViewTextBoxColumn.Name = "codeBiblDataGridViewTextBoxColumn";
            this.codeBiblDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomBiblDataGridViewTextBoxColumn
            // 
            this.nomBiblDataGridViewTextBoxColumn.DataPropertyName = "NomBibl";
            this.nomBiblDataGridViewTextBoxColumn.HeaderText = "NomBibl";
            this.nomBiblDataGridViewTextBoxColumn.Name = "nomBiblDataGridViewTextBoxColumn";
            // 
            // prenomBiblDataGridViewTextBoxColumn
            // 
            this.prenomBiblDataGridViewTextBoxColumn.DataPropertyName = "PrenomBibl";
            this.prenomBiblDataGridViewTextBoxColumn.HeaderText = "PrenomBibl";
            this.prenomBiblDataGridViewTextBoxColumn.Name = "prenomBiblDataGridViewTextBoxColumn";
            // 
            // adresseBiblDataGridViewTextBoxColumn
            // 
            this.adresseBiblDataGridViewTextBoxColumn.DataPropertyName = "AdresseBibl";
            this.adresseBiblDataGridViewTextBoxColumn.HeaderText = "AdresseBibl";
            this.adresseBiblDataGridViewTextBoxColumn.Name = "adresseBiblDataGridViewTextBoxColumn";
            // 
            // telephoneBiblDataGridViewTextBoxColumn
            // 
            this.telephoneBiblDataGridViewTextBoxColumn.DataPropertyName = "TelephoneBibl";
            this.telephoneBiblDataGridViewTextBoxColumn.HeaderText = "TelephoneBibl";
            this.telephoneBiblDataGridViewTextBoxColumn.Name = "telephoneBiblDataGridViewTextBoxColumn";
            // 
            // utilisateurDataGridViewTextBoxColumn
            // 
            this.utilisateurDataGridViewTextBoxColumn.DataPropertyName = "Utilisateur";
            this.utilisateurDataGridViewTextBoxColumn.HeaderText = "Utilisateur";
            this.utilisateurDataGridViewTextBoxColumn.Name = "utilisateurDataGridViewTextBoxColumn";
            // 
            // motDePassDataGridViewTextBoxColumn
            // 
            this.motDePassDataGridViewTextBoxColumn.DataPropertyName = "MotDePass";
            this.motDePassDataGridViewTextBoxColumn.HeaderText = "MotDePass";
            this.motDePassDataGridViewTextBoxColumn.Name = "motDePassDataGridViewTextBoxColumn";
            // 
            // permissionDataGridViewTextBoxColumn
            // 
            this.permissionDataGridViewTextBoxColumn.DataPropertyName = "Permission";
            this.permissionDataGridViewTextBoxColumn.HeaderText = "Permission";
            this.permissionDataGridViewTextBoxColumn.Name = "permissionDataGridViewTextBoxColumn";
            // 
            // Gerer_Bibliothecaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gerer_Bibliothecaire";
            this.Text = "Gerer_Bibliothecaire";
            this.Load += new System.EventHandler(this.Gerer_Bibliothecaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();            
            ((System.ComponentModel.ISupportInitialize)(this.bibliothecaireBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;       
        private System.Windows.Forms.BindingSource bibliothecaireBindingSource;        
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBiblDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomBiblDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomBiblDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseBiblDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneBiblDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motDePassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn;
    }
}