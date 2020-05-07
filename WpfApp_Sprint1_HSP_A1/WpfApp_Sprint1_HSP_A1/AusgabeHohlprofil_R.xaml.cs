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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Sprint1_HSP_A1
{
    /// <summary>
    /// Interaktionslogik für AusgabeHohlprofil_R.xaml
    /// </summary>
    public partial class AusgabeHohlprofil_R : Window
    {
        string V, A, Ibxy, Wbxy, Itxy, Wtxy;

      
        public AusgabeHohlprofil_R(string Volumen, string Querschnittsflaeche, string Ib, string Wb, string It, string Wt)
        {
            InitializeComponent();
            V = Volumen;
            A = Querschnittsflaeche;
            Ibxy = Ib;
            Wbxy = Wb;
            Itxy = It;
            Wtxy = Wt;

            textBox1.Text = V;
            textBox2.Text = A;
            textBox3.Text = Ibxy;
            textBox4.Text = Wbxy;
            textBox5.Text = Itxy;
            textBox6.Text = Wtxy;
        }
      
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult quit1 = System.Windows.Forms.MessageBox.Show("Möchten Sie das Programm beenden?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (quit1 == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Main = new MainWindow();
            Main.Show();
            this.Close();
        }
    }
}
