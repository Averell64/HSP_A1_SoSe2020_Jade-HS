using System.Windows;
using System.Windows.Forms;

namespace Sprint_1_HSP
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 frmRechteck = new Window1();
            frmRechteck.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DialogResult quit1 = System.Windows.Forms.MessageBox.Show("Möchten Sie das Programm beenden?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (quit1 == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
