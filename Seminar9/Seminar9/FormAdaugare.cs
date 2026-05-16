using System;
using System.Windows.Forms;

namespace Seminar9
{
    public partial class FormAdaugare : Form
    {
        public FormAdaugare()
        {
            InitializeComponent();

            var items = Enum.GetValues(typeof(Dispozitie));
            foreach (var item in items)
            {
                cmbDispozitie.Items.Add(item);
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (!ValideazaFormular())
                return;

            var intrare = new IntrareJurnal()
            {
                Titlu = txtTitlu.Text,
                Continut = rtbDescriere.Text,
                Data = dtpData.Value,
                Dispozitie = (Dispozitie)cmbDispozitie.SelectedItem,
                EstePrivata = chkEstePrivata.Checked
            };

            FakeDatabase.Intrari.Add(intrare);

            DialogResult = DialogResult.OK;
        }

        private bool ValideazaFormular()
        {
            errorProvider.Clear();
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtTitlu.Text))
            {
                errorProvider.SetError(txtTitlu, "Titlul este obligatoriu");
                hasError = true;
            }
            if (string.IsNullOrEmpty(rtbDescriere.Text))
            {
                errorProvider.SetError(rtbDescriere, "Descrierea este obligatorie");
                hasError = true;
            }
            if (cmbDispozitie.SelectedItem == null)
            {
                errorProvider.SetError(cmbDispozitie, "Dispozitia este obligatorie");
                hasError = true;
            }

            return !hasError;
        }
    }
}
