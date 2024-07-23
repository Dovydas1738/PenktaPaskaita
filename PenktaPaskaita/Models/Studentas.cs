using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaita.Models
{
    internal class Studentas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int[] PazymiuMasyvas { get; set; }

        int pazymiuKiekis = 0;

        public Studentas(string vardas, string pavarde, int[] pazymiuMasyvas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            PazymiuMasyvas = pazymiuMasyvas;
        }

        public void AddPazymis(int pazymis, int index)
        {
            PazymiuMasyvas[index] = pazymis;
        }

        public double Vidurkis()
        {
            double pazymVidurkis = 0;
            for (int i = 0; i < PazymiuMasyvas.Length; i++)
            {
                pazymVidurkis += PazymiuMasyvas[i];
            }
            pazymVidurkis = pazymVidurkis / PazymiuMasyvas.Length;
            return pazymVidurkis;
        }

        public override string ToString()
        {
            return $"{Vardas} {Pavarde} jo pazymiu vidurkis yra: {Vidurkis()}";
        }

    }
}
