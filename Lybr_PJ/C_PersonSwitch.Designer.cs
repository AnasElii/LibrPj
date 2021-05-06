
namespace x_prj_biblio
{
    partial class C_PersonSwitch
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
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.pic_print = new System.Windows.Forms.PictureBox();
            this.pic_edit = new System.Windows.Forms.PictureBox();
            this.pic_delete = new System.Windows.Forms.PictureBox();
            this.pic_add = new System.Windows.Forms.PictureBox();
            this.c_Person1 = new x_prj_biblio.C_Person();
            this.c_PersonEdit1 = new x_prj_biblio.C_PersonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_back
            // 
            this.pic_back.Image = global::x_prj_biblio.Properties.Resources.icons8_back_arrow_200px;
            this.pic_back.Location = new System.Drawing.Point(1083, 23);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(50, 50);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_back.TabIndex = 6;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // pic_print
            // 
            this.pic_print.Image = global::x_prj_biblio.Properties.Resources.icons8_print_80px_1;
            this.pic_print.Location = new System.Drawing.Point(695, 466);
            this.pic_print.Name = "pic_print";
            this.pic_print.Size = new System.Drawing.Size(55, 45);
            this.pic_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_print.TabIndex = 3;
            this.pic_print.TabStop = false;
            this.pic_print.Click += new System.EventHandler(this.pic_print_Click);
            // 
            // pic_edit
            // 
            this.pic_edit.Image = global::x_prj_biblio.Properties.Resources.icons8_edit_property_96px;
            this.pic_edit.Location = new System.Drawing.Point(527, 466);
            this.pic_edit.Name = "pic_edit";
            this.pic_edit.Size = new System.Drawing.Size(55, 45);
            this.pic_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_edit.TabIndex = 4;
            this.pic_edit.TabStop = false;
            this.pic_edit.Click += new System.EventHandler(this.pic_edit_Click);
            // 
            // pic_delete
            // 
            this.pic_delete.Image = global::x_prj_biblio.Properties.Resources.icons8_close_window_96px_1;
            this.pic_delete.Location = new System.Drawing.Point(611, 466);
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Size = new System.Drawing.Size(55, 45);
            this.pic_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_delete.TabIndex = 5;
            this.pic_delete.TabStop = false;
            this.pic_delete.Click += new System.EventHandler(this.pic_delete_Click);
            // 
            // pic_add
            // 
            this.pic_add.Image = global::x_prj_biblio.Properties.Resources.icons8_add_96px;
            this.pic_add.Location = new System.Drawing.Point(439, 466);
            this.pic_add.Name = "pic_add";
            this.pic_add.Size = new System.Drawing.Size(55, 45);
            this.pic_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_add.TabIndex = 2;
            this.pic_add.TabStop = false;
            this.pic_add.Click += new System.EventHandler(this.pic_add_Click);
            // 
            // c_Person1
            // 
            this.c_Person1.Location = new System.Drawing.Point(0, 3);
            this.c_Person1.Name = "c_Person1";
            this.c_Person1.Size = new System.Drawing.Size(1189, 462);
            this.c_Person1.TabIndex = 8;
            // 
            // c_PersonEdit1
            // 
            this.c_PersonEdit1.Location = new System.Drawing.Point(3, 0);
            this.c_PersonEdit1.Name = "c_PersonEdit1";
            this.c_PersonEdit1.Size = new System.Drawing.Size(1189, 465);
            this.c_PersonEdit1.TabIndex = 7;
            // 
            // C_PersonSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_back);
            this.Controls.Add(this.pic_print);
            this.Controls.Add(this.pic_edit);
            this.Controls.Add(this.pic_delete);
            this.Controls.Add(this.pic_add);
            this.Controls.Add(this.c_Person1);
            this.Controls.Add(this.c_PersonEdit1);
            this.Name = "C_PersonSwitch";
            this.Size = new System.Drawing.Size(1189, 525);
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_add;
        private System.Windows.Forms.PictureBox pic_print;
        private System.Windows.Forms.PictureBox pic_edit;
        private System.Windows.Forms.PictureBox pic_delete;
        private System.Windows.Forms.PictureBox pic_back;
        private C_PersonEdit c_PersonEdit1;
        private C_Person c_Person1;
    }
}
