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
    /// Interaktionslogik für Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private string KVolumen;
        private string KFlaeche;
        private string KSchwerpunktX;
        private string KSchwerpunktY;
        private string KSchwerpunktZ;
        private string KFLM2;
        private string KWDM;
        public Window2(string Flaeche, string Volumen, string SchwerpunktX, string SchwerpunktY, string SchwerpunktZ, string FLM2, string WDM)
        {
            InitializeComponent();

            KVolumen = Volumen;
            KFlaeche = Flaeche;
            KSchwerpunktX = SchwerpunktX;
            KSchwerpunktY = SchwerpunktY;
            KSchwerpunktZ = SchwerpunktZ;
            KFLM2 = FLM2;
            KWDM = WDM;

            Fläche.Text = KFlaeche;
            Volum.Text = KVolumen;
            SP_X.Text = KSchwerpunktX;
            FTM.Text = KFLM2;
            WTM.Text = KWDM;
            SP_Y.Text = KSchwerpunktY;
            SP_Z.Text = KSchwerpunktZ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 Kreis = new Window1();
            Kreis.Show();
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

        private void Fläche_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Volumen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SP_X_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SP_Y_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SP_Z_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FTM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void WTM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
