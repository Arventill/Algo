using ConsoleApp1.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int age { get; set; }

        public Person(string sFName, string sLName, int iAge)
        {
            fName = sFName;
            lName = sLName;
            age = iAge;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            bool isRunning = true;
            List<Person> peopleList = new List<Person>();
            peopleList.Add(new Person("Jan", "Kowalski", 17));
            peopleList.Add(new Person("Stefan", "Kowalski", 26));
            peopleList.Add(new Person("Maciej", "Kowalski", 4));

            do
            {
                MainMenu();
                var response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        pushElement(peopleList);
                        break;
                    case "2":
                        popElement(peopleList);
                        break;
                    case "3":
                        showElements(peopleList);
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Coś poszło nie tak 😞 \nSpróbuj ponownie później");
                        break;
                }
            } while (isRunning);
        }

        public static void popElement(List<Person> nPeopleList)
        {
            bool isEmpty = nPeopleList.Count() == 0;
            if (nPeopleList.Count() == 0)
                Console.WriteLine("--kolejka jest pusta--");
            else
                nPeopleList.RemoveAt(0);
        }
        public static void pushElement(List<Person> nPeopleList)
        {
            Console.Write("Imię: ");
            string fn = Console.ReadLine();
            Console.Write("Nazwisko: ");
            string ln = Console.ReadLine();
            Console.Write("Wiek: ");
            int a = Console.Read();

            nPeopleList.Add(new Person(fn, ln, a));
        }
        public static void showElements(List<Person> nPeopleList)
        {
            if (nPeopleList.Count() == 0)
                Console.WriteLine("--kolejka jest pusta--");
            else
            {
                foreach (Person person in nPeopleList)
                {
                    Console.WriteLine("Imię: " + person.fName
                        + "\nNazwisko: " + person.lName
                        + "\nWiek: " + person.age + "\n");
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
