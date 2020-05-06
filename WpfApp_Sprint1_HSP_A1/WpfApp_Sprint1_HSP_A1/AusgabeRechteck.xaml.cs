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
    /// Interaktionslogik für AusgabeRechteck.xaml
    /// </summary>
    public partial class AusgabeRechteck : Window
    {
        private string AVolumen;
        private string AFlaeche;
        private string ASchwerpunktX;
        private string ASchwerpunktY;
        private string ASchwerpunktZ;
        private string AFLM2X;
        private string AFLM2Y;
        private string AWDMX;
        private string AWDMY;
        public AusgabeRechteck(string Volumen, string Flaeche, string SchwerpunktX, string SchwerpunktY, string SchwerpunktZ, string FLM2X, string FLM2Y, string WDMX, string WDMY)
        {
            InitializeComponent();

            AVolumen = Volumen;
            AFlaeche = Flaeche;
            ASchwerpunktX = SchwerpunktX;
            ASchwerpunktY = SchwerpunktY;
            ASchwerpunktZ = SchwerpunktZ;
            AFLM2X = FLM2X;
            AFLM2Y = FLM2Y;
            AWDMX = WDMX;
            AWDMY = WDMY;

            Fläche.Text = AFlaeche;
            Volumentxt.Text = AVolumen;
            SchwerpunktXtxt.Text = ASchwerpunktX;
            FlächenmomentXtxt.Text = AFLM2X;
            FlächenmomentYtxt.Text = AFLM2Y;
            WiderstandXtxt.Text = AWDMX;
            WiderstandYtxt.Text = AWDMY;
            SchwerpunktYtxt.Text = ASchwerpunktY;
            SchwerpunktZtxt.Text = ASchwerpunktZ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EingabeRechteck Rechteck = new EingabeRechteck();
            Rechteck.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow Main = new MainWindow();
            Main.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DialogResult quit1 = System.Windows.Forms.MessageBox.Show("Möchten Sie das Programm beenden?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (quit1 == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
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

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_6(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_7(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_8(object sender, TextChangedEventArgs e)
        {

        }
    }
}
