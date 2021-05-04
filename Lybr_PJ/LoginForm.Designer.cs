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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.pic_Ins = new System.Windows.Forms.PictureBox();
            this.bt_Shide = new System.Windows.Forms.Button();
            this.cb_Rme = new System.Windows.Forms.CheckBox();
            this.tb_Pword = new System.Windows.Forms.TextBox();
            this.tb_Uname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.button_quitter = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ins)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(56)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 10);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(56)))));
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.pic_Ins);
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 186);
            this.panel3.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(39, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "Sing-In";
            // 
            // pic_Ins
            // 
            this.pic_Ins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_Ins.Image = ((System.Drawing.Image)(resources.GetObject("pic_Ins.Image")));
            this.pic_Ins.Location = new System.Drawing.Point(14, 18);
            this.pic_Ins.Name = "pic_Ins";
            this.pic_Ins.Size = new System.Drawing.Size(111, 110);
            this.pic_Ins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Ins.TabIndex = 0;
            this.pic_Ins.TabStop = false;
            // 
            // bt_Shide
            // 
            this.bt_Shide.BackColor = System.Drawing.Color.Transparent;
            this.bt_Shide.FlatAppearance.BorderSize = 0;
            this.bt_Shide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Shide.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Shide.Image = global::x_prj_biblio.Properties.Resources.eye;
            this.bt_Shide.Location = new System.Drawing.Point(391, 75);
            this.bt_Shide.Name = "bt_Shide";
            this.bt_Shide.Size = new System.Drawing.Size(27, 20);
            this.bt_Shide.TabIndex = 24;
            this.bt_Shide.UseVisualStyleBackColor = false;
            this.bt_Shide.Click += new System.EventHandler(this.bt_Shide_Click_1);
            // 
            // cb_Rme
            // 
            this.cb_Rme.AutoSize = true;
            this.cb_Rme.Location = new System.Drawing.Point(258, 103);
            this.cb_Rme.Name = "cb_Rme";
            this.cb_Rme.Size = new System.Drawing.Size(95, 17);
            this.cb_Rme.TabIndex = 3;
            this.cb_Rme.Text = "Remember Me";
            this.cb_Rme.UseVisualStyleBackColor = true;
            // 
            // tb_Pword
            // 
            this.tb_Pword.Location = new System.Drawing.Point(257, 75);
            this.tb_Pword.Name = "tb_Pword";
            this.tb_Pword.Size = new System.Drawing.Size(128, 20);
            this.tb_Pword.TabIndex = 2;
            this.tb_Pword.UseSystemPasswordChar = true;
            this.tb_Pword.Click += new System.EventHandler(this.tb_Pword_Click);
            this.tb_Pword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Pword_KeyDown);
            // 
            // tb_Uname
            // 
            this.tb_Uname.Location = new System.Drawing.Point(258, 36);
            this.tb_Uname.Name = "tb_Uname";
            this.tb_Uname.Size = new System.Drawing.Size(160, 20);
            this.tb_Uname.TabIndex = 1;
            this.tb_Uname.Click += new System.EventHandler(this.tb_Uname_Click);
            this.tb_Uname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Uname_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Utilisateur :";
            // 
            // bt_Login
            // 
            this.bt_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Login.Location = new System.Drawing.Point(203, 141);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(100, 35);
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "Connecter";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(318, 141);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(100, 35);
            this.button_quitter.TabIndex = 5;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 202);
            this.Controls.Add(this.bt_Shide);
            this.Controls.Add(this.cb_Rme);
            this.Controls.Add(this.tb_Pword);
            this.Controls.Add(this.tb_Uname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connecter";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pic_Ins;
        private System.Windows.Forms.Button bt_Shide;
        private System.Windows.Forms.CheckBox cb_Rme;
        private System.Windows.Forms.TextBox tb_Pword;
        private System.Windows.Forms.TextBox tb_Uname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button button_quitter;
    }
}

