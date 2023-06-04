using System;
using System.Drawing;
using System.Windows.Forms;
using NivelStocareDate;
using System.IO;
using System.Configuration;
using Tranzactii;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfataUtilizator_WindowsForms
{
    public partial class FormularAplicatie : Form
    {
        private const int LATIME_CONTROL = 140;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int OFFSET_X = 500;

        private Label lblData;
        private Label lblSuma;
        private Label lblCategorie;
        private Label lblTip;
        private Label lblDescriere;

        private Label dataTranzactieCautata;
        private Label sumaTranzactieCautata;
        private Label tipTranzactieCautata;
        private Label categorieTranzactieCautata;
        private Label descriereTranzactieCautata;

        private Label[] lblDate;
        private Label[] lblSume;
        private Label[] lblCategorii;
        private Label[] lblTipuri;
        private Label[] lblDescrieri;

        private AdministrareFisierText adminTranzactii;

        private string tipSelectat;
        private int ultimaTranzactieAfisata = 10;

        public FormularAplicatie()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminTranzactii = new AdministrareFisierText(caleCompletaFisier);                      

            InitializeComponent();

            //setare proprietati
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 11, FontStyle.Bold);
            this.ForeColor = Color.FromArgb(27, 27, 27);
            this.Text = "Informatii tranzactii";
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdaugareLabel(out lblData, LATIME_CONTROL, "Data", new Point(OFFSET_X, 0));
            AdaugareLabel(out lblSuma, LATIME_CONTROL, "Suma", new Point(OFFSET_X + DIMENSIUNE_PAS_X, 0));
            AdaugareLabel(out lblTip, LATIME_CONTROL + 10, "Tip", new Point(OFFSET_X + DIMENSIUNE_PAS_X * 2, 0));
            AdaugareLabel(out lblCategorie, LATIME_CONTROL, "Categorie", new Point(OFFSET_X + DIMENSIUNE_PAS_X * 3, 0));
            AdaugareLabel(out lblDescriere, LATIME_CONTROL + 40, "Descriere", new Point(OFFSET_X + DIMENSIUNE_PAS_X * 4, 0));
            AfisareTranzactii();
            VerificareTip();
        }

        private void AfiseazaTranzactie(Tranzactie tranzactie, int pozX, int pozY)
        {         
            if(dataTranzactieCautata != null)
            {
                Controls.Remove(dataTranzactieCautata);
                Controls.Remove(sumaTranzactieCautata);
                Controls.Remove(tipTranzactieCautata);
                Controls.Remove(categorieTranzactieCautata);
                Controls.Remove(descriereTranzactieCautata);
            }

            AdaugareLabel(out dataTranzactieCautata, LATIME_CONTROL, tranzactie.Data.ToString(),
                    new Point(pozX, pozY));
            AdaugareLabel(out sumaTranzactieCautata, LATIME_CONTROL, tranzactie.Suma.ToString(),
                new Point(pozX + DIMENSIUNE_PAS_X, pozY));
            AdaugareLabel(out tipTranzactieCautata, LATIME_CONTROL + 10, tranzactie.Tip,
                new Point(pozX + 2 * DIMENSIUNE_PAS_X, pozY));
            AdaugareLabel(out categorieTranzactieCautata, LATIME_CONTROL, tranzactie.Categorie,
                new Point(pozX + 3 * DIMENSIUNE_PAS_X, pozY));
            AdaugareLabel(out descriereTranzactieCautata, LATIME_CONTROL + 40, tranzactie.Descriere != string.Empty ? tranzactie.Descriere : "-",
                new Point(pozX + 4 * DIMENSIUNE_PAS_X, pozY));
        }

        private void AfisareTranzactii()
        {
            int nrTranzactii;
            Tranzactie[] tranzactii = adminTranzactii.GetTranzactii(out nrTranzactii);
            CuratareTranzactii();

            lblDate = new Label[nrTranzactii];
            lblSume = new Label[nrTranzactii];
            lblCategorii = new Label[nrTranzactii];
            lblTipuri = new Label[nrTranzactii];
            lblDescrieri = new Label[nrTranzactii];

            int maxTranzactiiAfisate = nrTranzactii < ultimaTranzactieAfisata ? nrTranzactii : ultimaTranzactieAfisata;
            for(int i = ultimaTranzactieAfisata - 10; i < maxTranzactiiAfisate; i++)
            {
                var offsetY = i % 10;
                Color culoareText;
                if (tranzactii[i].Tip == "Venit")
                    culoareText = Color.DarkBlue;
                else
                    culoareText = Color.FromArgb(220, 95, 1);
                AdaugareLabel(out lblDate[i], LATIME_CONTROL, tranzactii[i].Data.ToString(), 
                    new Point(OFFSET_X, (offsetY + 1) * DIMENSIUNE_PAS_Y), culoareText);
                AdaugareLabel(out lblSume[i], LATIME_CONTROL, tranzactii[i].Suma.ToString(),
                    new Point(OFFSET_X + DIMENSIUNE_PAS_X, (offsetY + 1) * DIMENSIUNE_PAS_Y), culoareText);
                AdaugareLabel(out lblTipuri[i], LATIME_CONTROL + 10, tranzactii[i].Tip, 
                    new Point(OFFSET_X + 2 * DIMENSIUNE_PAS_X, (offsetY + 1) * DIMENSIUNE_PAS_Y), culoareText);
                AdaugareLabel(out lblCategorii[i], LATIME_CONTROL, tranzactii[i].Categorie,
                    new Point(OFFSET_X + 3 * DIMENSIUNE_PAS_X, (offsetY + 1) * DIMENSIUNE_PAS_Y), culoareText);
                AdaugareLabel(out lblDescrieri[i], LATIME_CONTROL + 40, tranzactii[i].Descriere != string.Empty ? tranzactii[i].Descriere : "-",
                    new Point(OFFSET_X + 4 * DIMENSIUNE_PAS_X, (offsetY + 1) * DIMENSIUNE_PAS_Y), culoareText);
            }
        }

        private void CuratareTranzactii()
        {
            if (lblDate == null || lblSume == null || lblCategorii == null || lblTipuri == null || lblDescrieri == null) return;
            foreach (var label in lblDate)
            {
                Controls.Remove(label);
            }
            foreach(var label in lblSume)
            {
                Controls.Remove(label);
            }
            foreach(var label in lblCategorii)
            {
                Controls.Remove(label);
            }
            foreach(var label in lblTipuri)
            {
                Controls.Remove(label);
            }
            foreach(var label in lblDescrieri)
            {
                Controls.Remove(label);
            }
        }

        private void AdaugareLabel(out Label label, int latime, string text, Point pozitie, Color culoare = default(Color))
        {
            label = new Label()
            {
                Width = latime,
                Text = text,
                Left = pozitie.X,
                Top = pozitie.Y,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = culoare == default(Color) ? Color.DarkBlue : culoare
            };
            Controls.Add(label);
        }

        private void ActualizeazaDateCategorii()
        {
            string[] optiuni;
            categoriiTranzactii.Text = string.Empty;
            categoriiTranzactii.Items.Clear();

            if(tipSelectat == "Venit")
            {
                optiuni = new string[3] { "Alocatie", "Salariu", "Bonus" };
            }
            else
            {
                optiuni = new string[] { "Mancare", "Casa", "Viata sociala", "Dezvoltare personala", "Transport",
                    "Cultura", "Imbracaminte", "Sanatate", "Educatie", "Cadou", "Altele"};
            }

            categoriiTranzactii.Items.AddRange(optiuni);
        }

        private void VerificareTip()
        {
            string[] optiuni = new string[2] { "Venit", "Cheltuiala" };
        }

        private void btnAdaugareTranzactie_Click(object sender, EventArgs e)
        {
            bool eroare = false;
            if (txtSuma.Text == string.Empty)
            {
                lblSumaTranzactieNoua.ForeColor = Color.Red;
                eroare = true;
            }
            else
            {
                lblSumaTranzactieNoua.ForeColor = Color.DarkBlue;
            }
            if (categoriiTranzactii.Text == string.Empty)
            {
                lblCategorieTranzactieNoua.ForeColor = Color.Red;
                eroare = true;
            }
            else
            {
                lblCategorieTranzactieNoua.ForeColor = Color.DarkBlue;
            }

            if (eroare) return;

            Tranzactie tranzactie = new Tranzactie(tipSelectat, categoriiTranzactii.Text, txtDescriere.Text,
                double.Parse(txtSuma.Text), dateTimePicker.Value);

            adminTranzactii.AdaugaTranzactie(tranzactie);

            lblSumaTranzactieNoua.ForeColor = Color.DarkBlue;
            lblTipTranzactieNoua.ForeColor = Color.DarkBlue;
            lblCategorieTranzactieNoua.ForeColor = Color.DarkBlue;
            lblDescriereTranzactieNoua.ForeColor = Color.DarkBlue;

            txtSuma.Text = string.Empty;
            categoriiTranzactii.Text = string.Empty;
            txtDescriere.Text = string.Empty;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AfisareTranzactii();
        }

        private void txtSuma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tipuriTranzactii_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void categoriiTranzactii_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tipVenit_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                tipSelectat = selectedRadioButton.Text;
            }
            ActualizeazaDateCategorii();
        }

        private void tipCheltuiala_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton butonSelectat = sender as RadioButton;

            if (butonSelectat != null && butonSelectat.Checked)
            {
                tipSelectat = butonSelectat.Text;
            }
            ActualizeazaDateCategorii();
        }

        private void butonCautare_Click(object sender, EventArgs e)
        {
            var tranzactieCautata = adminTranzactii.GetTranzactie(cautareTxtBox.Text);
            if (tranzactieCautata.Descriere == string.Empty)
            {
                MessageBox.Show("Nu s-a gasit tranzactia cautata.");
                return;
            }

            AfiseazaTranzactie(tranzactieCautata, 20, 440);
        }

        private void butonNext_Click(object sender, EventArgs e)
        {
            int nrTranzactii = adminTranzactii.GetNumarTranzactii();
            if (ultimaTranzactieAfisata >= nrTranzactii) return;

            ultimaTranzactieAfisata += 10;
            AfisareTranzactii();
        }

        private void butonInapoi_Click(object sender, EventArgs e)
        {
            int nrTranzactii = adminTranzactii.GetNumarTranzactii();
            if(ultimaTranzactieAfisata <= nrTranzactii || ultimaTranzactieAfisata == 10) return;

            ultimaTranzactieAfisata -= 10;
            AfisareTranzactii();
        }
    }
}
