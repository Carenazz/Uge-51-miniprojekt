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

        #region Knapper som tilføjer til kurv
        // Pepperoni alm.
        private void button2_Click(object sender, EventArgs e)
        {
            // Tester
            // Første label = pizza. Combobox = dej valg. Sidste label = størrelsen (Og pris). Gælder for alle nedenstående voids.
            string[] row = { label1.Text + " - " + comboBox1.SelectedItem + " - " + label2.Text };
            var listViewItem = new ListViewItem(row);
            listView2.Items.Add(listViewItem);
        }

        // Pepperoni fam.
        private void button3_Click(object sender, EventArgs e)
        {
            string[] row = { label1.Text + " - " + comboBox1.SelectedItem + " - " + label3.Text };
            var listViewItem = new ListViewItem(row);
            listView2.Items.Add(listViewItem);
        }
        
        private void Alm_Skinke_Click(object sender, EventArgs e)
        {
            string[] row = { label4.Text + " - " + comboBox2.SelectedItem + " - " + label5.Text };
            var listViewItem = new ListViewItem(row);
            listView2.Items.Add(listViewItem);
        }

        private void Fam_Skinke_Click(object sender, EventArgs e)
        {
            string[] row = { label4.Text + " - " + comboBox2.SelectedItem + " - " + label6.Text };
            var listViewItem = new ListViewItem(row);
            listView2.Items.Add(listViewItem);
        }

        private void Alm_Hawaii_Click(object sender, EventArgs e)
        {
            string[] row = { label7.Text + " - " + comboBox3.SelectedItem + " - " + label8.Text };
            var listViewItem = new ListViewItem(row);
            listView2.Items.Add(listViewItem);
        }

        private void Fam_Hawaii_Click(object sender, EventArgs e)
        {
            string[] row = { label7.Text + " - " + comboBox3.SelectedItem + " - " + label9.Text };
            var listViewItem = new ListViewItem(row);
            listView2.Items.Add(listViewItem);
        }

        private void Alm_DinEgen_Click(object sender, EventArgs e)
        {
            string[] row = { label10.Text + " - " + comboBox4.SelectedItem + " - " + label11.Text };
            var listViewItem = new ListViewItem(row);
            listView2.Items.Add(listViewItem);
        }

        private void Fam_DinEgen_Click(object sender, EventArgs e)
        {
            string[] row = { label10.Text + " - " + comboBox4.SelectedItem + " - " + label12.Text };
            var listViewItem = new ListViewItem(row);
            listView2.Items.Add(listViewItem);
        }
        #endregion

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] rowExtra = { listBox1.SelectedItem.ToString() };
            var listViewItem = new ListViewItem(rowExtra);
            listView2.Items.Add(listViewItem);
        }
    }
}
