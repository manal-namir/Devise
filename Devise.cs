using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
    internal abstract class Devise : IDevise
    {
        protected double valeur;
        private string type;

        abstract public Devise Convertto(string symbole);
        public Devise(double val, string type)
        {
            this.valeur = val;
            this.type = type;
        }
        public override string ToString()
        {
            string s = "la valeur est:" + this.valeur + "+\n" + "le type est :" + this.type;
            return s;
        }

    }
}