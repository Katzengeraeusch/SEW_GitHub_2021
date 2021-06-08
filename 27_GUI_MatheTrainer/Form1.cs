using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_GUI_MatheTrainer
{
    public partial class Form1 : Form
    {
        private MatheTrainer[] formExercises;
        private int nrOfExercises = 10;
        private int i;
        private int nrOfTries = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = int.Parse(this.txtErgebnis.Text);

                if (result == this.formExercises[this.i].getResult())
                {
                    //Richtige Antwort
                    this.i++;
                    this.lbCalcuate.Text = this.formExercises[i].excercise();
                    this.nrOfTries = 0;
                    this.lbWrongRight.Text = "Richtig!";
                } else
                {
                    // Falsche Antwort
                    this.nrOfTries++;
                    this.lbWrongRight.Text = "Nochmal probieren!";
                    if(this.nrOfTries > 1)
                    {
                        this.txtErgebnis.Text = "";
                        this.i++;
                        this.lbCalcuate.Text = this.formExercises[i].excercise();
                        this.nrOfTries = 0;
                        this.lbWrongRight.Text = "Falsch!";
                    }
                }
                
            }
            catch(Exception ex)
            {

            }
            
        }

        private void startTraininig_Click(object sender, EventArgs e)
        {
            //MTFactory Objekt erstellen
            //getExercises Property erstellen um Aufgaben auf zurufen
            MatheTrainerFactory mtf = new MatheTrainerFactory();
            mtf.createTraining(this.nrOfExercises, 100);
            this.formExercises = mtf.Exercises;
            this.i = 0;
            this.lbCalcuate.Text = this.formExercises[i].excercise();
            this.startTraininig.Visible = false;
            this.lbCalcuate.Visible = true;
            this.lbWrongRight.Visible = true;
            this.txtErgebnis.Visible = true;
            this.button1.Visible = true;
            
        }


        private void btnShowCalculation_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbCalcuate_Click(object sender, EventArgs e)
        {

        }
    }
}
