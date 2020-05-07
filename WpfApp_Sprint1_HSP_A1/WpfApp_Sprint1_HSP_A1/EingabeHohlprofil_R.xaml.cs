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
    public partial class EingabeHohlprofil_R : Window
    {
        public string Volumen
        {
            get; private set;
        }

        public string Querschnittsflaeche
        {
            get; private set;
        }

        //Flächenträgheitsmoment Biegung
        public string Ib
        {
            get; private set;
        }

        //Biegewiderstandsmoment 
        public string Wb
        {
            get; private set;
        }

        //Flächenträgheitsmoment Torsion
        public string It
        {
            get; private set;
        }

        //Torsionswiderstandsmoment
        public string Wt
        {
            get; private set;
        }



        public EingabeHohlprofil_R()
        {
            InitializeComponent();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            try
            {

                Double Da, Di, L;

                Da = Convert.ToDouble(textBox1.Text.Replace(".", ","));
                Di = Convert.ToDouble(textBox2.Text.Replace(".", ","));
                L = Convert.ToDouble(textBox3.Text.Replace(".", ","));

                Volumen = String.Format("{0:0.00}", (Math.PI * (Math.Pow(Da, 2) - Math.Pow(Di, 2)) / 4 * L));

                Querschnittsflaeche = String.Format("{0:0.00}", (Math.PI * (Math.Pow(Da, 2) - Math.Pow(Di, 2)) / 4));

                //Flächenträgheitsmoment Biegung
                Ib = String.Format("{0:0.00}", (Math.PI * (Math.Pow(Da, 4) - Math.Pow(Di, 4)) / 64));

                //Biegewiderstandsmoment
                Wb = String.Format("{0:0.00}", (Math.PI * (Math.Pow(Da, 4) - Math.Pow(Di, 4)) / 32 * Da));


                //Flächenträgheitsmoment Torsion
                It = String.Format("{0:0.00}", (Math.PI * (Math.Pow(Da, 4) - Math.Pow(Di, 4)) / 32));

                //Torsionswiderstandsmoment
                Wt = String.Format("{0:0.00}", (Math.PI * (Math.Pow(Da, 4) - Math.Pow(Di, 4)) / 16 * Da));

                AusgabeHohlprofil_R AusgabeH = new AusgabeHohlprofil_R(Volumen, Querschnittsflaeche, Ib, It, Wb, Wt);
                AusgabeH.ShowDialog();

                this.Close();



            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Die Textboxen '´Da', 'Di' oder 'L' enthalten keine oder falsche Angaben", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow hauptmenu = new MainWindow();
            hauptmenu.Show();
            this.Close();
        }
    }
}
