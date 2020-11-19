namespace CC01.WinForms
{
    partial class FrmCreateSchool
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
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBoitePostale = new System.Windows.Forms.TextBox();
            this.lblBoitePostale = new System.Windows.Forms.Label();
            this.txtLocalisation = new System.Windows.Forms.TextBox();
            this.lblLocalisation = new System.Windows.Forms.Label();
            this.txtNomEcole = new System.Windows.Forms.TextBox();
            this.lblNomEcole = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(287, 137);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(177, 20);
            this.txtContact.TabIndex = 33;
            this.txtContact.Text = "`";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Contact";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(287, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(287, 36);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoitePostale
            // 
            this.txtBoitePostale.Location = new System.Drawing.Point(27, 199);
            this.txtBoitePostale.Name = "txtBoitePostale";
            this.txtBoitePostale.Size = new System.Drawing.Size(177, 20);
            this.txtBoitePostale.TabIndex = 26;
            // 
            // lblBoitePostale
            // 
            this.lblBoitePostale.AutoSize = true;
            this.lblBoitePostale.Location = new System.Drawing.Point(27, 172);
            this.lblBoitePostale.Name = "lblBoitePostale";
            this.lblBoitePostale.Size = new System.Drawing.Size(69, 13);
            this.lblBoitePostale.TabIndex = 25;
            this.lblBoitePostale.Text = "Boite Postale";
            // 
            // txtLocalisation
            // 
            this.txtLocalisation.Location = new System.Drawing.Point(27, 125);
            this.txtLocalisation.Name = "txtLocalisation";
            this.txtLocalisation.Size = new System.Drawing.Size(177, 20);
            this.txtLocalisation.TabIndex = 22;
            // 
            // lblLocalisation
            // 
            this.lblLocalisation.AutoSize = true;
            this.lblLocalisation.Location = new System.Drawing.Point(27, 98);
            this.lblLocalisation.Name = "lblLocalisation";
            this.lblLocalisation.Size = new System.Drawing.Size(63, 13);
            this.lblLocalisation.TabIndex = 21;
            this.lblLocalisation.Text = "Localisation";
            // 
            // txtNomEcole
            // 
            this.txtNomEcole.Location = new System.Drawing.Point(27, 63);
            this.txtNomEcole.Name = "txtNomEcole";
            this.txtNomEcole.Size = new System.Drawing.Size(177, 20);
            this.txtNomEcole.TabIndex = 20;
            // 
            // lblNomEcole
            // 
            this.lblNomEcole.AutoSize = true;
            this.lblNomEcole.Location = new System.Drawing.Point(27, 36);
            this.lblNomEcole.Name = "lblNomEcole";
            this.lblNomEcole.Size = new System.Drawing.Size(59, 13);
            this.lblNomEcole.TabIndex = 19;
            this.lblNomEcole.Text = "Nom Ecole";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmCreateSchool
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(490, 311);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBoitePostale);
            this.Controls.Add(this.lblBoitePostale);
            this.Controls.Add(this.txtLocalisation);
            this.Controls.Add(this.lblLocalisation);
            this.Controls.Add(this.txtNomEcole);
            this.Controls.Add(this.lblNomEcole);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmCreateSchool";
            this.Text = "FrmCreateSchool";
            this.Load += new System.EventHandler(this.FrmCreateSchool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBoitePostale;
        private System.Windows.Forms.Label lblBoitePostale;
        private System.Windows.Forms.TextBox txtLocalisation;
        private System.Windows.Forms.Label lblLocalisation;
        private System.Windows.Forms.TextBox txtNomEcole;
        private System.Windows.Forms.Label lblNomEcole;
        private System.Windows.Forms.Button btnSave;
    }
}