using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogfester_Test
{
    public partial class Hohlprofil_R : Form
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



        public Hohlprofil_R()
        {
            InitializeComponent();
        }

        private void Hohlprofil_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult Warnung;
            try
            {
                Visible = false;
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

                Form AusgabeH = new AusgabeHohlprofil_R(Volumen, Querschnittsflaeche, Ib, It, Wb, Wt);
                AusgabeH.ShowDialog();



            }
            catch (Exception)
            {
                Warnung = MessageBox.Show("Die Textboxen '´Da', 'Di' oder 'L' enthalten keine oder falsche Angaben", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (Warnung == DialogResult.OK)
                {
                    this.Close();
                    Form Hohlprofil_R = new Hohlprofil_R();
                    Hohlprofil_R.ShowDialog();
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
