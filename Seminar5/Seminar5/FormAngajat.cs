using System;
using System.Windows.Forms;

namespace Seminar5
{
    public partial class FormAngajat : Form
    {
        public Angajat AngajatModificat { get; private set; }

        public FormAngajat(Angajat angajat = null)
        {
            InitializeComponent();

            if (angajat != null)
            {
                Text = $"Editeaza angajatul {angajat.Prenume} {angajat.Nume}";
                txtNume.Text = angajat.Nume;
                txtPrenume.Text = angajat.Prenume;
                cmbDepartament.SelectedItem = angajat.Departament;
                txtSalariu.Text = angajat.Salariu.ToString();
                dtpDataAngajarii.Value = angajat.DataAngajarii;
                chkEstePermanent.Checked = angajat.EstePermanent;
            }
            else
            {
                Text = "Adauga angajat nou";
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            epAngajati.Clear();
            bool esteValid = true;
            if (string.IsNullOrEmpty(txtNume.Text))
            {
                epAngajati.SetError(txtNume, "Numele este obligatoriu");
                esteValid = false;
            }
            if (string.IsNullOrEmpty(txtPrenume.Text))
            {
                epAngajati.SetError(txtPrenume, "Prenumele este obligatoriu");
                esteValid = false;
            }
            if (!decimal.TryParse(txtSalariu.Text, out decimal salariu))
            {
                epAngajati.SetError(txtSalariu, "Salariul este invalid");
                esteValid = false;
            }
            else
            {
                if (salariu < 0)
                {
                    epAngajati.SetError(txtSalariu, "Salariul nu poate fi negativ");
                    esteValid = false;
                }
            }

            if (!esteValid)
                return;

            AngajatModificat = new Angajat()
            {
                Nume = txtNume.Text,
                Prenume = txtPrenume.Text,
                Departament = cmbDepartament.SelectedItem.ToString(),
                Salariu = salariu,
                DataAngajarii = dtpDataAngajarii.Value,
                EstePermanent = chkEstePermanent.Checked,
            };

            DialogResult = DialogResult.OK;
        }
    }
}
