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
        private int nrOfExercises = 0;
        private int i;
        private int nrOfTries = 0;
        private int correctAnswers = 0;
        private int currentExcercise = 0;
        private int range = 0;
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
                    this.correctAnswers++;
                    this.currentExcercise++;
                    this.txtErgebnis.Text = "";
                } else
                {
                    // Falsche Antwort
                    this.nrOfTries++;
                    this.lbWrongRight.Text = "Nochmal probieren!";
                    if (this.nrOfTries > 1)
                    {
                        this.txtErgebnis.Text = "";
                        this.i++;
                        this.lbCalcuate.Text = this.formExercises[i].excercise();
                        this.nrOfTries = 0;
                        this.lbWrongRight.Text = "Falsch!";
                        this.currentExcercise++;
                      
                    }
                }
                
                
                if(this.currentExcercise == this.nrOfExercises)
                {
                    this.lbCalcuate.Visible = false;
                    statistik();
                }
                
            }
            catch(Exception ex)
            {

            }
            
        }

        private void startTraininig_Click(object sender, EventArgs e)
        {
            this.nrOfExercises = int.Parse(this.txtNrOfCalculations.Text);
            this.range = int.Parse(this.txtRange.Text);
            //MTFactory Objekt erstellen
            //getExercises Property erstellen um Aufgaben auf zurufen
            MatheTrainerFactory mtf = new MatheTrainerFactory();
            mtf.createTraining(this.nrOfExercises + 1, this.range);
            this.formExercises = mtf.Exercises;
            this.i = 0;
            this.lbCalcuate.Text = this.formExercises[i].excercise();
            this.startTraininig.Visible = false;
            this.lbCalcuate.Visible = true;
            this.lbWrongRight.Visible = true;
            this.txtErgebnis.Visible = true;
            this.button1.Visible = true;
            this.txtRange.Visible = false;
            this.txtNrOfCalculations.Visible = false;
            this.lbRange.Visible = false;
            this.lbNrOfCalculations.Visible = false;
            
        }

        public void statistik()
        {
            this.lbStatistik.Text = "Alle Aufgaben erledigt!" + "\r\n" + this.correctAnswers.ToString() + " Aufgaben sind richtig";
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

        private void lbStatistik_Click(object sender, EventArgs e)
        {

        }
    }
}
