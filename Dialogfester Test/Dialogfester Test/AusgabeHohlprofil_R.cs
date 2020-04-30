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
    public partial class AusgabeHohlprofil_R : Form
    {
        string V, A, Ibxy, Wbxy, Itxy, Wtxy;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public AusgabeHohlprofil_R(string Volumen, string Querschnittsflaeche, string Ib, string Wb, string It, string Wt)
        {
            InitializeComponent();
            V = Volumen;
            A = Querschnittsflaeche;
            Ibxy = Ib;
            Wbxy = Wb;
            Itxy = It;
            Wtxy = Wt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult quit1 = MessageBox.Show("Möchten Sie das Programm beenden?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quit1 == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }

        }
        public void AusgabeHohlprofil_R_Load(object sender, EventArgs e)
        {
            textBox1.Text = V;
            textBox2.Text = A;
            textBox3.Text = Ibxy;
            textBox4.Text = Wbxy;
            textBox5.Text = Itxy;
            textBox6.Text = Wtxy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
