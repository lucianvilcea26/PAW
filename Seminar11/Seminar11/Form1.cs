using System;
using System.Windows.Forms;

namespace Seminar11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mniListaTaskuri_Click(object sender, EventArgs e)
        {
            foreach (var form in MdiChildren)
            {
                if (form is FormLista)
                {
                    form.Activate();
                    return;
                }
            }

            FormLista lista = new FormLista();
            lista.MdiParent = this;
            lista.Show();
        }

        private void mniTaskNou_Click(object sender, EventArgs e)
        {
            FormTaskNou formNou = new FormTaskNou();
            formNou.MdiParent = this;
            formNou.Show();
        }

        private void mniIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
