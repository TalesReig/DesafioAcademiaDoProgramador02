using System;

namespace DiamanteDeLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
                char letra;
                string alfabeto = "abcdefghijklmnopqrstuvwxyz";// [ a, b, c
                int quantEspacoEsquerda, quantEspacoMeio = 0, metade = 0;
                Console.Write("Digite a letra de a ('A' a 'Z')");
                letra = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(" \n \n \n");

                char[] vetoralfabeto = alfabeto.ToCharArray();

                for (int i = 0; i < vetoralfabeto.Length; i++)
                {
                    if (vetoralfabeto[i] == letra)
                    {
                        metade = i;
                    }
                }

                quantEspacoEsquerda = metade;

                for (int i = 0; i <= metade; i++)
                {
                    for (int j = 0; j < quantEspacoEsquerda; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(vetoralfabeto[i]);
                    for (int k = 0; k < quantEspacoMeio; k++)
                    {
                        Console.Write(" ");
                    }
                    if (i != 0)
                    {
                        Console.Write(vetoralfabeto[i]);
                    }
                    Console.WriteLine();

                    quantEspacoEsquerda = quantEspacoEsquerda - 1;
                    if (i == 0)
                    {
                        quantEspacoMeio = 1;
                    }
                    if (i != 0 && i != metade)
                    {
                        quantEspacoMeio = quantEspacoMeio + 2;
                    }
                }

                quantEspacoEsquerda = 0;

                for (int i = 1; i <= metade; i++)
                {

                    quantEspacoEsquerda = quantEspacoEsquerda + 1;
                    if (i == metade)
                    {
                        quantEspacoMeio = 1;
                    }
                    if (i != 0 && i != metade)
                    {
                        quantEspacoMeio = quantEspacoMeio - 2;
                    }


                    for (int j = 0; j < quantEspacoEsquerda; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(vetoralfabeto[metade - i]);

                    for (int k = 0; k < quantEspacoMeio; k++)
                    {
                        Console.Write(" ");
                    }

                    if (i != metade)
                    {
                        Console.Write(vetoralfabeto[metade - i]);
                    }
                    Console.WriteLine();

                }
                Console.ReadLine();
            }
        }
    }