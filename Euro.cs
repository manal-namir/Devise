using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
    class Euro : Devise
    {
        private static double tauxDollar = 0.8;
        private static double tauxMad = 0.9;


        public Euro(double v) : base(v, "Euro")
        {

        }
        public override Devise Convertto(string symbole)
        {
            Devise res;

            if (symbole == "Dollar")
            {
                res = new Dollar(this.valeur * tauxDollar);
            }
            else if (symbole == "Mad")
            {
                res = new Mad(this.valeur * tauxMad);
            }
            else
            {
                res = this;
            }
            return res;
        }
    }
}