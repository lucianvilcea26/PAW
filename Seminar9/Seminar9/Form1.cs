using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Seminar9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lvIntrari.View = View.Details;
            lvIntrari.MultiSelect = false;
            lvIntrari.FullRowSelect = true;

            var width = lvIntrari.ClientSize.Width;
            lvIntrari.Columns.Clear();
            lvIntrari.Columns.Add("Data", (int)(width * 0.1));
            lvIntrari.Columns.Add("Titlu", (int)(width * 0.25));
            lvIntrari.Columns.Add("Continut", (int)(width * 0.45));
            lvIntrari.Columns.Add("Dispozitie", (int)(width * 0.1));
            lvIntrari.Columns.Add("Privata", (int)(width * 0.1));

            RefreshLista();
        }

        private void RefreshLista()
        {
            lvIntrari.Items.Clear();
            foreach (var intrare in FakeDatabase.Intrari)
            {
                var item = new ListViewItem(intrare.Data.ToString("dd.MM.yyyy"));
                item.SubItems.Add(intrare.EstePrivata ? "***" : intrare.Titlu);
                item.SubItems.Add(intrare.EstePrivata ? "***" : intrare.Continut);
                item.SubItems.Add(intrare.EstePrivata ? "***" : intrare.Dispozitie.ToString());
                item.SubItems.Add(intrare.EstePrivata ? "Privata" : "Publica");

                lvIntrari.Items.Add(item);
            }
        }

        private void salveazaBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Fisiere binare|*.bin|Toate fisierele|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = saveFileDialog.FileName;
                    using (var stream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(stream, FakeDatabase.Intrari);
                        MessageBox.Show("Jurnalul a fost serializat binar cu succes", "Succes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void deschideBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fisiere binare|*.bin|Toate fisierele|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = openFileDialog.FileName;
                    using (var stream = new FileStream(fileName, FileMode.Open))
                    {
                        var formatter = new BinaryFormatter();
                        FakeDatabase.Intrari = (List<IntrareJurnal>)formatter.Deserialize(stream);
                        RefreshLista();
                        MessageBox.Show("Jurnalul a fost deserializat cu succes din fisierul binar", "Succes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void salveazaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Fisiere XML|*.xml|Toate fisierele|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = saveFileDialog.FileName;
                    using (var stream = new StreamWriter(fileName))
                    {
                        var serializer = new XmlSerializer(typeof(Jurnal));
                        serializer.Serialize(stream, new Jurnal() { Intrari = FakeDatabase.Intrari });
                        MessageBox.Show("Jurnalul a fost serializat binar cu succes", "Succes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void deschideXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fisiere XML|*.xml|Toate fisierele|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = openFileDialog.FileName;
                    using (var stream = new StreamReader(fileName))
                    {
                        var serializer = new XmlSerializer(typeof(Jurnal));
                        var jurnal = (Jurnal)serializer.Deserialize(stream);
                        FakeDatabase.Intrari = jurnal.Intrari;
                        RefreshLista();
                        MessageBox.Show("Jurnalul a fost deserializat cu succes din fisierul binar", "Succes",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formAdaugare = new FormAdaugare())
            {
                formAdaugare.ShowDialog();
                RefreshLista();
            }
        }
    }
}
