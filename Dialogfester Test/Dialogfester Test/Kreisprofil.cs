using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogfester_Test
{
    public partial class Kreisprofil : Form
    {
        public string Volumen
        {
            get; private set;
        }

        public string Flaeche
        {
            get; private set;
        }

        public string SchwerpunktX
        {
            get; private set;
        }

        public string SchwerpunktY
        {
            get; private set;
        }

        public string SchwerpunktZ
        {
            get; private set;
        }

        public string FLM2
        {
            get; private set;
        }

     

        public string WDM
        {
            get; private set;
        }

        

        double Durchmesser, Laenge;
        public Kreisprofil()
        {
            InitializeComponent();
        }

        private void Kreis_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Warnung;
            try
            {
                Visible = false;
                string D, L;
                
                D = textBox1.Text;
                L = textBox2.Text;
                

                Durchmesser = Convert.ToDouble(D.Replace(".", ","));
                Laenge = Convert.ToDouble(L.Replace(".", ","));
                

                //Abruf Unterprogramm Fläche + Volumen
                Volumen = String.Format("{0:0.00}", ((Laenge* Math.PI* Math.Pow(Durchmesser,2)/4)));

                Flaeche = String.Format("{0:0.00}", ((Math.PI*Math.Pow(Durchmesser,2)/4)));

                //Abruf Unterprogramm Schwerpunkt X
                SchwerpunktX = String.Format("{0:0.00}", (0));

                //Abruf Unterprogramm Schwerpunkt Y 
                SchwerpunktY = String.Format("{0:0.00}", (0));

                //Abruf Unterprogramm Schwerpunkt Z
                SchwerpunktZ = String.Format("{0:0.00}", (Laenge / 2));

                //Abruf Unterprogramm Flächenmoment 
                FLM2 = String.Format("{0:0.00}", ((Math.PI * Math.Pow(Durchmesser, 3)) / 64));

               
                //Abruf Widerstandsmoment X
                WDM = String.Format("{0:0.00}", ((Math.PI * Math.Pow(Durchmesser, 3)) / (32)));

               

                Form AusgabeK = new AusgabeKreis(Volumen, Flaeche, SchwerpunktX, SchwerpunktY, SchwerpunktZ, FLM2, WDM);
                AusgabeK.ShowDialog();
            }
            catch (Exception)
            {
                Warnung = MessageBox.Show("Die Textboxen 'Durchmesser' und 'Länge' enthalten keine oder falsche Angaben", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (Warnung == DialogResult.OK)
                {
                    this.Close();
                    Form Kreis = new Kreisprofil();
                    Kreis.ShowDialog();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Kreisprofil_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
