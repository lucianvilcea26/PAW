namespace Seminar11
{
    partial class FormTaskNou
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.rtbDescriere = new System.Windows.Forms.RichTextBox();
            this.lblPrioritate = new System.Windows.Forms.Label();
            this.cmbPrioritate = new System.Windows.Forms.ComboBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(12, 15);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Text = "Titlu:";

            // txtTitlu
            this.txtTitlu.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.txtTitlu.Location = new System.Drawing.Point(100, 12);
            this.txtTitlu.MaxLength = 200;
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(350, 23);

            // lblDescriere
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Location = new System.Drawing.Point(12, 55);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Text = "Descriere:";

            // rtbDescriere
            this.rtbDescriere.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.rtbDescriere.Location = new System.Drawing.Point(100, 52);
            this.rtbDescriere.Name = "rtbDescriere";
            this.rtbDescriere.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDescriere.Size = new System.Drawing.Size(350, 100);

            // lblPrioritate
            this.lblPrioritate.AutoSize = true;
            this.lblPrioritate.Location = new System.Drawing.Point(12, 168);
            this.lblPrioritate.Name = "lblPrioritate";
            this.lblPrioritate.Text = "Prioritate:";

            // cmbPrioritate
            this.cmbPrioritate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioritate.Location = new System.Drawing.Point(100, 165);
            this.cmbPrioritate.Name = "cmbPrioritate";
            this.cmbPrioritate.Size = new System.Drawing.Size(150, 23);

            // btnSalveaza
            this.btnSalveaza.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;
            this.btnSalveaza.Location = new System.Drawing.Point(275, 208);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(85, 28);
            this.btnSalveaza.Text = "Salvează";
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);

            // btnAnuleaza
            this.btnAnuleaza.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;
            this.btnAnuleaza.Location = new System.Drawing.Point(365, 208);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(85, 28);
            this.btnAnuleaza.Text = "Anulează";
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);

            // errorProvider1
            this.errorProvider.ContainerControl = this;

            // FormTaskNou
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 248);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.rtbDescriere);
            this.Controls.Add(this.lblPrioritate);
            this.Controls.Add(this.cmbPrioritate);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnAnuleaza);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTaskNou";
            this.Text = "Task nou";
            this.Load += new System.EventHandler(this.FormTaskNou_Load);

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.RichTextBox rtbDescriere;
        private System.Windows.Forms.Label lblPrioritate;
        private System.Windows.Forms.ComboBox cmbPrioritate;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}