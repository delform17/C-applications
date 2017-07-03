using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckboxApplet
{
    public partial class CheckYourCar : Form
    {
        public CheckYourCar()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Model1");
            comboBox1.Items.Add("Model2");
            comboBox1.Items.Add("Model3");
            comboBox1.Items.Add("Model4");
            
        }
    }
}
