using PenktaPaskaita.Models;
using System;

namespace ManoPrograma
{
    public class PagrindineKlase
    {
        public static void Main(String[] args)
        {

            //1 uzduotis***********************************************************

            //PrekiuKatalogas katalogas = new PrekiuKatalogas();

            //katalogas.AddPreke(new Preke("bulve", 1, 5));
            //katalogas.AddPreke(new Preke("morka", 1, 5));
            //katalogas.AddPreke(new Preke("sausainiai", 1, 5));
            //katalogas.AddPreke(new Preke("grybas", 3, 5));
            //katalogas.AddPreke(new Preke("cipsai", 1, 5));
            //katalogas.AddPreke(new Preke("fanta", 1, 5));



            //Console.WriteLine("Prekiu krepselio kaina: " + katalogas.TotalKaina());

            //Console.WriteLine(katalogas.findPreke("grybas") + " Preke rasta");

            //katalogas.RemovePreke("grybas");

            //Console.WriteLine("grybas yra panaikintas");

            //Console.WriteLine(katalogas.findPreke("grybas"));

            //Console.WriteLine("Kaina be grybu " + katalogas.TotalKaina());


            // 2 uzduotis**********************************************************

            //StudentuRegistras registras = new();

            //registras.AddStudentas(new Studentas("Antanas", "Antonio", new int[] { 7, 8, 9, 5, 10 }));
            //registras.AddStudentas(new Studentas("Petras", "Petrinis", new int[] { 7, 9, 5, 5, 10 }));
            //registras.AddStudentas(new Studentas("Aldona", "Aldonaite", new int[] { 6, 7, 10, 5, 10 }));

            //Console.WriteLine(registras.FindStudentas("Petras", "Petrinis"));
            //Console.WriteLine("Visu studentu vidurkis yra: " + registras.TotalVidurkis());

            //registras.RemoveStudentas("Petras", "Petrinis");
            //Console.WriteLine("Petras Petrinis pasalintas");

            //Console.WriteLine("Visu studentu vidurkis be Petro yra: " + registras.TotalVidurkis());

            // 3 uzduotis**********************************************************

            //AutomobiliuParkas parkas = new AutomobiliuParkas();

            //parkas.AddAutomobilis(new Automobilis("Audi", "100", 1986, 2000000));
            //parkas.AddAutomobilis(new Automobilis("BMW", "x5", 2010, 3000000));
            //parkas.AddAutomobilis(new Automobilis("Skoda", "Octavia", 2018, 200000));
            //parkas.AddAutomobilis(new Automobilis("Ford", "Sierra", 1975, 8000000));

            //Console.WriteLine("Seniausias automobilis yra: " + parkas.oldestAutomobilis());
            //Console.WriteLine("Bendra automobiliu rida: " + parkas.TotalRida());

            //parkas.RemoveAutomobilis("Ford", "Sierra");
            //Console.WriteLine("Ford Sierra removed");

            //Console.WriteLine("Bendra automobiliu rida be Ford Sierra automobilio: " + parkas.TotalRida());
        }
    }
}

