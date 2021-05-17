using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16AccessControl
{
    public partial class Form1 : Form
    {
        private AccessControl ac;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int maxPersons = int.Parse(this.txtMaxPersons.Text);
            this.ac = new AccessControl(maxPersons);
            updateGUI();
        }

        private void updateGUI()
        {
            this.txtCurrentPersons.Text = this.ac.CurrentCount.ToString();
        }
    }
}
