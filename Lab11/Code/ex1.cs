using ConsoleApp1.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Stos
    {
        public string s_name { get; set; }
        public Stos(string sName)
        {
            s_name = sName;
        }

        public static string popElement(List<Stos> stos)
        {
            string a = stos.ElementAt(stos.Count() - 1).s_name;
            stos.RemoveAt(stos.Count() - 1);
            return a;
        }

        public static void pushElement(List<Stos> stos, string x)
        {
            stos.Add(new Stos(x));
        }

        public static void isEmpty(List<Stos> stos)
        {
            if (stos.Count() == 0)
                Console.WriteLine("--- Stos jest pusty ---");
            else
                Console.WriteLine("--- Stos nie jest pusty ---");
        }

        public static int size(List<Stos> stos)
        {
            return stos.Count();
        }

        public static void belongTo(List<Stos> stos, string x)
        {
            foreach (var item in stos)
            {
                if (x == item.s_name)
                    Console.WriteLine("Element należy do stosu");
            }
            Console.WriteLine("Element nie należy do stosu");
        }

        public static string popExactly(List<Stos> stos, int elem)
        {
            string a = stos.ElementAt(elem).s_name;
            stos.RemoveAt(elem);
            return a;
        }
    }

    public class Queue
    {
        public string q_name { get; set; }

        Queue(string n)
        {
            q_name = n;
        }

        public static string popElement(List<Queue> qList)
        {
            string a = qList.ElementAt(0).q_name;
            qList.RemoveAt(0);
            return a;
        }

        public static void pushElement(List<Queue> qList, string x)
        {
            qList.Add(new Queue(x));
        }

        public static void isEmpty(List<Queue> qList)
        {
            if (qList.Count() == 0)
                Console.WriteLine("--- Kolejka jest pusta ---");
            else
                Console.WriteLine("--- Kolejka nie jest pusta ---");
        }

        public static int size(List<Queue> qList)
        {
            return qList.Count();
        }

        public static void belongTo(List<Queue> qList, string x)
        {
            foreach (var item in qList)
            {
                if (x == item.q_name)
                    Console.WriteLine("Element należy do kolejki");
            }
            Console.WriteLine("Element nie należy do kolejki");
        }

        public static string popExactly(List<Queue> qList, int elem)
        {
            string a = qList.ElementAt(elem).q_name;
            qList.RemoveAt(elem);
            return a;
        }
    }

    public class Vector
    {
        public int v_numb { get; set; }
        Vector(int n)
        {
            v_numb = n;
        }

        public static int popElement(List<Vector> vList)
        {
            int a = vList.ElementAt(0).v_numb;
            vList.RemoveAt(0);
            return a;
        }

        public static void pushElement(List<Vector> vList, int x)
        {
            vList.Add(new Vector(x));
        }

        public static void isEmpty(List<Vector> vList)
        {
            if (vList.Count() == 0)
                Console.WriteLine("--- Wektor jest pusty ---");
            else
                Console.WriteLine("--- Wektor nie jest pusty ---");
        }

        public static int size(List<Vector> vList)
        {
            return vList.Count();
        }

        public static void belongTo(List<Vector> vList, int x)
        {
            foreach (var item in vList)
            {
                if (x == item.v_numb)
                    Console.WriteLine("Element należy do wektora");
            }
            Console.WriteLine("Element nie należy do wektora");
        }

        public static int popExactly(List<Vector> vList, int elem)
        {
            int a = vList.ElementAt(elem).v_numb;
            vList.RemoveAt(elem);
            return a;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            bool isRunning = true;
            List<Stos> stos = new List<Stos>();
            List<Queue> kolejka = new List<Queue>();
            List<Vector> vector = new List<Vector>();

            do
            {
                MainMenu();
                var response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        {
                            StosMenu();
                            var res = Console.ReadLine();
                            switch (res)
                            {
                                case "1":
                                    Console.WriteLine("Wczytaj element do dodania:");
                                    string x = Console.ReadLine();
                                    Stos.pushElement(stos, x);
                                    break;
                                case "2":
                                    Console.WriteLine("Usunięto element ze stosu");
                                    Stos.popElement(stos);
                                    break;
                                case "3":
                                    Stos.isEmpty(stos);
                                    break;
                                case "4":
                                    Console.WriteLine("Rozmiar stosu to: " + Stos.size(stos));
                                    break;
                                case "5":
                                    Console.WriteLine("Podaj element do sprawdzenia:");
                                    string z = Console.ReadLine();
                                    Stos.belongTo(stos, z);
                                    break;
                                case "6":
                                    Console.WriteLine("Element o jakim indeksie chcesz pobrać?");
                                    string iks = Console.ReadLine();
                                    int c;
                                    int.TryParse(iks, out c);
                                    string pobrano = Stos.popExactly(stos, c);
                                    Console.WriteLine("Pobrano " + pobrano + "o indeksie " + c);
                                    break;

                                default:
                                    Console.WriteLine("Coś poszło nie tak :( Spróbuj ponownie");
                                    break;
                            }
                        }
                        break;
                    case "2":
                        {
                            QueueMenu();
                            var res = Console.ReadLine();
                            switch (res)
                            {
                                case "1":
                                    Console.WriteLine("Wczytaj element do dodania:");
                                    string x = Console.ReadLine();
                                    Queue.pushElement(kolejka, x);
                                    break;
                                case "2":
                                    Console.WriteLine("Usunięto element z kolejki");
                                    Queue.popElement(kolejka);
                                    break;
                                case "3":
                                    Queue.isEmpty(kolejka);
                                    break;
                                case "4":
                                    Console.WriteLine("Rozmiar kolejki to: " + Queue.size(kolejka));
                                    break;
                                case "5":
                                    Console.WriteLine("Podaj element do sprawdzenia:");
                                    string z = Console.ReadLine();
                                    Queue.belongTo(kolejka, z);
                                    break;
                                case "6":
                                    Console.WriteLine("Element o jakim indeksie chcesz pobrać?");
                                    string iks = Console.ReadLine();
                                    int c;
                                    int.TryParse(iks, out c);
                                    string pobrano = Queue.popExactly(kolejka, c);
                                    Console.WriteLine("Pobrano " + pobrano + "o indeksie " + c);
                                    break;

                                default:
                                    Console.WriteLine("Coś poszło nie tak :( Spróbuj ponownie");
                                    break;
                            }
                        }
                        break;
                    case "3":
                        {
                            VectorMenu();
                            var res = Console.ReadLine();
                            switch (res)
                            {
                                case "1":
                                    Console.WriteLine("Wczytaj element do dodania:");
                                    string x = Console.ReadLine();
                                    int y;
                                    int.TryParse(x, out y);
                                    Vector.pushElement(vector, y);
                                    break;
                                case "2":
                                    Console.WriteLine("Usunięto element z wektora");
                                    Vector.popElement(vector);
                                    break;
                                case "3":
                                    Vector.isEmpty(vector);
                                    break;
                                case "4":
                                    Console.WriteLine("Rozmiar wektora to: " + Vector.size(vector));
                                    break;
                                case "5":
                                    Console.WriteLine("Podaj element do sprawdzenia:");
                                    string z = Console.ReadLine();
                                    int t;
                                    int.TryParse(z, out t);
                                    Vector.belongTo(vector, t);
                                    break;
                                case "6":
                                    Console.WriteLine("Element o jakim indeksie chcesz pobrać?");
                                    string iks = Console.ReadLine();
                                    int c;
                                    int.TryParse(iks, out c);
                                    int pobrano = Vector.popExactly(vector, c);
                                    Console.WriteLine("Pobrano " + pobrano + "o indeksie " + c);
                                    break;

                                default:
                                    Console.WriteLine("Coś poszło nie tak :( Spróbuj ponownie");
                                    break;
                            }
                        }
                        break;
                    case "4":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Coś poszło nie tak :( Spróbuj ponownie!\n");
                        break;
                }
            } while (isRunning);
        }

        public static void MainMenu()
        {
            Console.WriteLine("Witaj ponownie!");
            Console.WriteLine("Wybierz interesującą cię opcję:");
            Console.WriteLine("1 - stos");
            Console.WriteLine("2 - kolejka");
            Console.WriteLine("3 - wektor");
            Console.WriteLine("4 - wyjście");
            Console.Write("\nTwój wybór: ");
        }
        public static void QueueMenu()
        {
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("1 - Dodaj element do kolejki");
            Console.WriteLine("2 - Usuń element z kolejki");
            Console.WriteLine("3 - Sprawdź czy kolejka jest pusta");
            Console.WriteLine("4 - Sprawdź rozmiar kolejki");
            Console.WriteLine("5 - Sprawdź czy element należy do kolejki");
            Console.WriteLine("6 - Pobierz wybrany element kolejki");
            Console.Write("\nTwój wybór: ");
        }
        public static void VectorMenu()
        {
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("1 - Dodaj element do wektora");
            Console.WriteLine("2 - Usuń element z wektora");
            Console.WriteLine("3 - Sprawdź czy wektor jest pusty");
            Console.WriteLine("4 - Sprawdź rozmiar wektora");
            Console.WriteLine("5 - Sprawdź czy element należy do wektora");
            Console.WriteLine("6 - Pobierz wybrany element wektora");
            Console.WriteLine("7 - Powrót");
            Console.Write("\nTwój wybór: ");
        }
        public static void StosMenu()
        {
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("1 - Dodaj element do stosu");
            Console.WriteLine("2 - Usuń element ze stosu");
            Console.WriteLine("3 - Sprawdź czy stos jest pusty");
            Console.WriteLine("4 - Sprawdź rozmiar stosu");
            Console.WriteLine("5 - Sprawdź czy element należy do stosu");
            Console.WriteLine("6 - Pobierz wybrany element ze stosu");
            Console.WriteLine("7 - Powrót");
            Console.Write("\nTwój wybór: ");
        }
    }
}
