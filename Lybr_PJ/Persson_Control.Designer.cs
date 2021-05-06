
namespace x_prj_biblio
{
    partial class Persson_Control
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Persson_Control));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this._BPDelete = new System.Windows.Forms.Button();
            this.T_nom_persson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(673, 474);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 30);
            this.button4.TabIndex = 50;
            this.button4.Text = "Print Person";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // _BPDelete
            // 
            this._BPDelete.Image = ((System.Drawing.Image)(resources.GetObject("_BPDelete.Image")));
            this._BPDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BPDelete.Location = new System.Drawing.Point(533, 474);
            this._BPDelete.Margin = new System.Windows.Forms.Padding(5);
            this._BPDelete.Name = "_BPDelete";
            this._BPDelete.Size = new System.Drawing.Size(114, 30);
            this._BPDelete.TabIndex = 49;
            this._BPDelete.Text = "Delete Person";
            this._BPDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BPDelete.UseVisualStyleBackColor = true;
            // 
            // T_nom_persson
            // 
            this.T_nom_persson.Location = new System.Drawing.Point(676, 45);
            this.T_nom_persson.Name = "T_nom_persson";
            this.T_nom_persson.Size = new System.Drawing.Size(304, 20);
            this.T_nom_persson.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nom de Person";
            // 
            // Persson_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_nom_persson);
            this.Controls.Add(this.button4);
            this.Controls.Add(this._BPDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Persson_Control";
            this.Size = new System.Drawing.Size(1079, 525);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button _BPDelete;
        private System.Windows.Forms.TextBox T_nom_persson;
        private System.Windows.Forms.Label label1;
    }
}
