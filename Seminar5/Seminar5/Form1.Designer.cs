namespace Seminar5
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
            this.dgvAngajati = new System.Windows.Forms.DataGridView();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.cmbFiltruDepartament = new System.Windows.Forms.ComboBox();
            this.lblFiltrare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAngajati
            // 
            this.dgvAngajati.AllowUserToAddRows = false;
            this.dgvAngajati.AllowUserToDeleteRows = false;
            this.dgvAngajati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngajati.Location = new System.Drawing.Point(12, 39);
            this.dgvAngajati.MultiSelect = false;
            this.dgvAngajati.Name = "dgvAngajati";
            this.dgvAngajati.ReadOnly = true;
            this.dgvAngajati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAngajati.Size = new System.Drawing.Size(1008, 569);
            this.dgvAngajati.TabIndex = 0;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(12, 614);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Location = new System.Drawing.Point(93, 614);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(75, 23);
            this.btnEditeaza.TabIndex = 2;
            this.btnEditeaza.Text = "Editeaza";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(174, 614);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(75, 23);
            this.btnSterge.TabIndex = 3;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // cmbFiltruDepartament
            // 
            this.cmbFiltruDepartament.FormattingEnabled = true;
            this.cmbFiltruDepartament.Items.AddRange(new object[] {
            "Toate",
            "HR",
            "IT",
            "Financiar",
            "Vanzari"});
            this.cmbFiltruDepartament.Location = new System.Drawing.Point(153, 12);
            this.cmbFiltruDepartament.Name = "cmbFiltruDepartament";
            this.cmbFiltruDepartament.Size = new System.Drawing.Size(322, 21);
            this.cmbFiltruDepartament.TabIndex = 4;
            this.cmbFiltruDepartament.SelectedIndexChanged += new System.EventHandler(this.cmbFiltruDepartament_SelectedIndexChanged);
            // 
            // lblFiltrare
            // 
            this.lblFiltrare.AutoSize = true;
            this.lblFiltrare.Location = new System.Drawing.Point(12, 15);
            this.lblFiltrare.Name = "lblFiltrare";
            this.lblFiltrare.Size = new System.Drawing.Size(135, 13);
            this.lblFiltrare.TabIndex = 5;
            this.lblFiltrare.Text = "Filtreaza dupa departament";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 649);
            this.Controls.Add(this.lblFiltrare);
            this.Controls.Add(this.cmbFiltruDepartament);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dgvAngajati);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngajati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAngajati;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ComboBox cmbFiltruDepartament;
        private System.Windows.Forms.Label lblFiltrare;
    }
}

