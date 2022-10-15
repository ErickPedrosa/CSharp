using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    public class Pascal
    {


        public static void TrianguloP()
        {
            int i = 0;
            int cont = 0;
            int quant = 0;
            int coluna = 0;
            int linha = 0;

            Console.Write("Digite o n° de linhas: ");
            quant = int.Parse(Console.ReadLine());

            int[,] mat = new int[quant + 1, quant + 1];


            for (i = 1; i <= quant; i++)
            {
                for (cont = 1; cont <= quant; cont++)
                {
                    if ((cont == 1) | (i == cont))
                    {
                        mat[i, cont] = 1;
                    }
                    else
                    {
                        mat[i, cont] = mat[i - 1, cont] + mat[i - 1, cont - 1];
                    }
                }
            }

            for (i = 1; i <= quant; i++)
            {
                for (cont = 1; cont <= quant; cont++)
                {
                    if (mat[i, cont] != 0)
                    {
                        Console.Write($"{mat[i, cont]}  ");
                    }

                }
                Console.WriteLine();
            }



        }
    }
}
        
   
