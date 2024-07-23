using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaita.Models
{
    internal class Automobilis
    {
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Metai { get; set; }
        public int Rida { get; set; }

        public Automobilis(string marke, string modelis, int metai, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            Rida = rida;
        }

        public int AutomobilioAmzius()
        {
            int amzius = DateTime.Now.Year - Metai;
            return amzius;
        }

        public override string ToString()
        {
            return $"{Marke} {Modelis} {Metai}";
        }


    }
}
