using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevise dev = new Mad(20);

            Console.WriteLine("la valeur en euro est :" + dev.Convertto("Euro").ToString());
            Console.WriteLine("la valeur en dollar est :" + dev.Convertto("Dollar").ToString());
            Console.ReadKey();

        }
    }
}