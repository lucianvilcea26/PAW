using System.Windows.Forms;

namespace Seminar6
{
    public partial class Form1 : Form
    {
        private CarteRepository _carteRepository;

        public Form1()
        {
            InitializeComponent();
            _carteRepository = new CarteRepository();
                        
            lvCarti.View = View.Details;
            lvCarti.FullRowSelect = true;
            lvCarti.MultiSelect = false;
            lvCarti.GridLines = true;
            lvCarti.AllowColumnReorder = true;

            int latimeDisponibila = lvCarti.ClientSize.Width;

            lvCarti.Columns.Add("Titlu", (int)(0.3 * latimeDisponibila), HorizontalAlignment.Left);
            lvCarti.Columns.Add("Autor", (int)(0.3 * latimeDisponibila), HorizontalAlignment.Left);
            lvCarti.Columns.Add("An aparitie", (int)(0.2 * latimeDisponibila), HorizontalAlignment.Center);
            lvCarti.Columns.Add("Gen", (int)(0.2 * latimeDisponibila), HorizontalAlignment.Right);

            btnEditeaza.Enabled = false;
            btnSterge.Enabled = false;

            RefreshList();
        }

        private void RefreshList()
        {
            lvCarti.Items.Clear();
            foreach (var c in _carteRepository.GetAll())
            {
                ListViewItem item = new ListViewItem(c.Titlu);
                item.SubItems.Add(c.Autor);
                item.SubItems.Add(c.AnAparitie.ToString());
                item.SubItems.Add(c.Gen.ToString());
                item.Tag = c;

                lvCarti.Items.Add(item);
            }
        }

        private void lvCarti_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            btnEditeaza.Enabled = true;
            btnSterge.Enabled = true;
        }

        private void btnAdauga_Click(object sender, System.EventArgs e)
        {
            using (var formCarte = new FormCarte())
            {
                if (formCarte.ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                }
            }
        }

        private void btnEditeaza_Click(object sender, System.EventArgs e)
        {
            var carte = lvCarti.SelectedItems[0].Tag as Carte;
            using (var formCarte = new FormCarte(carte.Id))
            {
                if (formCarte.ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                }
            }
        }

        private void btnSterge_Click(object sender, System.EventArgs e)
        {
            var carte = lvCarti.SelectedItems[0].Tag as Carte;
            if (MessageBox.Show($"Sunteti sigur ca vreti sa stergeti cartea {carte.Titlu} de {carte.Autor}?",
                "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _carteRepository.Delete(carte.Id);
                RefreshList();
            }
        }
    }
}
