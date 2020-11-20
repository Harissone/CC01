namespace CC01.WinForms
{
    partial class FrmCreateEtudiant
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtDateNaissance = new System.Windows.Forms.TextBox();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.txtLieuxNaissance = new System.Windows.Forms.TextBox();
            this.lblLieuxNaissance = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSexe = new System.Windows.Forms.TextBox();
            this.lblSexe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 29);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 56);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(177, 20);
            this.txtNom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(12, 118);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(177, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 91);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prenom";
            // 
            // txtDateNaissance
            // 
            this.txtDateNaissance.Location = new System.Drawing.Point(12, 182);
            this.txtDateNaissance.Name = "txtDateNaissance";
            this.txtDateNaissance.Size = new System.Drawing.Size(177, 20);
            this.txtDateNaissance.TabIndex = 6;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(12, 155);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(83, 13);
            this.lblDateNaissance.TabIndex = 5;
            this.lblDateNaissance.Text = "Date Naissance";
            // 
            // txtLieuxNaissance
            // 
            this.txtLieuxNaissance.Location = new System.Drawing.Point(12, 254);
            this.txtLieuxNaissance.Name = "txtLieuxNaissance";
            this.txtLieuxNaissance.Size = new System.Drawing.Size(177, 20);
            this.txtLieuxNaissance.TabIndex = 8;
            // 
            // lblLieuxNaissance
            // 
            this.lblLieuxNaissance.AutoSize = true;
            this.lblLieuxNaissance.Location = new System.Drawing.Point(12, 227);
            this.lblLieuxNaissance.Name = "lblLieuxNaissance";
            this.lblLieuxNaissance.Size = new System.Drawing.Size(85, 13);
            this.lblLieuxNaissance.TabIndex = 7;
            this.lblLieuxNaissance.Text = "Lieux Naissance";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(272, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(272, 56);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(177, 20);
            this.txtIdentifiant.TabIndex = 11;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(272, 29);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.lblIdentifiant.TabIndex = 10;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(272, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(272, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(272, 182);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(177, 20);
            this.txtContact.TabIndex = 15;
            this.txtContact.Text = "`";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Contact";
            // 
            // txtSexe
            // 
            this.txtSexe.Location = new System.Drawing.Point(272, 254);
            this.txtSexe.Name = "txtSexe";
            this.txtSexe.Size = new System.Drawing.Size(177, 20);
            this.txtSexe.TabIndex = 17;
            this.txtSexe.Text = "`";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(272, 227);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(31, 13);
            this.lblSexe.TabIndex = 16;
            this.lblSexe.Text = "Sexe";
            // 
            // FrmCreateEtudiant
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.txtSexe);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLieuxNaissance);
            this.Controls.Add(this.lblLieuxNaissance);
            this.Controls.Add(this.txtDateNaissance);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmCreateEtudiant";
            this.Text = "FrmCreateEtudiant";
            this.Load += new System.EventHandler(this.FrmCreateEtudiant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtDateNaissance;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.TextBox txtLieuxNaissance;
        private System.Windows.Forms.Label lblLieuxNaissance;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSexe;
        private System.Windows.Forms.Label lblSexe;
    }
}