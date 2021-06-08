using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HU_Contact_Tracing
{
    public partial class Form1 : Form
    {
        ContactTracing ct = new ContactTracing();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtPersonList.Text = this.txtPersonList.Text + this.txtFirstName.Text.Trim().ToString() + " " + this.txtLastName.Text.Trim().ToString() + "\r\n";
                this.txtFirstName.Text = "";
                this.txtLastName.Text = "";
                updateGUI();
            }
            catch (Exception ex)
            {

            }
        }

        private void updateGUI()
        {
            ct.addPerson();
            this.lbCurrentPersons.Text = ct.PersonCount.ToString() + " Personen sind anwesend";
        }

        private void btnDelList_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtPersonList.Text = "";
                this.lbCurrentPersons.Text = "0 Personen sind anwesend";
                ct.PersonCount = 0;
            }
            catch(Exception ex)
            {

            }
        }
    }
}
