using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Seminar11
{
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();

            lvTaskuri.MultiSelect = false;
            lvTaskuri.FullRowSelect = true;
            lvTaskuri.GridLines = true;

            lvTaskuri.Columns.Clear();
            var width = lvTaskuri.ClientSize.Width;
            lvTaskuri.Columns.Add("Titlu", (int)(width * 0.2));
            lvTaskuri.Columns.Add("Descriere", (int)(width * 0.45));
            lvTaskuri.Columns.Add("Data", (int)(width * 0.1));
            lvTaskuri.Columns.Add("Prioritate", (int)(width * 0.1));
            lvTaskuri.Columns.Add("Efectuat", (int)(width * 0.15));


        }

        private void FormLista_Activated(object sender, EventArgs e)
        {
            RefreshLista();
        }

        private void RefreshLista()
        {
            lvTaskuri.Items.Clear();

            foreach (TodoTask t in FakeDatabase.Taskuri)
            {
                ListViewItem item = new ListViewItem(t.Titlu);
                item.SubItems.Add(t.Descriere);
                item.SubItems.Add(t.Prioritate.ToString());
                item.SubItems.Add(t.DataCreare.ToString("dd.MM.yyyy"));
                item.SubItems.Add(t.Efectuat ? "Efectuat" : "In desfasurare");
                item.Tag = t;

                if (t.Efectuat)
                {
                    item.ForeColor = Color.Green;
                    item.Font = new Font(lvTaskuri.Font, FontStyle.Italic);
                }
                else
                {
                    item.Font = new Font(lvTaskuri.Font, FontStyle.Bold);
                    if (t.Prioritate == Prioritate.Inalta)
                    {
                        item.ForeColor = Color.Red;
                    }
                }

                lvTaskuri.Items.Add(item);
            }
        }

        private void lvTaskuri_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            var task = lvTaskuri.SelectedItems[0].Tag as TodoTask;

            if (task.Efectuat)
            {
                mniMarcheaza.Enabled = false;
                mniRedeschide.Enabled = true;
            }
            else
            {
                mniMarcheaza.Enabled = true;
                mniRedeschide.Enabled = false;
            }

            cmsTaskuri.Show(lvTaskuri, e.Location);
        }

        private void cmsTaskuri_Opening(object sender, CancelEventArgs e)
        {
            if (lvTaskuri.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            var task = lvTaskuri.SelectedItems[0].Tag as TodoTask;
            mniMarcheaza.Enabled = !task.Efectuat;
            mniRedeschide.Enabled = task.Efectuat;
        }

        private void mniMarcheaza_Click(object sender, EventArgs e)
        {
            var task = lvTaskuri.SelectedItems[0].Tag as TodoTask;
            task.Efectuat = true;
            RefreshLista();
        }

        private void mniRedeschide_Click(object sender, EventArgs e)
        {
            var task = lvTaskuri.SelectedItems[0].Tag as TodoTask;
            task.Efectuat = false;
            RefreshLista();
        }

        private void mniSterge_Click(object sender, EventArgs e)
        {
            var task = lvTaskuri.SelectedItems[0].Tag as TodoTask;

            if (MessageBox.Show(
                $"Sunteti sigur ca vreti sa stergeti \"{task.Titlu}\"?",
                "Confirmare stergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FakeDatabase.Taskuri.Remove(task);
                RefreshLista();
            }
        }
    }
}
