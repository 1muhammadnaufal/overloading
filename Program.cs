
using minggu5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Overloading overloading1 = new Overloading();

            int a = 82;
            int b = 53;

            int nilaiMin = overloading1.CariNilaiMin(a, b);
            int nilaiMax = overloading1.CariNilaiMax(a, b);

            Console.ReadLine();
        }
    }
}
