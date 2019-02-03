using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IvanRivas_CST117Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                string strWeightEarth = txtbox1_WeightOnEarth.Text;

                double weight = double.Parse(strWeightEarth);

                double WeightCancri55e = weight * 8.75;

                txtbox2_WeightOnCancri55e.Text = WeightCancri55e.ToString();



            }

            catch (Exception ex)
            {
                MessageBox.Show("Input must be a number.");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbox1_WeightOnEarth.Text = "";
            txtbox2_WeightOnCancri55e.Text = "";
        }
    }
}
