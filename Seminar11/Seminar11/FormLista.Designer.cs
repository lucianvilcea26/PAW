namespace Seminar11
{
    partial class FormLista
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
            this.lvTaskuri = new System.Windows.Forms.ListView();
            this.cmsTaskuri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniMarcheaza = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRedeschide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniSterge = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTaskuri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTaskuri
            // 
            this.lvTaskuri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTaskuri.HideSelection = false;
            this.lvTaskuri.Location = new System.Drawing.Point(12, 12);
            this.lvTaskuri.Name = "lvTaskuri";
            this.lvTaskuri.Size = new System.Drawing.Size(891, 460);
            this.lvTaskuri.TabIndex = 1;
            this.lvTaskuri.UseCompatibleStateImageBehavior = false;
            this.lvTaskuri.View = System.Windows.Forms.View.Details;
            this.lvTaskuri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvTaskuri_MouseClick);
            // 
            // cmsTaskuri
            // 
            this.cmsTaskuri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMarcheaza,
            this.mniRedeschide,
            this.toolStripSeparator1,
            this.mniSterge});
            this.cmsTaskuri.Name = "cmsTaskuri";
            this.cmsTaskuri.Size = new System.Drawing.Size(193, 76);
            this.cmsTaskuri.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTaskuri_Opening);
            // 
            // mniMarcheaza
            // 
            this.mniMarcheaza.Name = "mniMarcheaza";
            this.mniMarcheaza.Size = new System.Drawing.Size(192, 22);
            this.mniMarcheaza.Text = "Marchează ca efectuat";
            this.mniMarcheaza.Click += new System.EventHandler(this.mniMarcheaza_Click);
            // 
            // mniRedeschide
            // 
            this.mniRedeschide.Name = "mniRedeschide";
            this.mniRedeschide.Size = new System.Drawing.Size(192, 22);
            this.mniRedeschide.Text = "Redeschide";
            this.mniRedeschide.Click += new System.EventHandler(this.mniRedeschide_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // mniSterge
            // 
            this.mniSterge.Name = "mniSterge";
            this.mniSterge.Size = new System.Drawing.Size(192, 22);
            this.mniSterge.Text = "Șterge";
            this.mniSterge.Click += new System.EventHandler(this.mniSterge_Click);
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 484);
            this.Controls.Add(this.lvTaskuri);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormLista";
            this.Text = "Listă task-uri";
            this.Activated += new System.EventHandler(this.FormLista_Activated);
            this.cmsTaskuri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListView lvTaskuri;
        private System.Windows.Forms.ContextMenuStrip cmsTaskuri;
        private System.Windows.Forms.ToolStripMenuItem mniMarcheaza;
        private System.Windows.Forms.ToolStripMenuItem mniRedeschide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mniSterge;
    }
}