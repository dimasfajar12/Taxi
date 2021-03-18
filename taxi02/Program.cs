using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi02
{
    class Program
    {
        static void Main(string[] args)
        {
            taksi taxi = new taksi();

            taxi.namadriver = " Dimas ";
            taxi.sedangbertugas = true;
            taxi.penumpang = 10;

            taxi.TaxiInfo();
            taxi.angkutpenumpang();
            taxi.turunpenumpang();

            Console.ReadKey();
        }
    }
}
