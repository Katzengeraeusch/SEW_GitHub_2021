using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _28ImageBrowser
{
    public partial class Form1 : Form
    {
        private string[] lines;
        private int currentImage = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.ofdImage.ShowDialog() == DialogResult.OK)   //Nur weiter machen wenn der Benutzer Ok Klickt
            {
                try
                {
                    string fileName = this.ofdImage.FileName;       // Multiselect --> False
                    this.lines = File.ReadAllLines(fileName);   // using System.IO          
                    this.lbFileLoaded.Text = fileName;
                    this.pbImage.ImageLocation = lines[0];
                    this.btnNext.Enabled = true;
                    this.currentImage++;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.StackTrace, "Fehler beim Dateizugriff");    //ex.StackTrace liefert Fehlerinformation
                }


            }
         }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int nrOfImages = this.lines.Length;
            if(this.currentImage > nrOfImages)
            {
                this.currenImage = 0;
                //weitere Möglichkeit --> Button disablen
            }
            this.pbImage.ImageLocation = this.lines[currentImage];
            this.currentImage++;
        }
    }
}
