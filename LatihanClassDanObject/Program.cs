using LatihanClassDanObject;

namespace classObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();
            Mobil mobil2 = new Mobil();
            Mobil mobil3 = new Mobil();

            mobil1.Warna         = "Merah";
            mobil1.JumlahPintu   = "Empat";
            mobil1.Merek         = "Toyota";
            mobil1.Model         = "MVP";
            mobil1.TahunKeluaran = "2022";





            mobil1.Input();
            mobil2.Klakson();
            mobil3.Info();
        }
    }
}