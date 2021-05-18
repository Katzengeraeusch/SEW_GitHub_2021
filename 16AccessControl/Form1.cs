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
            try
            {
                int maxPersons = int.Parse(this.txtMaxPersons.Text);
                this.ac = new AccessControl(maxPersons);
                updateGUI();
            } catch(Exception ex)
            {
                //Eine Exception z.B. leerer String in Umwandlung wird hier behandelt
                //Wir tun hier nichts
            }
        }

        private void updateGUI()
        {
            this.txtCurrentPersons.Text = this.ac.CurrentCount.ToString();
            if(this.ac.CurrentCount <= 0)
            {
                //wir deaktivieren die Buttons zum verringern
                this.btnDecrement1.Enabled = false;
                this.btnDecrement.Enabled = false;
            }

            else
            {
                this.btnDecrement.Enabled = true;
                this.btnDecrement1.Enabled = true;
            }

            if (this.ac.canEnter())
            {
                this.btnIncrement1.Enabled = true;
                this.btnIncrement.Enabled = true;
                this.lbNoMorePersonsAllowed.Visible = false;
            }
            else
            {
                //maximale Anzahl an Personen erreicht
                this.btnIncrement1.Enabled = false;
                this.btnIncrement.Enabled = false;
                this.lbNoMorePersonsAllowed.Visible = true;
            }


        }

        private void btnIncrement1_Click(object sender, EventArgs e)
        {
            this.ac.Increment();
            updateGUI();
        }

        private void btnDecrement1_Click(object sender, EventArgs e)
        {
            this.ac.Decrement();
            updateGUI();
        }

        private void txtIncrement_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int input = int.Parse(this.txtIncrement.Text);
                if (this.ac.canEnter(input))
                {
                    this.btnIncrement.Enabled = true;
                }
                else
                {
                    this.btnIncrement.Enabled = false;
                }

            }catch(Exception ex)
            {

            }
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            try
            {
                int persons = int.Parse(this.txtIncrement.Text);
                this.ac.Increment(persons);
                this.txtIncrement.Text = "";    //Wir löschen die eingabe, um sicherzustellen dass der Button nicht 2x gedrückt wird
                updateGUI();
            }catch(Exception ex)
            {

            }
        }

        private void txtDecrement_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int input = int.Parse(this.txtIncrement.Text);
                if (this.ac.canEnter(input))
                {
                    this.btnIncrement.Enabled = true;
                }
                else
                {
                    this.btnIncrement.Enabled = false;
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
