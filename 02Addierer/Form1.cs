using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Addierer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int summand1 = int.Parse(this.txtSummand1.Text);
            int summand2 = int.Parse(this.txtSummand2.Text);
            int summe = summand1 + summand2;
            this.txtSumme.Text = summe.ToString();
        }

        private void txtSummand1_TextChanged(object sender, EventArgs e)
        {
            this.txtSumme.Text = "";
        }

        private void txtSummand2_TextChanged(object sender, EventArgs e)
        {
            this.txtSumme.Text = "";
        }
    }
}
