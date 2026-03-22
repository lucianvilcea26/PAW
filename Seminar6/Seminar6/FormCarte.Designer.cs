namespace Seminar6
{
    partial class FormCarte
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
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.numAn = new System.Windows.Forms.NumericUpDown();
            this.cmbGen = new System.Windows.Forms.ComboBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.epCarte = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCarte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(12, 15);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(27, 13);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Titlu";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(12, 41);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(12, 66);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(57, 13);
            this.lblAn.TabIndex = 2;
            this.lblAn.Text = "An aparitie";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(12, 93);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(27, 13);
            this.lblGen.TabIndex = 3;
            this.lblGen.Text = "Gen";
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(100, 12);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(287, 20);
            this.txtTitlu.TabIndex = 4;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(100, 38);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(287, 20);
            this.txtAutor.TabIndex = 5;
            // 
            // numAn
            // 
            this.numAn.Location = new System.Drawing.Point(100, 64);
            this.numAn.Name = "numAn";
            this.numAn.Size = new System.Drawing.Size(287, 20);
            this.numAn.TabIndex = 6;
            // 
            // cmbGen
            // 
            this.cmbGen.FormattingEnabled = true;
            this.cmbGen.Location = new System.Drawing.Point(100, 90);
            this.cmbGen.Name = "cmbGen";
            this.cmbGen.Size = new System.Drawing.Size(287, 21);
            this.cmbGen.TabIndex = 7;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(231, 117);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(75, 23);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(312, 117);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.btnAnuleaza.TabIndex = 9;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            // 
            // epCarte
            // 
            this.epCarte.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epCarte.ContainerControl = this;
            // 
            // FormCarte
            // 
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(415, 152);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.cmbGen);
            this.Controls.Add(this.numAn);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Name = "FormCarte";
            this.Text = "FormCarte";
            ((System.ComponentModel.ISupportInitialize)(this.numAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.NumericUpDown numAn;
        private System.Windows.Forms.ComboBox cmbGen;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider epCarte;
    }
}