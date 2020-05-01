using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Sprint_1_HSP
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
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

        double Laenge, Breit, Dicke;
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow hauptmenu = new MainWindow();
            hauptmenu.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string L, B, D;
                L = Länge.Text;
                B = Breite.Text;
                D = Stärke.Text;

                Laenge = Convert.ToDouble(L.Replace(".", ","));
                Breit = Convert.ToDouble(B.Replace(".", ","));
                Dicke = Convert.ToDouble(D.Replace(".", ","));

                //Abruf Unterprogramm Fläche + Volumen
                Volumen = String.Format("{0:0.00}", (Laenge * Breit * Dicke));

                Flaeche = String.Format("{0:0.00}", (Laenge * Breit));

                //Abruf Unterprogramm Schwerpunkt X
                SchwerpunktX = String.Format("{0:0.00}", (Laenge / 2));

                //Abruf Unterprogramm Schwerpunkt Y 
                SchwerpunktY = String.Format("{0:0.00}", (Breit / 2));

                //Abruf Unterprogramm Schwerpunkt Z
                SchwerpunktZ = String.Format("{0:0.00}", (Dicke / 2));

                //Abruf Unterprogramm Flächenmoment X
                FLM2X = String.Format("{0:0.00}", ((Laenge * Math.Pow(Breit, 3)) / 12));

                //Abruf Unterprogramm Flächenmoment X
                FLM2Y = String.Format("{0:0.00}", ((Breit * Math.Pow(Laenge, 3)) / (12)));

                //Abruf Widerstandsmoment X
                WDMX = String.Format("{0:0.00}", ((Laenge * Math.Pow(Breit, 2)) / (6)));

                //Abruf Widerstandsmoment Y
                WDMY = String.Format("{0:0.00}", ((Breit * Math.Pow(Laenge, 2)) / (6)));

                Window2 AusgabeR = new Window2(Volumen, Flaeche, SchwerpunktX, SchwerpunktY, SchwerpunktZ, FLM2X, FLM2Y, WDMX, WDMY);
                AusgabeR.Show();

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Die Textboxen 'Länge', 'Breite' und 'Dicke' enthalten keine oder falsche Angaben", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
