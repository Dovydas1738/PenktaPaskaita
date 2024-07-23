using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaita.Models
{
    internal class AutomobiliuParkas
    {
        private Automobilis[] Automobiliai { get; set; }

        int automobiliuKiekis = 0;
        int paskutinisPridetas = 0;

        public AutomobiliuParkas()
        {
            Automobiliai = new Automobilis[100];
        }

        public void AddAutomobilis(Automobilis automobilis)
        {
            Automobiliai[paskutinisPridetas] = automobilis;
            paskutinisPridetas++;
            automobiliuKiekis++;
        }

        public void RemoveAutomobilis(string marke, string modelis)
        {
            for (int i = 0; i < Automobiliai.Length; i++)
            {
                if (Automobiliai[i].Marke == marke && Automobiliai[i].Modelis == modelis)
                {
                    for (int j = i; j < Automobiliai.Length - 1; j++)
                    {
                        Automobiliai[j] = Automobiliai[j + 1];
                    }

                    Automobiliai[Automobiliai.Length - 1] = null;
                    automobiliuKiekis--;
                    break;

                }
            }
        }

        public int TotalRida()
        {
            int riduSuma = 0;
            for (int i = 0; i < automobiliuKiekis; i++)
            {
                riduSuma += Automobiliai[i].Rida;
            }
            return riduSuma;
        }

        public Automobilis oldestAutomobilis()
        {
            int maziausiMetai = 0;
            
            for (int i = 0; i < automobiliuKiekis; i++)
            {
                for(int j = 0; j < automobiliuKiekis; j++)
                {
                    if(Automobiliai[i].Metai <= Automobiliai[j].Metai)
                    {
                        if (maziausiMetai > Automobiliai[i].Metai || maziausiMetai == 0)
                        {
                            maziausiMetai = Automobiliai[i].Metai; 
                        }
                    }
                    else
                    {
                        continue;
                    }


                }
            }
            for (int i = 0; i < automobiliuKiekis; i++)
            {
                if (maziausiMetai == Automobiliai[i].Metai)
                {
                    return Automobiliai[i];
                }
            }
            return null;
        }

    }



}
