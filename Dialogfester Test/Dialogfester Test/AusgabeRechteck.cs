using System;
using System.Windows.Forms;

namespace Dialogfester_Test
{
    public partial class AusgabeRechteck : Form
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


        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            DialogResult quit1 = MessageBox.Show("Möchten Sie das Programm beenden?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (quit1 == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public void AusgabeRechteck_Load(object sender, EventArgs e)
        {
            txtFlaeche.Text = AFlaeche;
            textBox2.Text = AVolumen;
            textBox3.Text = ASchwerpunktX;
            textBox4.Text = AFLM2X;
            textBox5.Text = AFLM2Y;
            textBox6.Text = AWDMX;
            textBox7.Text = AWDMY;
            textBox8.Text = ASchwerpunktY;
            textBox9.Text = ASchwerpunktZ;
        }

        public void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
