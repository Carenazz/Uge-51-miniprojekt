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
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

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

        // BestillingsKnap
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bestillingen er modtaget");
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Knapper som tilføjer til kurv og tilføjer sum.
        // Pepperoni alm.

        int sum = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            // Tester
            // Første label = pizza. Combobox = dej valg. midt label = størrelsen. Sidste label = pris. (Gælder for alle nedenstående voids).
            string[] row = { Pepperoni.Text + " - " + comboBox1.SelectedItem + " - " + AlmPepp.Text + " " + PeppAPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            // Udregning af pris + visning af pris
            sum += 55;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }

        // Pepperoni fam.
        private void button3_Click(object sender, EventArgs e)
        {
            string[] row = { Pepperoni.Text + " - " + comboBox1.SelectedItem + " - " + FamPepp.Text + " " + PeppFPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 105;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }
        
        private void Alm_Skinke_Click(object sender, EventArgs e)
        {
            string[] row = { Skinke.Text + " - " + comboBox2.SelectedItem + " - " + AlmSkinke.Text + " " + SkinkeAPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 55;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }

        private void Fam_Skinke_Click(object sender, EventArgs e)
        {
            string[] row = { Skinke.Text + " - " + comboBox2.SelectedItem + " - " + SkinkeFam.Text + " " + SkinkeFPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 105;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }

        private void Alm_Hawaii_Click(object sender, EventArgs e)
        {
            string[] row = { Hawaii.Text + " - " + comboBox3.SelectedItem + " - " + AlmHawaii.Text + " " + HawaiiAPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 65;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }

        private void Fam_Hawaii_Click(object sender, EventArgs e)
        {
            string[] row = { Hawaii.Text + " - " + comboBox3.SelectedItem + " - " + HawaiiFam.Text + " " + HawaiiFPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 115;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }

        private void Alm_DinEgen_Click(object sender, EventArgs e)
        {
            string[] row = { LavDinEgen.Text + " - " + comboBox4.SelectedItem + " - " + LavAlm.Text + " " + LavAPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 50;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }

        private void Fam_DinEgen_Click(object sender, EventArgs e)
        {
            string[] row = { LavDinEgen.Text + " - " + comboBox4.SelectedItem + " - " + LavFam.Text + " " + LavFamPris.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 100;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }


        // Ingredienser
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] rowExtra = { IngredienserList.SelectedItem.ToString() };
            var listViewItem = new ListViewItem(rowExtra);
            KurvListe.Items.Add(listViewItem);
            sum += 5;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }
        #endregion

        #region Drikkevarer

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] row = { listBox2.SelectedItem.ToString() };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            string[] row = { LilleCola.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 15;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string[] row = { MellemCola.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 20;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] row = { StorCola.Text };
            var listViewItem = new ListViewItem(row);
            KurvListe.Items.Add(listViewItem);
            sum += 25;
            totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
        }

        #endregion
    }
}
