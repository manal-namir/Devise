using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
     class Dollar:Devise
    {
        private double tauxEuro;
        private double tauxMad;

        public Dollar(object p)
        {
        }

        public Dollar(double E, double M, double v, string t) : base(v, t)
        {
            this.tauxEuro = E;
            this.tauxMad = M;

        }
        public override Devise Convertto(string symbole)
        {
            Devise res;
            if (symbole == "Euro")
            {
                res = new Euro(this.valeur * tauxEuro);
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