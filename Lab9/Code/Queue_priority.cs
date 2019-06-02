using ConsoleApp1.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Numbers
    {
        public int number { get; set; }
        public int weight { get; set; }
        public Numbers(int iNumber, int iWeight)
        {
            number = iNumber;
            weight = iWeight;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            bool isRunning = true;
            List<Numbers> numberList = new List<Numbers>();

            do
            {
                MainMenu();
                var response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        pushElement(numberList);
                        List<Numbers> SortedList = numberList.OrderBy(n => n.weight).ToList();
                        numberList = SortedList;
                        break;
                    case "2":
                        popElement(numberList);
                        break;
                    case "3":
                        showElements(numberList);
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

        public static void popElement(List<Numbers> nNumbers)
        {
            bool isEmpty = nNumbers.Count() == 0;
            if (nNumbers.Count() == 0)
                Console.WriteLine("--kolejka jest pusta--");
            else
                nNumbers.RemoveAt(0);
        }
        public static void pushElement(List<Numbers> nNumbers)
        {
            Console.Write("Number: ");
            string a = Console.ReadLine();
            int numb;
            int.TryParse(a,out numb);
            Console.Write("Weight: ");
            string b = Console.ReadLine();
            int weig;
            int.TryParse(b, out weig);

            nNumbers.Add(new Numbers(numb, weig));
        }
        public static void showElements(List<Numbers> nNumbers)
        {
            if (nNumbers.Count() == 0)
                Console.WriteLine("--kolejka jest pusta--");
            else
            {
                foreach (Numbers number in nNumbers)
                {
                    Console.WriteLine("Number: " + number.number
                        + "\nWeight: " + number.weight + "\n");
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
