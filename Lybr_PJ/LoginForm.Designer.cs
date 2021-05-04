namespace x_prj_biblio
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Shide = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkBox_AfficherCaracters = new System.Windows.Forms.CheckBox();
            this.tb_Pword = new System.Windows.Forms.TextBox();
            this.tb_Uname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_connecter = new System.Windows.Forms.Button();
            this.button_quitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Shide);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.checkBox_AfficherCaracters);
            this.groupBox1.Controls.Add(this.tb_Pword);
            this.groupBox1.Controls.Add(this.tb_Uname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_connecter);
            this.groupBox1.Controls.Add(this.button_quitter);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 199);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connecter-vou";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_Shide
            // 
            this.bt_Shide.BackColor = System.Drawing.Color.Transparent;
            this.bt_Shide.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_Shide.Image = global::x_prj_biblio.Properties.Resources.eye;
            this.bt_Shide.Location = new System.Drawing.Point(387, 85);
            this.bt_Shide.Name = "bt_Shide";
            this.bt_Shide.Size = new System.Drawing.Size(27, 23);
            this.bt_Shide.TabIndex = 16;
            this.bt_Shide.UseVisualStyleBackColor = false;
            this.bt_Shide.Click += new System.EventHandler(this.bt_Shide_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 129);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // checkBox_AfficherCaracters
            // 
            this.checkBox_AfficherCaracters.AutoSize = true;
            this.checkBox_AfficherCaracters.Location = new System.Drawing.Point(254, 114);
            this.checkBox_AfficherCaracters.Name = "checkBox_AfficherCaracters";
            this.checkBox_AfficherCaracters.Size = new System.Drawing.Size(114, 19);
            this.checkBox_AfficherCaracters.TabIndex = 14;
            this.checkBox_AfficherCaracters.Text = "Pigner Mot Pass";
            this.checkBox_AfficherCaracters.UseVisualStyleBackColor = true;
            // 
            // tb_Pword
            // 
            this.tb_Pword.Location = new System.Drawing.Point(254, 85);
            this.tb_Pword.Name = "tb_Pword";
            this.tb_Pword.Size = new System.Drawing.Size(160, 23);
            this.tb_Pword.TabIndex = 11;
            this.tb_Pword.UseSystemPasswordChar = true;
            // 
            // tb_Uname
            // 
            this.tb_Uname.Location = new System.Drawing.Point(254, 36);
            this.tb_Uname.Name = "tb_Uname";
            this.tb_Uname.Size = new System.Drawing.Size(160, 23);
            this.tb_Uname.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Utilisateur :";
            // 
            // button_connecter
            // 
            this.button_connecter.Image = ((System.Drawing.Image)(resources.GetObject("button_connecter.Image")));
            this.button_connecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_connecter.Location = new System.Drawing.Point(208, 149);
            this.button_connecter.Name = "button_connecter";
            this.button_connecter.Size = new System.Drawing.Size(100, 35);
            this.button_connecter.TabIndex = 7;
            this.button_connecter.Text = "Connecter";
            this.button_connecter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_connecter.UseVisualStyleBackColor = true;
            this.button_connecter.Click += new System.EventHandler(this.button_connecter_Click);
            // 
            // button_quitter
            // 
            this.button_quitter.Image = ((System.Drawing.Image)(resources.GetObject("button_quitter.Image")));
            this.button_quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_quitter.Location = new System.Drawing.Point(314, 149);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(100, 35);
            this.button_quitter.TabIndex = 6;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 222);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkBox_AfficherCaracters;
        private System.Windows.Forms.TextBox tb_Pword;
        private System.Windows.Forms.TextBox tb_Uname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_connecter;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Button bt_Shide;
    }
}

