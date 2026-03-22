using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Seminar4
{
    public partial class Form1 : Form
    {
        private List<Contact> _contacte = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNume.Text))
            {
                MessageBox.Show("Numele este obligatoriu", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPrenume.Text))
            {
                MessageBox.Show("Prenumele este obligatoriu", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("Telefonul este obligatoriu", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var contact = new Contact()
            {
                Nume = txtNume.Text.Trim(),
                Prenume = txtPrenume.Text.Trim(),
                Telefon = txtTelefon.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                NotificariActive = chkNotificariActive.Checked
            };
            _contacte.Add(contact);

            RefreshListaContacte(_contacte);

            txtNume.Text = string.Empty;
            txtPrenume .Text = string.Empty;
            txtTelefon .Text = string.Empty;
            txtEmail .Text = string.Empty;
            chkNotificariActive.Checked = false;
            txtNume.Focus();

            lblStatus.Text = $"Contact adaugat. Total: {_contacte.Count} contacte";
        }

        private void txtCautare_TextChanged(object sender, EventArgs e)
        {
            var termen = txtCautare.Text.Trim().ToLower();
            var listaFiltrata = _contacte.Where(contact => contact.ToString().ToLower().Contains(termen)).ToList();

            RefreshListaContacte(listaFiltrata);
            lblStatus.Text = termen == string.Empty ?
                lblStatus.Text = $"Total: {_contacte.Count} contacte" :
                lblStatus.Text = $"Se afiseaza {listaFiltrata.Count} din {_contacte.Count} contacte";
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            var index = lstContacte.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Nu ati selectat niciun contact", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var contact = _contacte[index];
            if (MessageBox.Show($"Sunteti sigur ca vreti sa stergeti contactul {contact.Prenume} {contact.Nume}?",
                "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _contacte.Remove(contact);
                RefreshListaContacte(_contacte);

                lblStatus.Text = $"Contact sters. Total: {_contacte.Count} contacte";
            }
        }

        private void RefreshListaContacte(List<Contact> contacte)
        {
            lstContacte.Items.Clear();
            foreach (Contact contact in contacte)
            {
                lstContacte.Items.Add(contact);
            }
        }
    }
}
