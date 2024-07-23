using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaita.Models
{
    public class PrekiuKatalogas
    {
        private Preke[] Prekes { get; set; }

        int paskutinePrideta = 0;
        int prekiuKiekis = 0;

        public PrekiuKatalogas()
        {
            Prekes = new Preke[100];

        }

        public void AddPreke(Preke preke)
        {
            Prekes[paskutinePrideta] = preke;
            paskutinePrideta++;
            prekiuKiekis++;
        }

        public void RemovePreke(string pavadinimas) 
        {

            for (int i = 0; i < prekiuKiekis; i++)
            {
                if (Prekes[i].Pavadinimas == pavadinimas)
                {
                    for(int j = i; j < prekiuKiekis - 1; j++)
                    {
                        Prekes[j] = Prekes[j + 1];

                    }

                    Prekes[prekiuKiekis - 1] = null;
                    prekiuKiekis--;
                    break;

                }
            }
        }

        public double TotalKaina()
        {
            double price = 0;
            
            for (int i = 0; i < prekiuKiekis ; i++)
            {
                price += Prekes[i].Kaina * Prekes[i].Kiekis;
            }

            return price;
        }

        public Preke findPreke(string pavadinimas)
        {
            for (int i = 0; i < prekiuKiekis; i++)
            {
                if (Prekes[i].Pavadinimas == pavadinimas)
                {
                    return Prekes[i];
                }
            }
            return null;
        }

    }

   

}
