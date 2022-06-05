using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
    interface IDevise
    {
        Devise Convertto(string symbole);
    }
}