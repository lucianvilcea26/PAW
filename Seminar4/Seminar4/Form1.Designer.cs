namespace Seminar4
{
    partial class Form1
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
            this.grpDateContact = new System.Windows.Forms.GroupBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkNotificariActive = new System.Windows.Forms.CheckBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.lstContacte = new System.Windows.Forms.ListBox();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.btnSterge = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpDateContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDateContact
            // 
            this.grpDateContact.Controls.Add(this.btnSalveaza);
            this.grpDateContact.Controls.Add(this.chkNotificariActive);
            this.grpDateContact.Controls.Add(this.txtEmail);
            this.grpDateContact.Controls.Add(this.txtTelefon);
            this.grpDateContact.Controls.Add(this.txtPrenume);
            this.grpDateContact.Controls.Add(this.txtNume);
            this.grpDateContact.Controls.Add(this.lblEmail);
            this.grpDateContact.Controls.Add(this.lblTelefon);
            this.grpDateContact.Controls.Add(this.lblPrenume);
            this.grpDateContact.Controls.Add(this.lblNume);
            this.grpDateContact.Location = new System.Drawing.Point(12, 12);
            this.grpDateContact.Name = "grpDateContact";
            this.grpDateContact.Size = new System.Drawing.Size(290, 437);
            this.grpDateContact.TabIndex = 0;
            this.grpDateContact.TabStop = false;
            this.grpDateContact.Text = "Date contact";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(6, 22);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(6, 48);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(6, 74);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(83, 19);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(201, 20);
            this.txtNume.TabIndex = 4;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(83, 45);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(201, 20);
            this.txtPrenume.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(83, 71);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(201, 20);
            this.txtTelefon.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(83, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // chkNotificariActive
            // 
            this.chkNotificariActive.AutoSize = true;
            this.chkNotificariActive.Location = new System.Drawing.Point(83, 123);
            this.chkNotificariActive.Name = "chkNotificariActive";
            this.chkNotificariActive.Size = new System.Drawing.Size(99, 17);
            this.chkNotificariActive.TabIndex = 8;
            this.chkNotificariActive.Text = "Notificari active";
            this.chkNotificariActive.UseVisualStyleBackColor = true;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(209, 153);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(75, 23);
            this.btnSalveaza.TabIndex = 9;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // lstContacte
            // 
            this.lstContacte.FormattingEnabled = true;
            this.lstContacte.Location = new System.Drawing.Point(308, 47);
            this.lstContacte.Name = "lstContacte";
            this.lstContacte.Size = new System.Drawing.Size(264, 368);
            this.lstContacte.TabIndex = 1;
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(308, 20);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(264, 20);
            this.txtCautare.TabIndex = 2;
            this.txtCautare.TextChanged += new System.EventHandler(this.txtCautare_TextChanged);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(497, 426);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(75, 23);
            this.btnSterge.TabIndex = 3;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(308, 431);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.lstContacte);
            this.Controls.Add(this.grpDateContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registru contacte";
            this.grpDateContact.ResumeLayout(false);
            this.grpDateContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDateContact;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.CheckBox chkNotificariActive;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.ListBox lstContacte;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label lblStatus;
    }
}

