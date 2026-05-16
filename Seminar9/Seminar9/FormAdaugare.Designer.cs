namespace Seminar9
{
    partial class FormAdaugare
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
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.rtbDescriere = new System.Windows.Forms.RichTextBox();
            this.cmbDispozitie = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.chkEstePrivata = new System.Windows.Forms.CheckBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(89, 12);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(332, 20);
            this.txtTitlu.TabIndex = 0;
            // 
            // rtbDescriere
            // 
            this.rtbDescriere.Location = new System.Drawing.Point(89, 38);
            this.rtbDescriere.Name = "rtbDescriere";
            this.rtbDescriere.Size = new System.Drawing.Size(332, 96);
            this.rtbDescriere.TabIndex = 1;
            this.rtbDescriere.Text = "";
            // 
            // cmbDispozitie
            // 
            this.cmbDispozitie.FormattingEnabled = true;
            this.cmbDispozitie.Location = new System.Drawing.Point(89, 140);
            this.cmbDispozitie.Name = "cmbDispozitie";
            this.cmbDispozitie.Size = new System.Drawing.Size(332, 21);
            this.cmbDispozitie.TabIndex = 2;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(89, 167);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(332, 20);
            this.dtpData.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.chkEstePrivata.AutoSize = true;
            this.chkEstePrivata.Location = new System.Drawing.Point(89, 193);
            this.chkEstePrivata.Name = "checkBox1";
            this.chkEstePrivata.Size = new System.Drawing.Size(59, 17);
            this.chkEstePrivata.TabIndex = 4;
            this.chkEstePrivata.Text = "Privata";
            this.chkEstePrivata.UseVisualStyleBackColor = true;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(265, 218);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(75, 23);
            this.btnSalveaza.TabIndex = 5;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(346, 218);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.btnAnuleaza.TabIndex = 6;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(12, 15);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(27, 13);
            this.lblTitlu.TabIndex = 7;
            this.lblTitlu.Text = "Titlu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descriere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dispozitie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FormAdaugare
            // 
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(442, 253);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.chkEstePrivata);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cmbDispozitie);
            this.Controls.Add(this.rtbDescriere);
            this.Controls.Add(this.txtTitlu);
            this.Name = "FormAdaugare";
            this.Text = "FormAdaugare";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.RichTextBox rtbDescriere;
        private System.Windows.Forms.ComboBox cmbDispozitie;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.CheckBox chkEstePrivata;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}