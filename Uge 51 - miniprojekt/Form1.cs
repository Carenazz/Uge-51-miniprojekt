using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uge_51___miniprojekt
{
    public partial class DashboardForm : Form
    {
        #region Dashboard
        public DashboardForm()
        {
            InitializeComponent();
        }
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
            MessageBox.Show("Bestillingen er modtaget");
        }

        #endregion

        #region Kurven
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Knapper som tilføjer til kurv og tilføjer sum.

        // Samlet sum int
        int sum = 0;

        // Pepperoni alm.
        private void button2_Click(object sender, EventArgs e)
        {
            // Første label = pizza. Combobox = dej valg. midt label = størrelsen. Sidste label = pris. (Gælder for alle nedenstående voids).
            string[] row = { Pepperoni.Text + " - " + comboBox1.SelectedItem + " - " + AlmPepp.Text + " " + PeppAPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            // Udregning af pris + visning af pris
            sum += 55;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            // test til at adde en "-" knap.
            DynamiskFortrydKnap(sender, e);
        }

        // Pepperoni fam.
        private void button3_Click(object sender, EventArgs e)
        {
            string[] row = { Pepperoni.Text + " - " + comboBox1.SelectedItem + " - " + FamPepp.Text + " " + PeppFPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 105;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            DynamiskFortrydKnap(sender, e);
        }
        
        private void Alm_Skinke_Click(object sender, EventArgs e)
        {
            string[] row = { Skinke.Text + " - " + comboBox2.SelectedItem + " - " + AlmSkinke.Text + " " + SkinkeAPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 55;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            DynamiskFortrydKnap(sender, e);
        }

        private void Fam_Skinke_Click(object sender, EventArgs e)
        {
            string[] row = { Skinke.Text + " - " + comboBox2.SelectedItem + " - " + SkinkeFam.Text + " " + SkinkeFPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 105;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            DynamiskFortrydKnap(sender, e);
        }

        private void Alm_Hawaii_Click(object sender, EventArgs e)
        {
            string[] row = { Hawaii.Text + " - " + comboBox3.SelectedItem + " - " + AlmHawaii.Text + " " + HawaiiAPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 65;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            DynamiskFortrydKnap(sender, e);
        }

        private void Fam_Hawaii_Click(object sender, EventArgs e)
        {
            string[] row = { Hawaii.Text + " - " + comboBox3.SelectedItem + " - " + HawaiiFam.Text + " " + HawaiiFPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 115;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            DynamiskFortrydKnap(sender, e);
        }

        private void Alm_DinEgen_Click(object sender, EventArgs e)
        {
            string[] row = { LavDinEgen.Text + " - " + comboBox4.SelectedItem + " - " + LavAlm.Text + " " + LavAPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 50;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            DynamiskFortrydKnap(sender, e);
        }

        private void Fam_DinEgen_Click(object sender, EventArgs e)
        {
            string[] row = { LavDinEgen.Text + " - " + comboBox4.SelectedItem + " - " + LavFam.Text + " " + LavFamPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 100;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            DynamiskFortrydKnap(sender, e);
        }


        // Ingredienser
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] rowExtra = { IngredienserList.SelectedItem.ToString() };
            var listViewItem = new ListViewItem(rowExtra);
            KurvListe.Items.Add(listViewItem);
            sum += 5;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            DynamiskFortrydKnap(sender, e);
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

            DynamiskFortrydKnap(sender, e);
        }

        // Størrelsen på sodavand.
        private void button2_Click_1(object sender, EventArgs e)
        {
            string[] row = { LilleCola.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 15;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            DynamiskFortrydKnap(sender, e);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string[] row = { MellemCola.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 20;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            DynamiskFortrydKnap(sender, e);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] row = { StorCola.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 25;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";

            DynamiskFortrydKnap(sender, e);
        }

        #endregion

        #region Fortryd knap.

        // Kode test for dynamisk knap (Void Tester).
        int removeIndex = -1, deleteButton = -1;
        void RemoveButton_Click(object sender, EventArgs e)
        {
            // Kode til at fjerne index ved specifikt spot (Test)
            KurvListe.Items.RemoveAt(0 + removeIndex);
            removeIndex -= 1;
            // Kode for at fjerne knappen når den er trykket på.
            KurvListe.Controls.RemoveAt(0 + deleteButton);
            deleteButton -= 1;
            // Hvis knappen rammer standard (-1) resetter den yAdd (For at undgå fejl indtil videre)
            if (deleteButton == -1)
            {
                yAdd = 0;
            }
            // Her kommer kode til at holde øje med hvilket indeks som bliver fjernet (Under test)
            if (KurvListe.Name == "Alm_Pepperoni")
            {
                sum -= 55;
            }
            else if (KurvListe.Name == "Fam_Pepperoni")
            {
                sum -= 105;
            }
        }

        // Knap position
        int yAdd = 0;

        // Dynamisk knap til fortrydelse.
        private void DynamiskFortrydKnap(object sender, EventArgs e)
        {
            // Kode for at lave en knap.
            List<Button> buttons = new List<Button>();
            Button removeButton = new Button();
            buttons.Add(removeButton);
            // Kode for text, lokation og størrelse.
            removeButton.Name = "Undo";
            removeButton.Text = "-";
            removeButton.Location = new Point(180, 0 + yAdd);
            removeButton.Size = new Size(17, 17);
            // Hvilken kode skal den nye knap følge og tilføje knappen til kurven når koden bliver kørt.
            removeButton.Click += new EventHandler(RemoveButton_Click);
            KurvListe.Controls.Add(removeButton);
            // Sætter den næste knap på næste del af "y-aksen" som set på "location"
            yAdd += 17;
            removeIndex += 1;
            // Holder øje med hvor næste knap er
            deleteButton += 1;
        }

        #endregion
    }
}
