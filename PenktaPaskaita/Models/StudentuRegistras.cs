using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaita.Models
{
    internal class StudentuRegistras
    {
        private Studentas[] Studentai { get; set; }

        int studentuKiekis = 0;
        int paskutinisPridetas = 0;

        public StudentuRegistras()
        {
            Studentai = new Studentas[100];
        }

        public void AddStudentas(Studentas studentas)
        {
            Studentai[paskutinisPridetas] = studentas;
            paskutinisPridetas++;
            studentuKiekis++;
        }

        public void RemoveStudentas(string vardas, string pavarde)
        {
            for (int i = 0; i < Studentai.Length; i++)
            {
                if (Studentai[i].Vardas == vardas && Studentai[i].Pavarde == pavarde)
                {
                    for (int j = i; j < Studentai.Length - 1; j++)
                    {
                        Studentai [j] = Studentai[j + 1];
                    }
                    Studentai[Studentai.Length - 1] = null;
                    studentuKiekis--;
                    break;
                }
            }
        }

        public Studentas FindStudentas(string vardas, string pavarde)
        {
            for(int i = 0; i < Studentai.Length; i++)
            {
                if (Studentai[i].Vardas == vardas && Studentai[i].Pavarde == pavarde)
                {
                    return Studentai[i];
                }
            }
            return null;
        }

        public double TotalVidurkis()
        {
            double visuSuma = 0;

            for (int i = 0; i < studentuKiekis; i++)
            {
                visuSuma += Studentai[i].Vidurkis();
            }
            visuSuma = visuSuma / studentuKiekis;
            return visuSuma;
        }

    }


}
