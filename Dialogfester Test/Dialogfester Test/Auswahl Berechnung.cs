using System;
using System.Windows.Forms;

namespace Dialogfester_Test
{
    public partial class Auswahl_Berechnung : Form
    {
        public Auswahl_Berechnung()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Rechteck frmRechteck = new Rechteck();
            frmRechteck.ShowDialog();
        }
        public void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            Kreisprofil frmKreis = new Kreisprofil();
            frmKreis.ShowDialog();
            
        }
        public void button3_Click(object sender, EventArgs e)
        {
            Visible = false;
            Hohlprofil_R frmHohlprofil_R = new Hohlprofil_R();
            frmHohlprofil_R.ShowDialog();

        }
        public void button4_Click(object sender, EventArgs e)
        {

        }
        public void button5_Click(object sender, EventArgs e)
        {
            DialogResult quit1 = MessageBox.Show("Möchten Sie das Programm beenden?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (quit1 == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }
        private void Auswahl_Berechnung_Load(object sender, EventArgs e)
        {

        }
    }
}
