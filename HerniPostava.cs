using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hra
{
    internal class HerniPostava
    {
        public string _jmeno;
        public string Jmeno
        {
            get { return _jmeno; }
            set { 
                _jmeno = value;

                if (_jmeno.Length > 10)
                {
                    MessageBox.Show("Příliš dlouhé jméno!");
                }

            }
        }

        public int _level;
        public int _poziceX;
        public int _poziceY;

        public HerniPostava(string jmeno)
        {
            _level = 1;
            _poziceX = 0;
            _poziceY = 0;
            Jmeno = jmeno;
        }

        public virtual void ZmenaPozice(bool upDown, bool rightLeft)
        {
            if (upDown == true)
            {
                _poziceY++;
            }

            if (rightLeft == true)
            {
                _poziceX++;
            }
        }
        public override string ToString()
        {
            return Jmeno + " - level: " + _level + ", poziceX: " + _poziceX + ", poziceY: " + _poziceY+", ";
        }

    }
}
