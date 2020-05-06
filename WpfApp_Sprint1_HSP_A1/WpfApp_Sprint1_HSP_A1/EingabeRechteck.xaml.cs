using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp_Sprint1_HSP_A1
{
    /// <summary>
    /// Interaktionslogik für EingabeRechteck.xaml
    /// </summary>
    public partial class EingabeRechteck : Window
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
        public EingabeRechteck()
        {
            InitializeComponent();
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

                AusgabeRechteck AusgabeR = new AusgabeRechteck(Volumen, Flaeche, SchwerpunktX, SchwerpunktY, SchwerpunktZ, FLM2X, FLM2Y, WDMX, WDMY);
                AusgabeR.Show();

                this.Close();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Die Textboxen 'Länge', 'Breite' und 'Dicke' enthalten keine oder falsche Angaben", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow hauptmenu = new MainWindow();
            hauptmenu.Show();
            this.Close();
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
    }
}
