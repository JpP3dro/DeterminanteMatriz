using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminanteMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz;
            //Programa que acha a determinante de matrizes quadradas
            Console.WriteLine("Digite o tamanho da sua matriz");
            int tamanho = int.Parse(Console.ReadLine());
            switch (tamanho)
            {
                case 0:
                    Console.WriteLine("Matriz não tem elementos!");
                    break;
                case 1:
                    Console.WriteLine("Digite o elemnto da matriz");
                    int elemento = int.Parse(Console.ReadLine());
                    Console.WriteLine($"A determinante dessa matriz é {elemento}");
                    break;
                case 2:
                    matriz = new int[2, 2];
                    PreencherMatriz(matriz);
                    ExibirMatriz(matriz);
                    Console.WriteLine($"A determinante da matriz é: {Matriz2(matriz)}");
                    break;
                case 3:
                    matriz = new int[3, 3];
                    PreencherMatriz(matriz);
                    ExibirMatriz(matriz);
                    Console.WriteLine($"A determinante da matriz é: {Matriz3(matriz)}");
                    break;
                default:
                    Console.WriteLine("Tamanho inválido!");
                    break;
            }
            Console.ReadKey();
        }
        private static void ExibirMatriz(int[,] matriz)
        {
            Console.WriteLine("Matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++) 
            {
                for (int j = 0; j < matriz.GetLength(1); j++) 
                {
                    Console.Write(matriz[i, j] + "\t"); 
                }
                Console.WriteLine();
            }
        }
        private static void PreencherMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Digite o termo {i + 1}{j + 1} da matriz");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        private static int Matriz2(int[,] matriz)
        {
            int cal1 = matriz[0, 0] * matriz[1, 1];
            int cal2 = matriz[0, 1] * matriz[1, 0];
            int determinante = cal1 - cal2;
            return determinante;
        }
        private static int Matriz3(int[,] matriz)
        {
            int determinante = 0;
            int[] calculo = new int[6];
            calculo[0] = -1 * matriz[0, 2] * matriz[1, 1] * matriz[2, 0];
            calculo[1] = -1 * matriz[0, 0] * matriz[1, 2] * matriz[2, 1];
            calculo[2] = -1 * matriz[0, 1] * matriz[1, 0] * matriz[2, 2];
            calculo[3] = matriz[0, 0] * matriz[1, 1] * matriz[2, 2];
            calculo[4] = matriz[0, 1] * matriz[1, 2] * matriz[2, 0];
            calculo[5] = matriz[0, 2] * matriz[1, 0] * matriz[2, 1];
            foreach (int calc in calculo)
            {
                determinante += calc;
            }
            return determinante;
        }
    }
}
