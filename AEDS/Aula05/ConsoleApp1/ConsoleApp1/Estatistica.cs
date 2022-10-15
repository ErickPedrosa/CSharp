using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula05
{
    public static class Estatistica
    {
        //Devolve o número mais frequente em um array, caso tenham dois com a mesma frequencia será retornado o primeiro;
        public static int Moda(int[] vet)
        {
            int moda = 0, i, j, buf = -999999999;

            int[] cont = new int[vet.Length];

            for (i = 0; i < vet.Length; i++)
            {
                for (j = i + 1; j < vet.Length; j++)
                {
                    if (vet[i] == vet[j])
                    {
                        cont[i]++;
                        if (cont[i] > buf)
                        {
                            buf = cont[i];
                            moda = i;
                        }
                    }
                }
                cont[i] = 0;
            }


            return vet[moda];
        }



        public static int Mediana(int[] vet)
        {
            Array.Sort(vet);

            int indexMiddle = (vet.Length / 2);

            return vet[indexMiddle];
        }

        public static double Media(int[] vet)
        {
            double result = 0;

            foreach(var v in vet)
            {
                result += v;
            }
            result /= vet.Length;

            return result;
        }
    }
}
