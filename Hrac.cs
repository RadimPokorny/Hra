using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{

    public enum Trida
    {
        Kouzelnik,
        Berserker,
        Inzenyr,
        Cizak
    }

    public enum Oblicej
    {
        velkynos,
        usoplesk,
        makeup
    }

    public enum Vlasy
    {
        drdol,
        culik,
        pleska
    }

    public enum BarvaVlasu
    {
        kastanova,
        blond,
        cervena
    }


    internal class Hrac : HerniPostava
    {

        

        public Trida _trida;

        

        public Oblicej _oblicej;
        
        public Vlasy _vlasy;

        public BarvaVlasu _barvaVlasu;

        public int _xp;

        public Hrac(string jmeno, Trida trida, Oblicej oblicej, Vlasy vlasy, BarvaVlasu barvaVlasu ) : base(jmeno)
        {
            _xp = 0;
            _oblicej = oblicej;
            _vlasy = vlasy;
            _barvaVlasu = barvaVlasu;
            _trida = trida;
        }

        public void pridejXP()
        {
            _xp += 10;
            if (_xp % 100 == 0)
            {
                _level++;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "oblicej: " + _oblicej + ", vlasy: " + _vlasy + ", barva vlasu: " + _barvaVlasu + ", trida:" + _trida;
        }


    }
}
