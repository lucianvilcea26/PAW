using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar11
{
    public partial class FormTaskNou : Form
    {
        public FormTaskNou()
        {
            InitializeComponent();
        }

        private void FormTaskNou_Load(object sender, EventArgs e)
        {
            cmbPrioritate.DataSource = Enum.GetValues(typeof(Prioritate));
            cmbPrioritate.SelectedIndex = 1;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtTitlu.Text))
            {
                errorProvider.SetError(txtTitlu, "Titlul este obligatoriu.");
                txtTitlu.Focus();
                return;
            }

            TodoTask task = new TodoTask
            {
                Titlu = txtTitlu.Text.Trim(),
                Descriere = rtbDescriere.Text.Trim(),
                Prioritate = (Prioritate)cmbPrioritate.SelectedItem,
                DataCreare = DateTime.Now,
                Efectuat = false
            };

            FakeDatabase.Taskuri.Add(task);
            this.Close();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
