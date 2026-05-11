using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Seminar10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvStudenti.DataSource = FakeDatabase.Studenti;
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = printDocument1;
                preview.Width = 800;
                preview.Height = 650;
                preview.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            var g = e.Graphics;
            var x = e.MarginBounds.Left;
            var y = e.MarginBounds.Top;
            var w = e.MarginBounds.Width;

            Font fontTitlu = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic);
            Font fontStudent = new Font("Arial", 11, FontStyle.Bold);
            Font fontMaterie = new Font("Arial", 10, FontStyle.Regular);

            g.DrawString("Catalog note studenti", fontTitlu, Brushes.Black, x, y);
            y += 40;

            foreach (Student s in FakeDatabase.Studenti)
            {
                g.DrawString(s.Nume, fontStudent, Brushes.Black, x, y);
                y += 20;

                g.DrawString("Matematica: " + s.Matematica, fontMaterie, Brushes.Black, x + 30, y); 
                y += 16;
                g.DrawString("Informatica: " + s.Informatica, fontMaterie, Brushes.Black, x + 30, y); 
                y += 16;
                g.DrawString("Fizica: " + s.Fizica, fontMaterie, Brushes.Black, x + 30, y); 
                y += 16;
                g.DrawString("Chimie: " + s.Chimie, fontMaterie, Brushes.Black, x + 30, y); 
                y += 16;
                g.DrawString("Biologie: " + s.Biologie, fontMaterie, Brushes.Black, x + 30, y); 
                y += 24;
            }

            y += 10;
            g.DrawString("Medii generale", fontStudent, Brushes.Black, x, y);
            y += 22;

            Dictionary<string, double> medii = new Dictionary<string, double>
            {
                { "Matematica", FakeDatabase.Studenti.Average(s => s.Matematica) },
                { "Informatica", FakeDatabase.Studenti.Average(s => s.Informatica) },
                { "Fizica", FakeDatabase.Studenti.Average(s => s.Fizica) },
                { "Chimie", FakeDatabase.Studenti.Average(s => s.Chimie) },
                { "Biologie", FakeDatabase.Studenti.Average(s => s.Biologie) }
            };

            var o = w / 2;
            var p = 3;
            var inaltimeRand = 18;

            var yTabel = y;

            g.FillRectangle(Brushes.LightGray, x, y, w, inaltimeRand);
            g.DrawString("Materie", fontMaterie, Brushes.Black, x + p, y + p);
            g.DrawString("Medie", fontMaterie, Brushes.Black, x + o + p, y + p);
           
            y += inaltimeRand;
            g.DrawLine(Pens.Black, x, y, x + w, y);

            foreach (var medie in medii)
            {
                g.DrawString(medie.Key, fontMaterie, Brushes.Black, x + p, y + p);
                g.DrawString(medie.Value.ToString("F2"), fontMaterie, Brushes.Black, x + o + p, y + p);
                g.DrawLine(Pens.Black, x, y + inaltimeRand, x + w, y + inaltimeRand);
                y += inaltimeRand;
            }

            g.DrawRectangle(Pens.Black, x, yTabel, e.MarginBounds.Width, y - yTabel);
            g.DrawLine(Pens.Black, x + o, yTabel, x + o, y);
        }
    }
}
