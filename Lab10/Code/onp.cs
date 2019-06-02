//UWAGA - KOD NIE DZIAŁA DLA LICZB WIĘKSZYCH OD 9 [nie zaimplementowałem
//          zamiany dwóch występujących po sobie cyfr na jedną liczbę]

using ConsoleApp1.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Stos
    {
        public int s_character { get; set; }
        public Stos(int sName)
        {
            s_character = sName;
        }

        public static int popElement(List<Stos> stos)
        {
            int a = stos.ElementAt(stos.Count() - 1).s_character;
            stos.RemoveAt(stos.Count() - 1);
            return a;
        }

        public static void pushElement(List<Stos> stos, string x)
        {
            int a;
            int.TryParse(x, out a);
            stos.Add(new Stos(a));
        }

        public static void pushElement(List<Stos> stos, int a)
        {
            stos.Add(new Stos(a));
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Stos> stos = new List<Stos>();

            Console.WriteLine("Podaj działanie w ONP do obliczenia:");
            string example = Console.ReadLine();

            for (int i = 0; i < example.Length; i++)
            {
                if (example[i] >= 48 && example[i] <= 57)
                {
                    string xd = example[i].ToString();
                    Stos.pushElement(stos, xd);
                }
                else if (example[i] == '+' || example[i] == '-'
                    || example[i] == '*' || example[i] == '/')
                {
                    int a,b, result = 0;
                    a = Stos.popElement(stos);
                    b = Stos.popElement(stos);

                    switch (example[i])
                    {
                        case '+':
                            result = b + a;
                            break;
                        case '-':
                            result = b - a;
                            break;
                        case '*':
                            result = b * a;
                            break;
                        case '/':
                            result = b / a;
                            break;
                    }

                    Stos.pushElement(stos, result);
                }
            }
            Console.WriteLine("\n\n" + Stos.popElement(stos));
        }
    }
}
