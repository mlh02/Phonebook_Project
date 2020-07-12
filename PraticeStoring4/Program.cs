using System;
using System.Collections.Generic;
using System.Linq;

namespace PraticeStoring4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();

            while (true)
            {
                Console.WriteLine("Please choose what you want to do\n" +
                   "1- New Phone Number\n" +
                   "2- Show Phone List\n" +
                   "3- Delete Name\n" +
                   "4- Exit Out");
                int ToDorespond = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------");

                Console.WriteLine();
                switch (ToDorespond)
                {
                    case 1:
                        {
                            Console.WriteLine("What is the name of your contact?");
                            string contactName = Console.ReadLine();

                            Console.WriteLine("What is the number of your contact?");
                            
                            string contactNumber = Console.ReadLine();

                            
                            // phoneNumber check
                            string stringNumber = contactNumber.ToString();
                            if (stringNumber.Length == 10)
                            {
                                People.Add(new Person(contactName, contactNumber, People.Count + 1));
                            }
                            else
                            {
                                Console.WriteLine("Invalid Phone number!");
                                break;
                            }
                            
                            
                        break;

                        }
                    case 2:
                        {
                            if (People.Count == 0)
                            {
                                Console.WriteLine("Nothing to show...");
                            }

                            
                            foreach (var person in People)
                            {
                                Console.WriteLine("-------------------------------------");
                                //Format Phone Number
                                string p = person._phoneNumber;
                                string formatedPhoneNumber = string.Format("({0}) {1}-{2}", p.Substring(0, 3), p.Substring(3, 3), p.Substring(6, 4));

                                //Format name
                                string properName = UppercaseFirst(person._name);
                                //Print Person info
                                Console.WriteLine($"Name Is : {properName} \n" +
                                    $"Phone Number Is : {formatedPhoneNumber} \n" +
                                    $"User ID : {person._id}");
                                Console.WriteLine("-------------------------------------");

                            }
                            break;
                        }
                    case 3:
                        {
                            if (People.Count == 0)
                            {
                                Console.WriteLine("Nothing to show...");
                            }

                            foreach (var person in People)
                            {
                                Console.WriteLine($"Name: {person._name}'s \n" +
                                    $"ID: {person._id}");

                            }
                            Console.WriteLine("What number would you like to remove?");
                            int removeNum = int.Parse(Console.ReadLine());
                            
                            foreach (var person in People.ToList())
                            {
                                if (person._id == People[removeNum - 1]._id)
                                {
                                    int acutalRemoveNum = removeNum - 1;
                                    People.RemoveAt(acutalRemoveNum);
                                }

                            }
                            Console.WriteLine("-------------------------------------");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Exiting");
                            Environment.Exit(1);
                            break;
                        }
                }

            }
        }

        private static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
