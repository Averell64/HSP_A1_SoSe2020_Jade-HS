using System;
using System.Windows.Forms;

namespace Dialogfester_Test
{
    public partial class AusgabeKreis : Form
    {
        private string KVolumen;
        private string KFlaeche;
        private string KSchwerpunktX;
        private string KSchwerpunktY;
        private string KSchwerpunktZ;
        private string KFLM2;
        private string KWDM;


        public AusgabeKreis(string Volumen, string Flaeche, string SchwerpunktX, string SchwerpunktY, string SchwerpunktZ, string FLM2, string WDM)
        {
            InitializeComponent();
            KVolumen = Volumen;
            KFlaeche = Flaeche;
            KSchwerpunktX = SchwerpunktX;
            KSchwerpunktY = SchwerpunktY;
            KSchwerpunktZ = SchwerpunktZ;
            KFLM2 = FLM2;
            KWDM = WDM;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult quit1 = MessageBox.Show("Möchten Sie das Programm beenden?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (quit1 == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }






        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AusgabeKreis_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = KFlaeche;
            textBox2.Text = KVolumen;
            textBox3.Text = KSchwerpunktX;
            textBox4.Text = KSchwerpunktY;
            textBox5.Text = KSchwerpunktZ;
            textBox6.Text = KFLM2;
            textBox7.Text = KWDM;
        }
    }
}
