namespace Seminar9
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
            this.lvIntrari = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvIntrari
            // 
            this.lvIntrari.HideSelection = false;
            this.lvIntrari.Location = new System.Drawing.Point(12, 38);
            this.lvIntrari.Name = "lvIntrari";
            this.lvIntrari.Size = new System.Drawing.Size(776, 400);
            this.lvIntrari.TabIndex = 0;
            this.lvIntrari.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.intrareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deschideBinarToolStripMenuItem,
            this.salveazaBinarToolStripMenuItem,
            this.deschideXMLToolStripMenuItem,
            this.salveazaXMLToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // deschideBinarToolStripMenuItem
            // 
            this.deschideBinarToolStripMenuItem.Name = "deschideBinarToolStripMenuItem";
            this.deschideBinarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deschideBinarToolStripMenuItem.Text = "Deschide binar";
            this.deschideBinarToolStripMenuItem.Click += new System.EventHandler(this.deschideBinarToolStripMenuItem_Click);
            // 
            // salveazaBinarToolStripMenuItem
            // 
            this.salveazaBinarToolStripMenuItem.Name = "salveazaBinarToolStripMenuItem";
            this.salveazaBinarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salveazaBinarToolStripMenuItem.Text = "Salveaza binar";
            this.salveazaBinarToolStripMenuItem.Click += new System.EventHandler(this.salveazaBinarToolStripMenuItem_Click);
            // 
            // deschideXMLToolStripMenuItem
            // 
            this.deschideXMLToolStripMenuItem.Name = "deschideXMLToolStripMenuItem";
            this.deschideXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deschideXMLToolStripMenuItem.Text = "Deschide XML";
            this.deschideXMLToolStripMenuItem.Click += new System.EventHandler(this.deschideXMLToolStripMenuItem_Click);
            // 
            // salveazaXMLToolStripMenuItem
            // 
            this.salveazaXMLToolStripMenuItem.Name = "salveazaXMLToolStripMenuItem";
            this.salveazaXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salveazaXMLToolStripMenuItem.Text = "Salveaza XML";
            this.salveazaXMLToolStripMenuItem.Click += new System.EventHandler(this.salveazaXMLToolStripMenuItem_Click);
            // 
            // intrareToolStripMenuItem
            // 
            this.intrareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem});
            this.intrareToolStripMenuItem.Name = "intrareToolStripMenuItem";
            this.intrareToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.intrareToolStripMenuItem.Text = "Intrare";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvIntrari);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvIntrari;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intrareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
    }
}

