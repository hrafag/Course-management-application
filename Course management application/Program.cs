using System;

namespace Course_management_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wwelcome to the Course Management Application !");

            //int selection
            int selection;
            do
            {
                Console.WriteLine("1. Create the new Group");
                Console.WriteLine("2. Show the list of Groups");
                Console.WriteLine("3. Edit Groups");
                Console.WriteLine("4. Show the lilst of students in the group");
                Console.WriteLine("5. Show the list of all students");
                Console.WriteLine("6. Create the new Student");
                Console.WriteLine("7. Delete any strudent");
                Console.WriteLine("0. Exit");
                bool result = int.TryParse(Console.ReadLine(), out selection);


            } while (selection!=0);
        }
    }
}
