using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaus
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilo henkilo = new Henkilo();          //Luokka + itsekeksima nimi = kutsutaan konstrukstori
            Console.WriteLine("Henkilon nimi : " + henkilo.Nimi);
            Console.WriteLine("Henkilon paino : " + henkilo.Paino);

            string nimi = "Kirsi Kernel";
            double paino = 50;


            Henkilo henkilo2 = new Henkilo(nimi, paino);
            Console.WriteLine("Henkilon nimi : " + henkilo2.Nimi);
            Console.WriteLine("Henkilon paino : " + henkilo2.Paino);


            Henkilo hankilo3 = new Henkilo { Nimi = "Kalle", Paino = 23 };

            Katsoja katsoja = new Katsoja("Minna Teikäläinen", 40, true);
            Console.WriteLine(katsoja.ToString());
            katsoja.huutaa();

        }
    }
}
