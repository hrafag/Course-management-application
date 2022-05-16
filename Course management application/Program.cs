using Course_management_application.Servvices;
using System;

namespace Course_management_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Course Management Application !");

            int selection;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. Show the list of Groups");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("4. Show the lilst of students in the group");
                Console.WriteLine("5. Show the list of all students");
                Console.WriteLine("6. Create a new Student");
                Console.WriteLine("");
                Console.WriteLine("0. Exit");
                Console.WriteLine("\n");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                Console.Clear();
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuServices.GroupsMenu();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        default:
                            Console.WriteLine("Something went wrong");
                            break;

                    }
                }


            } while (selection !=0);
        }
    }
}
