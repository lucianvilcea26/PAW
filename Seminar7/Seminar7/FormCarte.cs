using System;
using System.Windows.Forms;

namespace Seminar7
{
    public partial class FormCarte : Form
    {
        private CarteRepository _carteRepository;
        private Carte _carteEditare;
        private bool _isUpdateOperation;

        public FormCarte(Guid? id = null)
        {
            InitializeComponent();
            _carteRepository = new CarteRepository();

            numAn.Minimum = 1000;
            numAn.Maximum = DateTime.Now.Year;
            numAn.Value = DateTime.Now.Year;

            var genuri = Enum.GetValues(typeof(GenCarte));
            foreach (var item in genuri)
            {
                cmbGen.Items.Add(item);
            }

            if (id == null)
            {               
                _isUpdateOperation = false;
                _carteEditare = new Carte()
                {
                    Id = Guid.NewGuid()
                };
                Text = "Adauga carte";
            }
            else
            {
                _isUpdateOperation = true;
                _carteEditare = _carteRepository.GetById(id.Value);
                Text = $"Editeaza cartea {_carteEditare.Titlu} - {_carteEditare.Autor}";

                txtTitlu.Text = _carteEditare.Titlu;
                txtAutor.Text = _carteEditare.Autor;
                numAn.Value = _carteEditare.AnAparitie;
                cmbGen.SelectedItem = _carteEditare.Gen;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            _carteEditare.Titlu = txtTitlu.Text;
            _carteEditare.Autor = txtAutor.Text;
            _carteEditare.AnAparitie = (int)numAn.Value;
            _carteEditare.Gen = (GenCarte)cmbGen.SelectedItem;

            if (_isUpdateOperation)
                _carteRepository.Update(_carteEditare);
            else
                _carteRepository.Add(_carteEditare);

            DialogResult = DialogResult.OK;
        }

        private bool ValidateForm()
        {
            epCarte.Clear();
            bool esteValid = true;

            if (string.IsNullOrWhiteSpace(txtTitlu.Text))
            {
                epCarte.SetError(txtTitlu, "Titlul este obligatoriu");
                esteValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                epCarte.SetError(txtAutor, "Autorul este obligatoriu");
                esteValid = false;
            }

            if (numAn.Value < 1000 || numAn.Value > DateTime.Now.Year)
            {
                epCarte.SetError(numAn, "Anul este invalid");
                esteValid = false;
            }

            if (cmbGen.SelectedIndex < 0)
            {
                epCarte.SetError(cmbGen, "Genul este obligatoriu");
                esteValid = false;
            }

            return esteValid;
        }
    }
}
