using Hra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace npc
{
    public enum Ocupation
    {
        obchodnik,
        nepritel,
        obyvatel,
        korporatnikrysa,
        prijemcePasivnihoPrijmuZNft
    }

    internal class Npc : HerniPostava
    {
        public Ocupation _octupation;

        public Npc(Ocupation octupation,string jmeno) : base(jmeno)
        {
            _octupation = octupation;
        }

        public void IsBoss(bool Isboss)
        {
            if(Isboss)
            {
                MessageBox.Show("NPC je totálně najetej boss");
            }
            else
            {
                MessageBox.Show("NPC není totálně najetej boss");
            }
        }

        public override void ZmenaPozice(bool upDown, bool rightLeft)
        {
            base.ZmenaPozice(upDown, rightLeft);
        }
    }

}
