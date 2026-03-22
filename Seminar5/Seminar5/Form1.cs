using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar5
{
    public partial class Form1 : Form
    {
        private BindingList<Angajat> _angajati = new BindingList<Angajat>()
        {
            new Angajat()
            {
                Nume = "Popescu",
                Prenume = "Ion",
                Departament = "Vanzari",
                Salariu = 5700m,
                DataAngajarii = new DateTime(2021, 11, 20),
                EstePermanent = true
            }
        };

        public Form1()
        {
            InitializeComponent();
            dgvAngajati.DataSource = _angajati;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (var formAngajat = new FormAngajat())
            {
                if (formAngajat.ShowDialog() == DialogResult.OK)
                {
                    _angajati.Add(formAngajat.AngajatModificat);
                }
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            var index = dgvAngajati.SelectedRows[0].Index;
            var angajat = _angajati[index];

            using (var formAngajat = new FormAngajat(angajat))
            {
                if (formAngajat.ShowDialog() == DialogResult.OK)
                {
                    _angajati[index] = formAngajat.AngajatModificat;
                }
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            var index = dgvAngajati.SelectedRows[0].Index;
            var angajat = _angajati[index];

            if (MessageBox.Show($"Sunteti sigur ca vreti sa stergeti angajatul {angajat.Prenume} {angajat.Nume}?",
                "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _angajati.Remove(angajat);
            }
        }

        private void cmbFiltruDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltruDepartament.SelectedItem.ToString() == "Toate")
            {
                dgvAngajati.DataSource = _angajati;
            }
            else
            {
                var departament = cmbFiltruDepartament.SelectedItem.ToString();
                var angajatiFiltrati = _angajati.Where(angajat => angajat.Departament == departament).ToList();
                var bindingListFiltrat = new BindingList<Angajat>(angajatiFiltrati); 

                dgvAngajati.DataSource = bindingListFiltrat;
            }
        }
    }
}
