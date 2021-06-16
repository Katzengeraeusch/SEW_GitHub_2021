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
        private MatheTrainer[] formExcercises;
        private int nrOfExcercises = 0;
        private int i=0;
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

                if (result == this.formExcercises[i].getResult())
                {
                    // richtige Antwort
                    this.correctAnswers++;
                    this.lbWrongRight.Text = "Richtiges Ergebnis!";
                }
                else
                {
                    // falsche Antwort
                    this.lbWrongRight.Text = "Falsche Antwort! Bitte nochmals probieren!";
                    this.lbCalcuate.Text = this.formExcercises[i].excercise();
                    result = int.Parse(this.txtErgebnis.Text);
                    // Überprüfung der 2. Antwort
                    if (result == this.formExcercises[i].getResult())
                    {
                        this.correctAnswers++;
                        this.lbWrongRight.Text = "Richtiges Ergebnis!";
                    }
                    else
                    {
                        this.lbWrongRight.Text = "Leider Falsch!";
                    }
                }

                this.lbCalcuate.Text = this.formExcercises[i].excercise();
                

                if (this.i == this.nrOfExcercises)
                {
                    statistik();
                }
                i++;

            }
            catch(Exception ex)
            {

            }
            
        }

        private void startTraininig_Click(object sender, EventArgs e)
        {
            this.nrOfExcercises = int.Parse(this.txtNrOfCalculations.Text);
            this.range = int.Parse(this.txtRange.Text);
            //MTFactory Objekt erstellen
            //getExercises Property erstellen um Aufgaben auf zurufen
            MatheTrainerFactory mtf = new MatheTrainerFactory();
            mtf.createTraining(this.nrOfExcercises+1, this.range);
            this.formExcercises = mtf.Exercises;
            this.i = 1;
            this.lbCalcuate.Text = this.formExcercises[i].excercise();
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
