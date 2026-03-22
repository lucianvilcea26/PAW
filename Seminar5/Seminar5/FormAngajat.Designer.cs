namespace Seminar5
{
    partial class FormAngajat
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
            this.components = new System.ComponentModel.Container();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.cmbDepartament = new System.Windows.Forms.ComboBox();
            this.txtSalariu = new System.Windows.Forms.TextBox();
            this.dtpDataAngajarii = new System.Windows.Forms.DateTimePicker();
            this.chkEstePermanent = new System.Windows.Forms.CheckBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblDepartament = new System.Windows.Forms.Label();
            this.lblSalariu = new System.Windows.Forms.Label();
            this.lblDataAngajarii = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.epAngajati = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(95, 12);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(284, 20);
            this.txtNume.TabIndex = 0;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(95, 38);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(284, 20);
            this.txtPrenume.TabIndex = 1;
            // 
            // cmbDepartament
            // 
            this.cmbDepartament.FormattingEnabled = true;
            this.cmbDepartament.Items.AddRange(new object[] {
            "HR",
            "IT",
            "Vanzari",
            "Financiar"});
            this.cmbDepartament.Location = new System.Drawing.Point(95, 64);
            this.cmbDepartament.Name = "cmbDepartament";
            this.cmbDepartament.Size = new System.Drawing.Size(284, 21);
            this.cmbDepartament.TabIndex = 2;
            // 
            // txtSalariu
            // 
            this.txtSalariu.Location = new System.Drawing.Point(95, 91);
            this.txtSalariu.Name = "txtSalariu";
            this.txtSalariu.Size = new System.Drawing.Size(284, 20);
            this.txtSalariu.TabIndex = 3;
            // 
            // dtpDataAngajarii
            // 
            this.dtpDataAngajarii.Location = new System.Drawing.Point(95, 117);
            this.dtpDataAngajarii.Name = "dtpDataAngajarii";
            this.dtpDataAngajarii.Size = new System.Drawing.Size(284, 20);
            this.dtpDataAngajarii.TabIndex = 4;
            // 
            // chkEstePermanent
            // 
            this.chkEstePermanent.AutoSize = true;
            this.chkEstePermanent.Location = new System.Drawing.Point(95, 143);
            this.chkEstePermanent.Name = "chkEstePermanent";
            this.chkEstePermanent.Size = new System.Drawing.Size(100, 17);
            this.chkEstePermanent.TabIndex = 5;
            this.chkEstePermanent.Text = "Este permanent";
            this.chkEstePermanent.UseVisualStyleBackColor = true;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(12, 15);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 6;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(12, 41);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 7;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblDepartament
            // 
            this.lblDepartament.AutoSize = true;
            this.lblDepartament.Location = new System.Drawing.Point(12, 67);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(68, 13);
            this.lblDepartament.TabIndex = 8;
            this.lblDepartament.Text = "Departament";
            // 
            // lblSalariu
            // 
            this.lblSalariu.AutoSize = true;
            this.lblSalariu.Location = new System.Drawing.Point(12, 94);
            this.lblSalariu.Name = "lblSalariu";
            this.lblSalariu.Size = new System.Drawing.Size(39, 13);
            this.lblSalariu.TabIndex = 9;
            this.lblSalariu.Text = "Salariu";
            // 
            // lblDataAngajarii
            // 
            this.lblDataAngajarii.AutoSize = true;
            this.lblDataAngajarii.Location = new System.Drawing.Point(12, 120);
            this.lblDataAngajarii.Name = "lblDataAngajarii";
            this.lblDataAngajarii.Size = new System.Drawing.Size(72, 13);
            this.lblDataAngajarii.TabIndex = 10;
            this.lblDataAngajarii.Text = "Data angajarii";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(223, 166);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(75, 23);
            this.btnSalveaza.TabIndex = 11;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(304, 166);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.btnAnuleaza.TabIndex = 12;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            // 
            // epAngajati
            // 
            this.epAngajati.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epAngajati.ContainerControl = this;
            // 
            // FormAngajat
            // 
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(417, 199);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.lblDataAngajarii);
            this.Controls.Add(this.lblSalariu);
            this.Controls.Add(this.lblDepartament);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.chkEstePermanent);
            this.Controls.Add(this.dtpDataAngajarii);
            this.Controls.Add(this.txtSalariu);
            this.Controls.Add(this.cmbDepartament);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAngajat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAngajat";
            ((System.ComponentModel.ISupportInitialize)(this.epAngajati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.ComboBox cmbDepartament;
        private System.Windows.Forms.TextBox txtSalariu;
        private System.Windows.Forms.DateTimePicker dtpDataAngajarii;
        private System.Windows.Forms.CheckBox chkEstePermanent;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblDepartament;
        private System.Windows.Forms.Label lblSalariu;
        private System.Windows.Forms.Label lblDataAngajarii;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider epAngajati;
    }
}