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
    public partial class RabatCheck : Form
    {
        // Testing - Rabat

        public bool rabat = false;

        public void Rabat()
        {
            if (antalPizza >= 2 && antalSoda >= 2 && rabat == false)
            {
                totalSum.Text = "Sum: " + sum.ToString() + "Kr.";
                rabatTxt.Text = "Rabat: " + iRabat + " Kr.";
                rabat = true;
                iRabat += 20;
            }
        }
    }
}
