using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_prac4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declaring constants outside event handlers
        // To use them on multiple event handlers.
        const decimal EARTH_GRAVITY = 9.81m;
        const decimal MOON_GRAVITY = 1.62m;
        const decimal MARS_GRAVITY = 3.73m;
        const decimal JUPITER_GRAVITY = 24.79m;

        private void btnMoon_Click(object sender, EventArgs e)
        {
            // Allowing user input.
            decimal weightOnEarth = nudWeightEarth.Value;

            // Processing -> Calculations.
            decimal weightOnMoon = weightOnEarth * MOON_GRAVITY / EARTH_GRAVITY;

            // Displaying outputs.
            MessageBox.Show("Your weight on the Moon is: " + Math.Round(weightOnMoon, 2).ToString());
        }

        private void btnMars_Click(object sender, EventArgs e)
        {
            // Allowing user input.
            decimal weightOnEarth = nudWeightEarth.Value;

            // Processing -> Calculations.
            decimal weightOnMars = weightOnEarth * MARS_GRAVITY / EARTH_GRAVITY;

            // Displaying outputs.
            MessageBox.Show("Your weight on Mars is: " + Math.Round(weightOnMars, 2).ToString());
        }

        private void btnJupiter_Click(object sender, EventArgs e)
        {
            // Allowing user input.
            decimal weightOnEarth = nudWeightEarth.Value;

            // Processing -> Calculations.
            decimal weightOnJupiter = weightOnEarth * JUPITER_GRAVITY / EARTH_GRAVITY;

            // Displaying outputs.
            MessageBox.Show("Your weight on Jupiter is: " + Math.Round(weightOnJupiter, 2).ToString());
        }
    }
}
