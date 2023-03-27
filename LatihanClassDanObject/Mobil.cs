using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    public class Mobil
    {
        // properties
        public string Warna { get; set; }
        public string JumlahPintu { get; set; }
        public string Merek { get; set; }
        public string Model { get; set; }
        public string TahunKeluaran { get; set; }


        // method
        public void Input()
        {
            Console.WriteLine("Warna {0}", Warna);
            Console.WriteLine("Jumlah Pintu {0}", JumlahPintu);
            Console.WriteLine("Merek {0}", Merek);
            Console.WriteLine("Model {0}", Model);
            Console.WriteLine("Tahun Keluaran {0}", TahunKeluaran);
            Console.WriteLine("Mobil Toyota berjalan dengan kecepatan 160km/jam");

        }
        public void Klakson()
        {
            Console.WriteLine("Tin... Tin... Tin...");
        }
            public void Info()
        { 
            Console.WriteLine("Mobil saya berwarna Merah, merek Toyota, model MVP, tahun keluaran 2022, dengan jumlah pintu sebanyak Empat");
        }


    }
}
