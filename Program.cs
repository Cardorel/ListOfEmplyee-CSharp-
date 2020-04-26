using System;
using System.Collections.Generic;
using System.Linq;

namespace Program1
{
    public class Worker
    {
        static int id;
        public int NumberId
        {
            get
            {
                id++;
                return id;
            }
        }
        public string name { get; set; }
        public string position { get; set; }
        public string year { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var listOfEmplyees = new List<Worker>();

            while (true)
            {
                System.Console.WriteLine("1 --> add(enter 1 if you want to add;");
                System.Console.WriteLine("2 --> Print(Enter 2 if you want to Print;");
                System.Console.WriteLine("3 --> Print by Experience(Enter 3 to print by experience;)");
                System.Console.WriteLine("0 --> Quit(enter 0 if you want to quit");
                System.Console.WriteLine("\n");
                DateTime tmp;
                System.Console.WriteLine("please enter your number");
                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    System.Console.WriteLine("\n");
                    System.Console.WriteLine("Enter the name...");
                    string setName = Console.ReadLine();
                    System.Console.WriteLine("enter the position...");
                    string setPosition = Console.ReadLine();
                    System.Console.WriteLine("Enter the year...");
                    var setYear = Console.ReadLine();

                    if (DateTime.TryParse(string.Format("1/1/{0}", setYear), out tmp))
                    {
                        listOfEmplyees.Add(
                        new Worker { name = setName, position = setPosition, year = setYear }
                        );
                    }
                    else
                    {
                        throw new Exception("not vailde date!");
                    }
                    // break;
                }
                else if (choose == "2")
                {
                    System.Console.WriteLine("\n");
                    var getID = new Worker();

                    if (listOfEmplyees == null)
                        System.Console.WriteLine("The list is empty , please enter 1 to add the new employees in the list!");
                    else
                    {
                        System.Console.WriteLine("\n");
                        foreach (var item in listOfEmplyees)
                        {
                            System.Console.WriteLine("\n");
                            System.Console.WriteLine("Id: {0}  \nName: {1} \nPosition {2} \nYear: {3}", getID.NumberId, item.name, item.position, item.year);
                            System.Console.WriteLine("\n");
                        }
                    }
                }
                else if (choose == "3")
                {
                    var getID = new Worker();
                    var query = from x in listOfEmplyees
                                orderby x.year ascending
                                select x;
                    foreach (var item in query)
                    {
                        System.Console.WriteLine("\n");
                        System.Console.WriteLine("Id: {0}  \nName: {1} \nPosition {2} \nYear: {3}", getID.NumberId, item.name, item.position, item.year);
                        System.Console.WriteLine("\n");

                    }
                    System.Console.WriteLine("\n");
                }
                else if (choose == "0")
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine("\n");
                    Console.WriteLine("Not coorect number , please try again!");
                }
            }
        }
    }
}
