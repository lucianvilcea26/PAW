namespace Seminar11
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniFisier = new System.Windows.Forms.ToolStripMenuItem();
            this.mniIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTaskuriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniListaTaskuri = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTaskNou = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFisier,
            this.mniTaskuriMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1090, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // mniFisier
            // 
            this.mniFisier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniIesire});
            this.mniFisier.Name = "mniFisier";
            this.mniFisier.Size = new System.Drawing.Size(46, 20);
            this.mniFisier.Text = "Fișier";
            // 
            // mniIesire
            // 
            this.mniIesire.Name = "mniIesire";
            this.mniIesire.Size = new System.Drawing.Size(101, 22);
            this.mniIesire.Text = "Ieșire";
            this.mniIesire.Click += new System.EventHandler(this.mniIesire_Click);
            // 
            // mniTaskuriMenu
            // 
            this.mniTaskuriMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniListaTaskuri,
            this.mniTaskNou});
            this.mniTaskuriMenu.Name = "mniTaskuriMenu";
            this.mniTaskuriMenu.Size = new System.Drawing.Size(61, 20);
            this.mniTaskuriMenu.Text = "Task-uri";
            // 
            // mniListaTaskuri
            // 
            this.mniListaTaskuri.Name = "mniListaTaskuri";
            this.mniListaTaskuri.Size = new System.Drawing.Size(141, 22);
            this.mniListaTaskuri.Text = "Listă task-uri";
            this.mniListaTaskuri.Click += new System.EventHandler(this.mniListaTaskuri_Click);
            // 
            // mniTaskNou
            // 
            this.mniTaskNou.Name = "mniTaskNou";
            this.mniTaskNou.Size = new System.Drawing.Size(141, 22);
            this.mniTaskNou.Text = "Task nou";
            this.mniTaskNou.Click += new System.EventHandler(this.mniTaskNou_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 551);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniFisier;
        private System.Windows.Forms.ToolStripMenuItem mniIesire;
        private System.Windows.Forms.ToolStripMenuItem mniTaskuriMenu;
        private System.Windows.Forms.ToolStripMenuItem mniListaTaskuri;
        private System.Windows.Forms.ToolStripMenuItem mniTaskNou;
    }
}

