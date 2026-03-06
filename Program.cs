using System.Text.Json;

namespace teglalap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teglalap simaTeglalap = new Teglalap(5, 5);
            Console.WriteLine(simaTeglalap.Kerulet());
            Console.WriteLine(simaTeglalap.Terulet());
            Console.WriteLine(simaTeglalap.Atlo());
            Console.WriteLine(simaTeglalap.NegyzetE());
            Console.WriteLine("Adja meg a téglalap nevét:");
            simaTeglalap.SetNev(Console.ReadLine());
            Console.WriteLine("Adja meg a téglalap oldalainak százalékos növelését:");
            double szazalek = double.Parse(Console.ReadLine());
            simaTeglalap.oldalNovelesSzazalekkal(szazalek);
            Console.WriteLine(simaTeglalap);
            Console.WriteLine("Adja meg a téglalap területének százalékos növekedését: ");
            double teruletSzazalek = double.Parse(Console.ReadLine());
            simaTeglalap.teruletNovelesSzazalekkal(teruletSzazalek);
            Console.WriteLine($"Terület növelve: {simaTeglalap.Terulet()}");
            simaTeglalap.teruletFelezese();

            Console.WriteLine(simaTeglalap.Terulet());
        }
    }
}
