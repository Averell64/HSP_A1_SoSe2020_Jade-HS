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

        public string FLM2
        {
            get; private set;
        }


        double Durchm, Laenge;
        public string WDM
        {
            get; private set;
        }
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

            try
            {
               
                string D, L;

                D = Durchmesser.Text;
                L = Länge.Text;

                Durchm = Convert.ToDouble(D.Replace(".", ","));
                Laenge = Convert.ToDouble(L.Replace(".", ","));
                

                //Abruf Unterprogramm Fläche + Volumen
                Volumen = String.Format("{0:0.00}", ((Laenge * Math.PI * Math.Pow(Durchm, 2) / 4)));

                Flaeche = String.Format("{0:0.00}", ((Math.PI * Math.Pow(Durchm, 2) / 4)));

                //Abruf Unterprogramm Schwerpunkt X
                SchwerpunktX = String.Format("{0:0.00}", (0));

                //Abruf Unterprogramm Schwerpunkt Y 
                SchwerpunktY = String.Format("{0:0.00}", (0));

                //Abruf Unterprogramm Schwerpunkt Z
                SchwerpunktZ = String.Format("{0:0.00}", (Laenge / 2));

                //Abruf Unterprogramm Flächenmoment 
                FLM2 = String.Format("{0:0.00}", ((Math.PI * Math.Pow(Durchm, 3)) / 64));


                //Abruf Widerstandsmoment X
                WDM = String.Format("{0:0.00}", ((Math.PI * Math.Pow(Durchm, 3)) / (32)));


                Window2 AusgabeK = new Window2(Volumen, Flaeche, SchwerpunktX, SchwerpunktY, SchwerpunktZ, FLM2, WDM);
                AusgabeK.Show();

                this.Close();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Die Textboxen 'Durchmesser' und 'Länge' enthalten keine oder falsche Angaben", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
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
    }
    }

