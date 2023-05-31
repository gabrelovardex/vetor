using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace vetor
{
    internal class Program
    {
        public static void Exercicio1()
        {
           
           
            int[] vet2;
            Console.WriteLine("ENTRE COM O TAMANHO DOS VETORES:");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            float soma = 0;
            
            for (int i = 0; i < t; i++) {
                vet2[i] = rand.Next(10, 50);
                soma = soma + vet2[i];
            }

            Console.WriteLine("A MÉDIA ARITIMETICA É: " + soma / (float) t);

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("POSIÇÃO[{0}] = {1}", i, vet2[i]);
            }

        }
        public static void Exercicio2()
        {
            float somapa = 0, somaimpa = 0;
            int[] vet2;
            Console.WriteLine("ENTRE COM O TAMANHO DOS VETORES:");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

           

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);
              

                if (vet2[i] % 2 == 0)
                {
                    somapa = somapa + vet2[i];
                }
                else
                {
                   somaimpa = somaimpa + vet2[i];
                }
            }

            Console.WriteLine(" A SOMA DOS NUMEROS PARES É: {0}, E A DOS NUMEROS IMPARES É: {1}", somapa, somaimpa);


            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("POSIÇÃO[{0}] = {1}", i, vet2[i]);
            }


        }
        public static void Exercicio3()
        {



        }
        public static void Exercicio4()
        {
            
        }
       
        static void Main(string[] args)
        {
            int MENU;

            do
            {

                Console.WriteLine("==========MENU==========");
                Console.WriteLine("1- EXERCÍCIO 1");
                Console.WriteLine("2- EXERCÍCIO 2");
                Console.WriteLine("3- EXERCÍCIO 3");
                Console.WriteLine("4- EXERCÍCIO 4");
                Console.WriteLine("=======================");

                MENU = int.Parse(Console.ReadLine());

                switch (MENU)
                {

                    case 1:
                        Exercicio1();
                        break;


                    case 2:
                        Exercicio2();
                        break;


                    case 3:
                        Exercicio3();
                        break;


                    case 4:
                        Exercicio4();
                        break;


                    default:
                        Console.WriteLine("Número inválido");
                        break;



                }

                Console.ReadKey();

            } while (MENU != 0);
        }
    }
}