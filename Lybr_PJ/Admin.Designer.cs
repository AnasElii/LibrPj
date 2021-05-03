namespace x_prj_biblio
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrownsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauBorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererBorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliothécairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauBibliothécaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererBibliothécairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.BorrownsToolStripMenuItem,
            this.empruntToolStripMenuItem,
            this.bibliothécairesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Fichier";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connectionToolStripMenuItem.Image")));
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauLivreToolStripMenuItem,
            this.gererLivresToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editToolStripMenuItem.Text = "Livres";
            // 
            // nouveauLivreToolStripMenuItem
            // 
            this.nouveauLivreToolStripMenuItem.Name = "nouveauLivreToolStripMenuItem";
            this.nouveauLivreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauLivreToolStripMenuItem.Text = "Nouveau Livre";
            // 
            // gererLivresToolStripMenuItem
            // 
            this.gererLivresToolStripMenuItem.Name = "gererLivresToolStripMenuItem";
            this.gererLivresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gererLivresToolStripMenuItem.Text = "Gerer Livres";
            this.gererLivresToolStripMenuItem.Click += new System.EventHandler(this.gererLivresToolStripMenuItem_Click);
            // 
            // BorrownsToolStripMenuItem
            // 
            this.BorrownsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauBorrowToolStripMenuItem,
            this.gererBorrowToolStripMenuItem});
            this.BorrownsToolStripMenuItem.Name = "BorrownsToolStripMenuItem";
            this.BorrownsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.BorrownsToolStripMenuItem.Text = "Borrow";
            // 
            // nouveauBorrowToolStripMenuItem
            // 
            this.nouveauBorrowToolStripMenuItem.Name = "nouveauBorrowToolStripMenuItem";
            this.nouveauBorrowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauBorrowToolStripMenuItem.Text = "Add_Borrowing";
            this.nouveauBorrowToolStripMenuItem.Click += new System.EventHandler(this.nouveauBorrowToolStripMenuItem_Click);
            // 
            // gererBorrowToolStripMenuItem
            // 
            this.gererBorrowToolStripMenuItem.Name = "gererBorrowToolStripMenuItem";
            this.gererBorrowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gererBorrowToolStripMenuItem.Text = "Gerer Borrow";
            this.gererBorrowToolStripMenuItem.Click += new System.EventHandler(this.gererBorrowToolStripMenuItem_Click);
            // 
            // empruntToolStripMenuItem
            // 
            this.empruntToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauAutorToolStripMenuItem,
            this.gererAutorToolStripMenuItem});
            this.empruntToolStripMenuItem.Name = "empruntToolStripMenuItem";
            this.empruntToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.empruntToolStripMenuItem.Text = "Autor";
            // 
            // nouveauAutorToolStripMenuItem
            // 
            this.nouveauAutorToolStripMenuItem.Name = "nouveauAutorToolStripMenuItem";
            this.nouveauAutorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauAutorToolStripMenuItem.Text = "Nouveau Autor";
            this.nouveauAutorToolStripMenuItem.Click += new System.EventHandler(this.nouveauEmpruntToolStripMenuItem_Click);
            // 
            // gererAutorToolStripMenuItem
            // 
            this.gererAutorToolStripMenuItem.Name = "gererAutorToolStripMenuItem";
            this.gererAutorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gererAutorToolStripMenuItem.Text = "Gerer Autor";
            this.gererAutorToolStripMenuItem.Click += new System.EventHandler(this.gererAutorToolStripMenuItem_Click);
            // 
            // bibliothécairesToolStripMenuItem
            // 
            this.bibliothécairesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauBibliothécaireToolStripMenuItem,
            this.gererBibliothécairesToolStripMenuItem});
            this.bibliothécairesToolStripMenuItem.Name = "bibliothécairesToolStripMenuItem";
            this.bibliothécairesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.bibliothécairesToolStripMenuItem.Text = "Bibliothécaires";
            this.bibliothécairesToolStripMenuItem.Click += new System.EventHandler(this.bibliothécairesToolStripMenuItem_Click);
            // 
            // nouveauBibliothécaireToolStripMenuItem
            // 
            this.nouveauBibliothécaireToolStripMenuItem.Name = "nouveauBibliothécaireToolStripMenuItem";
            this.nouveauBibliothécaireToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.nouveauBibliothécaireToolStripMenuItem.Text = "Nouveau Bibliothécaire";
            this.nouveauBibliothécaireToolStripMenuItem.Click += new System.EventHandler(this.nouveauBibliothécaireToolStripMenuItem_Click);
            // 
            // gererBibliothécairesToolStripMenuItem
            // 
            this.gererBibliothécairesToolStripMenuItem.Name = "gererBibliothécairesToolStripMenuItem";
            this.gererBibliothécairesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.gererBibliothécairesToolStripMenuItem.Text = "Gerer Bibliothécaires";
            this.gererBibliothécairesToolStripMenuItem.Click += new System.EventHandler(this.gererBibliothécairesToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BorrownsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauBorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererBorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliothécairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauBibliothécaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererBibliothécairesToolStripMenuItem;
    }
}