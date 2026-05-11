namespace Seminar10
{
    partial class Form1
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();

            // dgvStudenti
            this.dgvStudenti.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.dgvStudenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudenti.Location = new System.Drawing.Point(12, 12);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowHeadersVisible = false;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(660, 360);

            // btnPrintPreview
            this.btnPrintPreview.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;
            this.btnPrintPreview.Location = new System.Drawing.Point(522, 388);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(150, 30);
            this.btnPrintPreview.Text = "Previzualizare";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);

            // printDocument1
            this.printDocument1.PrintPage +=
                new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

            // Form1
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btnPrintPreview);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog note";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

