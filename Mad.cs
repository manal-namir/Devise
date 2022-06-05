using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
    class Mad : Devise
    {
        private static double tauxEuro = 0.20;
        private static double tauxDollar = 0.7;


        public Mad(double v) : base(v, "Mad")
        {

        }
        public override Devise Convertto(string symbole)
        {
            Devise res;

            if (symbole == "Euro")
            {
                res = new Euro(this.valeur * tauxEuro);
            }
            else if (symbole == "Dollar")
            {
                res = new Dollar(this.valeur * tauxDollar);
            }
            else
            {
                res = this;
            }
            return res;
        }
    }
}