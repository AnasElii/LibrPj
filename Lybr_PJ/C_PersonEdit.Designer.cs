
namespace x_prj_biblio
{
    partial class C_PersonEdit
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
            this._Tpertype = new System.Windows.Forms.CheckBox();
            this._TDatebirth = new System.Windows.Forms.DateTimePicker();
            this._TDateRegister = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ds = new System.Windows.Forms.Label();
            this.dva = new System.Windows.Forms.Label();
            this.sda = new System.Windows.Forms.Label();
            this._TEmail = new System.Windows.Forms.TextBox();
            this._Tpass = new System.Windows.Forms.TextBox();
            this._TPhone = new System.Windows.Forms.TextBox();
            this._TLastName = new System.Windows.Forms.TextBox();
            this._TFirstName = new System.Windows.Forms.TextBox();
            this._TID = new System.Windows.Forms.TextBox();
            this._TPimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._TPimage)).BeginInit();
            this.SuspendLayout();
            // 
            // _Tpertype
            // 
            this._Tpertype.AutoSize = true;
            this._Tpertype.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Tpertype.Location = new System.Drawing.Point(527, 153);
            this._Tpertype.Name = "_Tpertype";
            this._Tpertype.Size = new System.Drawing.Size(82, 20);
            this._Tpertype.TabIndex = 22;
            this._Tpertype.Text = "Is Admin";
            this._Tpertype.UseVisualStyleBackColor = true;
            this._Tpertype.CheckedChanged += new System.EventHandler(this._Tpertype_CheckedChanged);
            // 
            // _TDatebirth
            // 
            this._TDatebirth.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TDatebirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._TDatebirth.Location = new System.Drawing.Point(283, 333);
            this._TDatebirth.Name = "_TDatebirth";
            this._TDatebirth.Size = new System.Drawing.Size(88, 24);
            this._TDatebirth.TabIndex = 21;
            // 
            // _TDateRegister
            // 
            this._TDateRegister.Enabled = false;
            this._TDateRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TDateRegister.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._TDateRegister.Location = new System.Drawing.Point(283, 280);
            this._TDateRegister.Name = "_TDateRegister";
            this._TDateRegister.Size = new System.Drawing.Size(88, 24);
            this._TDateRegister.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(524, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Email";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(524, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(524, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Register Date";
            // 
            // ds
            // 
            this.ds.AutoSize = true;
            this.ds.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds.Location = new System.Drawing.Point(169, 242);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(73, 16);
            this.ds.TabIndex = 14;
            this.ds.Text = "Last Name";
            // 
            // dva
            // 
            this.dva.AutoSize = true;
            this.dva.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dva.Location = new System.Drawing.Point(169, 202);
            this.dva.Name = "dva";
            this.dva.Size = new System.Drawing.Size(75, 16);
            this.dva.TabIndex = 13;
            this.dva.Text = "First Name";
            // 
            // sda
            // 
            this.sda.AutoSize = true;
            this.sda.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sda.Location = new System.Drawing.Point(169, 157);
            this.sda.Name = "sda";
            this.sda.Size = new System.Drawing.Size(22, 16);
            this.sda.TabIndex = 12;
            this.sda.Text = "ID";
            // 
            // _TEmail
            // 
            this._TEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TEmail.Location = new System.Drawing.Point(637, 280);
            this._TEmail.Name = "_TEmail";
            this._TEmail.Size = new System.Drawing.Size(132, 24);
            this._TEmail.TabIndex = 10;
            this._TEmail.Visible = false;
            // 
            // _Tpass
            // 
            this._Tpass.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Tpass.Location = new System.Drawing.Point(637, 238);
            this._Tpass.Name = "_Tpass";
            this._Tpass.Size = new System.Drawing.Size(132, 24);
            this._Tpass.TabIndex = 9;
            this._Tpass.Visible = false;
            // 
            // _TPhone
            // 
            this._TPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TPhone.Location = new System.Drawing.Point(637, 198);
            this._TPhone.Name = "_TPhone";
            this._TPhone.Size = new System.Drawing.Size(132, 24);
            this._TPhone.TabIndex = 8;
            this._TPhone.Visible = false;
            // 
            // _TLastName
            // 
            this._TLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TLastName.Location = new System.Drawing.Point(283, 238);
            this._TLastName.Name = "_TLastName";
            this._TLastName.Size = new System.Drawing.Size(128, 24);
            this._TLastName.TabIndex = 7;
            // 
            // _TFirstName
            // 
            this._TFirstName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TFirstName.Location = new System.Drawing.Point(283, 198);
            this._TFirstName.Name = "_TFirstName";
            this._TFirstName.Size = new System.Drawing.Size(128, 24);
            this._TFirstName.TabIndex = 6;
            // 
            // _TID
            // 
            this._TID.Enabled = false;
            this._TID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TID.Location = new System.Drawing.Point(283, 153);
            this._TID.Name = "_TID";
            this._TID.Size = new System.Drawing.Size(128, 24);
            this._TID.TabIndex = 11;
            // 
            // _TPimage
            // 
            this._TPimage.Image = global::x_prj_biblio.Properties.Resources.icons8_checked_user_male_160px;
            this._TPimage.Location = new System.Drawing.Point(863, 127);
            this._TPimage.Name = "_TPimage";
            this._TPimage.Size = new System.Drawing.Size(157, 139);
            this._TPimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._TPimage.TabIndex = 5;
            this._TPimage.TabStop = false;
            this._TPimage.Click += new System.EventHandler(this._TPimage_Click);
            // 
            // C_PersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._Tpertype);
            this.Controls.Add(this._TDatebirth);
            this.Controls.Add(this._TDateRegister);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ds);
            this.Controls.Add(this.dva);
            this.Controls.Add(this.sda);
            this.Controls.Add(this._TEmail);
            this.Controls.Add(this._Tpass);
            this.Controls.Add(this._TPhone);
            this.Controls.Add(this._TLastName);
            this.Controls.Add(this._TFirstName);
            this.Controls.Add(this._TID);
            this.Controls.Add(this._TPimage);
            this.Name = "C_PersonEdit";
            this.Size = new System.Drawing.Size(1189, 525);
            ((System.ComponentModel.ISupportInitialize)(this._TPimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _Tpertype;
        private System.Windows.Forms.DateTimePicker _TDatebirth;
        private System.Windows.Forms.DateTimePicker _TDateRegister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ds;
        private System.Windows.Forms.Label dva;
        private System.Windows.Forms.Label sda;
        private System.Windows.Forms.TextBox _TEmail;
        private System.Windows.Forms.TextBox _Tpass;
        private System.Windows.Forms.TextBox _TPhone;
        private System.Windows.Forms.TextBox _TLastName;
        private System.Windows.Forms.TextBox _TFirstName;
        private System.Windows.Forms.TextBox _TID;
        private System.Windows.Forms.PictureBox _TPimage;
    }
}
