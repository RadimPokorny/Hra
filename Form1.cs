using npc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hrac hrac;
        Npc npc;

        private void Form1_Load(object sender, EventArgs e)
        {

            hrac = new Hrac("debil", Trida.Inzenyr, Oblicej.makeup, Vlasy.culik, BarvaVlasu.blond);
            npc = new Npc(Ocupation.nepritel, "kokot");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hrac.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isBoss = true;
            npc.IsBoss(isBoss);

        }
    }
}
