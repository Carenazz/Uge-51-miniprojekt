using System;
using System.Windows.Forms;

namespace Uge_51___miniprojekt
{
    public partial class BestillingsMenu : Form
    {
        #region Dashboard
        public BestillingsMenu()
        {
            InitializeComponent();

            // Panel for ekstra ingredienser liste
            IngredienserList.Visible = false;
            Ekstra.Visible = false;
            TilbehørPanel.Visible = false;
            EkstraOk.Visible = false;
        }
        #endregion

        #region Variabler

        // Samlet sum.
        int sum = 0;

        // Rabat checker, min 2 pizzaer og sodavand for rabat.
        int antalPizza = 0, antalSoda = 0;
        private bool rabat = false;

        // Rabat variabler
        private int iRabat = 0;

        #endregion

        #region Usikker på hvad er indtil videre.
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Kan ikke fjernes uden det ødelægger programmet (kigges mere ind på)
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Bestillings knap

        private void button1_Click(object sender, EventArgs e)
        {
            if (KurvListe.Items.Count == 0)
            {
                MessageBox.Show("Du har intet i kurven");
            }
            else if (rabat == true)
            {
                MessageBox.Show("Din bestilling er modtaget og prisen er: " + (sum - 20) + ".- Du har fået: " + iRabat + ".- i rabat");
            }
            else
            {
                MessageBox.Show("Din bestilling på: " + sum + ".- er modtaget");
            }
        }

        #endregion

        #region Kurven
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Knapper som tilføjer til kurv og tilføjer sum.

        // Pepperoni alm.
        private void button2_Click(object sender, EventArgs e)
        {
            // Kommentaren under passer til hvad de forskellige steder er og gælder for alle andre "void clicks"
            //               Pizzaens navn     -     Combobox = dejens valg     -    størrelses valget -  Prisen for pizzaen
            string[] row = { Pepperoni.Text + " pizza  - " + comboBox1.SelectedItem + " - " + AlmPepp.Text + " " + PeppAPris.Text};
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            // Udregning af pris + visning af pris
            sum += 55;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            // test til at adde en "-" knap.
            // DynamiskFortrydKnap(sender, e);

            // Rabatcheck
            antalPizza++;
            RabatCheck();

            // Refere til visning af ingrediens listen
            VisEkstraListe();
        }

        // Pepperoni fam.
        private void button3_Click(object sender, EventArgs e)
        {
            string[] row = { Pepperoni.Text + " pizza  - " + comboBox1.SelectedItem + " - " + FamPepp.Text + " " + PeppFPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 105;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            // DynamiskFortrydKnap(sender, e); (Ude af drift da den ikke virker)

            antalPizza++;
            RabatCheck();

            VisEkstraListe();
        }

        private void Alm_Skinke_Click(object sender, EventArgs e)
        {
            string[] row = { Skinke.Text + " pizza  - " + comboBox2.SelectedItem + " - " + AlmSkinke.Text + " " + SkinkeAPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 55;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            // DynamiskFortrydKnap(sender, e);

            antalPizza++;
            RabatCheck();

            VisEkstraListe();
        }

        private void Fam_Skinke_Click(object sender, EventArgs e)
        {
            string[] row = { Skinke.Text + " pizza  - " + comboBox2.SelectedItem + " - " + SkinkeFam.Text + " " + SkinkeFPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 105;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            // DynamiskFortrydKnap(sender, e);

            antalPizza++;
            RabatCheck();

            VisEkstraListe();
        }

        private void Alm_Hawaii_Click(object sender, EventArgs e)
        {
            string[] row = { Hawaii.Text + " pizza  - " + comboBox3.SelectedItem + " - " + AlmHawaii.Text + " " + HawaiiAPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 65;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            // DynamiskFortrydKnap(sender, e);

            antalPizza++;
            RabatCheck();

            VisEkstraListe();
        }

        private void Fam_Hawaii_Click(object sender, EventArgs e)
        {
            string[] row = { Hawaii.Text + " pizza  - " + comboBox3.SelectedItem + " - " + HawaiiFam.Text + " " + HawaiiFPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 115;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            // DynamiskFortrydKnap(sender, e);

            antalPizza++;
            RabatCheck();

            VisEkstraListe();
        }

        private void Alm_DinEgen_Click(object sender, EventArgs e)
        {
            string[] row = { LavDinEgen.Text + " pizza  - " + comboBox4.SelectedItem + " - " + LavAlm.Text + " " + LavAPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 50;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            // DynamiskFortrydKnap(sender, e);

            antalPizza++;
            RabatCheck();

            VisEkstraListe();
        }

        private void Fam_DinEgen_Click(object sender, EventArgs e)
        {
            string[] row = { LavDinEgen.Text + " pizza  - " + comboBox4.SelectedItem + " - " + LavFam.Text + " " + LavFamPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 100;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            // DynamiskFortrydKnap(sender, e);

            antalPizza++;
            RabatCheck();

            VisEkstraListe();
        }


        // Ingredienser
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] rowExtra = { "Med: " + IngredienserList.SelectedItem.ToString() };
            var listViewItem = new ListViewItem(rowExtra);
            KurvListe.Items.Add(listViewItem);
            sum += 5;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            // DynamiskFortrydKnap(sender, e);
        }
        #endregion

        #region Drikkevarer


        // Mærke på sodavand.
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] row = { listBox2.SelectedItem.ToString() };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            // DynamiskFortrydKnap(sender, e);
        }

        // Størrelsen på sodavand.
        private void button2_Click_1(object sender, EventArgs e)
        {
            string[] row = { LilleCola.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 15;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            // DynamiskFortrydKnap(sender, e);

            //Rabatcheck for soda
            antalSoda++;
            RabatCheck();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string[] row = { MellemCola.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 20;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            // DynamiskFortrydKnap(sender, e);

            antalSoda++;
            RabatCheck();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] row = { StorCola.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 25;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            // DynamiskFortrydKnap(sender, e);

            antalSoda++;
            RabatCheck();
        }

        #endregion

        #region Fortryd knap.

        // Fjerner alt på listen og resetter alle værdier.

        private void Ryd_Click(object sender, EventArgs e)
        {
            // Rydder listen + knapper.
            KurvListe.Items.Clear();
            KurvListe.Controls.Clear();
            // resetter alle givet værdier, resetter teksten.
            sum = 0;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
            rabatTxt.Text = "Rabat: ";
            antalPizza = 0;
            antalSoda = 0;
            rabat = false;
        }


        #endregion

        #region Rabat

        private void RabatCheck()
        {
            if (antalPizza >= 2 && antalSoda >= 2 && rabat == false)
            {
                iRabat += 20;
                totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
                rabatTxt.Text = "Rabat: " + iRabat + " Kr.";
                rabat = true;
            }
        }
        #endregion

        // Hvis og gemmer listen for ekstra ingredienser
        private void VisEkstraListe()
        {
            IngredienserList.Visible = true;
            Ekstra.Visible = true;
            TilbehørPanel.Visible = true;
            EkstraOk.Visible = true;
        }

        private void EkstraOk_Click(object sender, EventArgs e)
        {
            IngredienserList.Visible = false;
            Ekstra.Visible = false;
            TilbehørPanel.Visible = false;
            EkstraOk.Visible = false;
        }

        // Var under test
        private void Forside_Click(object sender, EventArgs e)
        {
            
        }
    }
}
