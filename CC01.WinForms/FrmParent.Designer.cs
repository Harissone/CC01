namespace CC01.WinForms
{
    partial class FrmParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.etudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ecolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etudiantsToolStripMenuItem,
            this.ecoleToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // etudiantsToolStripMenuItem
            // 
            this.etudiantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererToolStripMenuItem,
            this.toolStripSeparator1,
            this.deconnectionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.etudiantsToolStripMenuItem.Name = "etudiantsToolStripMenuItem";
            this.etudiantsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.etudiantsToolStripMenuItem.Text = "Fichier";
            this.etudiantsToolStripMenuItem.Click += new System.EventHandler(this.etudiantsToolStripMenuItem_Click);
            // 
            // gererToolStripMenuItem
            // 
            this.gererToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etudiantsToolStripMenuItem1,
            this.ecolesToolStripMenuItem});
            this.gererToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gererToolStripMenuItem.Image")));
            this.gererToolStripMenuItem.Name = "gererToolStripMenuItem";
            this.gererToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gererToolStripMenuItem.Text = "Gerer";
            // 
            // etudiantsToolStripMenuItem1
            // 
            this.etudiantsToolStripMenuItem1.Name = "etudiantsToolStripMenuItem1";
            this.etudiantsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.etudiantsToolStripMenuItem1.Text = "Etudiants";
            // 
            // ecolesToolStripMenuItem
            // 
            this.ecolesToolStripMenuItem.Name = "ecolesToolStripMenuItem";
            this.ecolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ecolesToolStripMenuItem.Text = "Ecoles";
            this.ecolesToolStripMenuItem.Click += new System.EventHandler(this.ecolesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // deconnectionToolStripMenuItem
            // 
            this.deconnectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deconnectionToolStripMenuItem.Image")));
            this.deconnectionToolStripMenuItem.Name = "deconnectionToolStripMenuItem";
            this.deconnectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deconnectionToolStripMenuItem.Text = "Deconnection";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // ecoleToolStripMenuItem
            // 
            this.ecoleToolStripMenuItem.Name = "ecoleToolStripMenuItem";
            this.ecoleToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ecoleToolStripMenuItem.Text = "Option";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 474);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmParent";
            this.Text = "Gestion des cartes d\'etudiants";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem etudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ecolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}