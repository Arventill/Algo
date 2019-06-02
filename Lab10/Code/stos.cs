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
        public int s_id { get; set; }
        public string s_name { get; set; }
        public Stos(int iNumber, string sName)
        {
            s_id = iNumber;
            s_name = sName;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            bool isRunning = true;
            List<Stos> stos = new List<Stos>();

            do
            {
                MainMenu();
                var response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        pushElement(stos);
                        break;
                    case "2":
                        popElement(stos);
                        break;
                    case "3":
                        showElements(stos);
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Coś poszło nie tak :( \nSpróbuj ponownie później");
                        break;
                }
            } while (isRunning);
        }

        public static void popElement(List<Stos> stos)
        {
            bool isEmpty = stos.Count() == 0;
            if (stos.Count() == 0)
                Console.WriteLine("--stos jest pusty--");
            else
                stos.RemoveAt(stos.Count()-1);
        }
        public static void pushElement(List<Stos> stos)
        {
            Console.Write("Id: ");
            string a = Console.ReadLine();
            int numb;
            int.TryParse(a,out numb);
            Console.Write("Name: ");
            string b = Console.ReadLine();

            stos.Add(new Stos(numb, b));
        }
        public static void showElements(List<Stos> stos)
        {
            if (stos.Count() == 0)
                Console.WriteLine("--stos jest pusty--");
            else
            {
                foreach (Stos sth in stos)
                {
                    Console.WriteLine("Id: " + sth.s_id
                        + "\nName: " + sth.s_name + "\n");
                }
            }

        }

        private static void MainMenu()
        {
            Console.WriteLine(AppResources.Main_WelcomeUser);
            Console.WriteLine(AppResources.Main_ChooseFunction);
            Console.WriteLine("1 - Push Element");
            Console.WriteLine("2 - Pop Element");
            Console.WriteLine("3 - Show all Elements");
            Console.WriteLine("4 - Exit");
        }
    }
}
