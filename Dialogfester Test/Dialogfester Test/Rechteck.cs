using System;
using System.Windows.Forms;

namespace Dialogfester_Test
{
    public partial class Rechteck : Form
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

        public string FLM2X
        {
            get; private set;
        }

        public string FLM2Y
        {
            get; private set;
        }

        public string WDMX
        {
            get; private set;
        }

        public string WDMY
        {
            get; private set;
        }

        double Laenge, Breite, Dicke;
        public Rechteck()
        {
            InitializeComponent();
        }

        private void Rechteck_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Warnung;
            try
            {
                Visible = false;
                string L, B, D;
                L = textBox1.Text;
                B = textBox2.Text;
                D = textBox3.Text;

                Laenge = Convert.ToDouble(L.Replace(".", ","));
                Breite = Convert.ToDouble(B.Replace(".", ","));
                Dicke = Convert.ToDouble(D.Replace(".", ","));

                //Abruf Unterprogramm Fläche + Volumen
                Volumen = String.Format("{0:0.00}", (Laenge * Breite * Dicke));

                Flaeche = String.Format("{0:0.00}", (Laenge * Breite));

                //Abruf Unterprogramm Schwerpunkt X
                SchwerpunktX = String.Format("{0:0.00}", (Laenge / 2));

                //Abruf Unterprogramm Schwerpunkt Y 
                SchwerpunktY = String.Format("{0:0.00}", (Breite / 2));

                //Abruf Unterprogramm Schwerpunkt Z
                SchwerpunktZ = String.Format("{0:0.00}", (Dicke / 2));

                //Abruf Unterprogramm Flächenmoment X
                FLM2X = String.Format("{0:0.00}", ((Laenge * Math.Pow(Breite, 3)) / 12));

                //Abruf Unterprogramm Flächenmoment X
                FLM2Y = String.Format("{0:0.00}", ((Breite * Math.Pow(Laenge, 3)) / (12)));

                //Abruf Widerstandsmoment X
                WDMX = String.Format("{0:0.00}", ((Laenge * Math.Pow(Breite, 2)) / (6)));

                //Abruf Widerstandsmoment Y
                WDMY = String.Format("{0:0.00}", ((Breite * Math.Pow(Laenge, 2)) / (6)));

                Form AusgabeR = new AusgabeRechteck(Volumen, Flaeche, SchwerpunktX, SchwerpunktY, SchwerpunktZ, FLM2X, FLM2Y, WDMX, WDMY);
                AusgabeR.ShowDialog();
            }
            catch (Exception)
            {
                Warnung = MessageBox.Show("Die Textboxen 'Länge', 'Breite' und 'Dicke' enthalten keine oder falsche Angaben", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (Warnung == DialogResult.OK)
                {
                    this.Close();
                    Form Rechteck = new Rechteck();
                    Rechteck.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
