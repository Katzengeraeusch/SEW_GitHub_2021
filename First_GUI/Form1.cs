using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Wenn Btn gedrückt wird, wird genau diese Methode aufgrufen
            this.txtHelloWorld.Text = "Hello World!!!";
        }

        private void btnPlsClickMe_Click_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;  //Koversion von object in Button
            Random rand = new Random();
            int widthOfForm = this.FindForm().Size.Width;
            int heigthOfForm = this.FindForm().Size.Height;

            int x = rand.Next(widthOfForm-b.Size.Width); //Breite vom Fenster - Breite vom Button, damit dieser auch wirklich sichtbar bleibt
            int y = rand.Next(heigthOfForm - b.Size.Height); //Höhe vom Fenster - Höhe vom Button, damit dieser auch wirklich sichtbar bleibt;
        }
    }
}
