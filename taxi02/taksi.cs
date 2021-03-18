using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi02
{
    class taksi
    {

        public string namadriver { get; set; }
        public bool sedangbertugas { get; set; }
        public int penumpang { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine(" Nama Driver     : {0} ", namadriver);
            if (sedangbertugas == true)
            {
                Console.WriteLine(" Sedang mengantar penumpang ", sedangbertugas);
            }
            else
            {
                Console.WriteLine(" Sedang tidak mengantar penumpang ", sedangbertugas);
            }

            Console.WriteLine(" Jumlah penumpang  : {0}\n ", penumpang);
        }

        public void angkutpenumpang()
        {
            Console.WriteLine(" {0} Sedang menjemput penumpang ", namadriver);
        }

        public void turunpenumpang()
        {
            Console.WriteLine(" {0} Selesai menjemput penumpang\n ", namadriver);
        }
    }
}
