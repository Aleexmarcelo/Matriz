using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura dos numeros aplicados para matriz quadrada
            int n = int.Parse(Console.ReadLine());
            //Criando a matriz usando N
            int[,] mat = new int[n,n];
            //Criado um loop nas linhas da matriz
            for (int i = 0; i < n; i++)
            {
                //Array para guardar valores
                string[] values = Console.ReadLine().Split(' ');

                //Criado um loop nas linhas da matriz
                for (int j = 0; j < n; j++)
                {
                    //Aplicando os valores em seus devidos lugares
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main Diagonal:");
            //Criado um loop nas linhas da matriz
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + "");
            }
            Console.WriteLine();
            //Variavel que conta os numeros negativos e passa por todas as posicoes
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j]< 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Números negativos:" + count);
        }    
    }
}
