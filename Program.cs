using System;
using System.Runtime.CompilerServices;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string[] students = { "Bobby", "Judy", "Sandy" };
            string[] candy = { "Zagnut", "Snickers", "Payday" };
            string[] title = { "Freshman", "Sophomore", "Junior" };

            bool keepgoing = true;
            while (keepgoing)
            {
                Console.WriteLine("Welcome to the South Harmon Institute of Technology Student Database!");
                Console.WriteLine("Which student would you like to know more about?");
                Console.WriteLine("Enter Student Number 1, 2, or 3:");
                string entry = Console.ReadLine();
                int choice = int.Parse(entry);
                if (choice < 3)
                {                   
                    keepgoing = false;
                }

                if (choice == 1)
                {
                    Console.WriteLine("Student 1 is " + students[0] + "." + " Would you like to know more? (Enter 1 for \"favorite candy\" or 2 for \"title\":");
                    string entry2 = Console.ReadLine();
                    int choice2 = int.Parse(entry2);
                    if (choice2 < 2)
                    {
                        keepgoing = false;
                    }
                    if (choice2 == 1)
                    {
                        Console.WriteLine("Bobby's favorite candy is " + candy[0] + "." + " Enter 2 for \"title\"");
                        string entry3 = Console.ReadLine();
                        int choice3 = int.Parse(entry3);
                        if (choice3 != 2)
                        {
                            keepgoing = false;
                        }
                        if (choice3 == 2)
                        {
                            Console.WriteLine("Bobby's title is " + title[0] + ".");
                        }
                    }
                }
                if (choice == 2)
                {
                    Console.WriteLine("Student 2 is " + students[1] + "." + " Would you like to know more? (Enter 1 for \"favorite candy\" or 2 for \"title\":");
                    string entry4 = Console.ReadLine();
                    int choice4 = int.Parse(entry4);
                    if (choice4 < 2)
                    {
                        keepgoing = false;
                    }
                    if (choice4 == 1)
                    {
                        Console.WriteLine("Judy's favorite candy is " + candy[1] + "." + " Enter 2 for \"title\"");
                        string entry5 = Console.ReadLine();
                        int choice5 = int.Parse(entry5);
                        if (choice5 != 2)
                        {
                            keepgoing = false;
                        }
                        if (choice5 == 2)
                        {
                            Console.WriteLine("Judy's title is " + title[1] + ".");
                        }
                    }
                }
                if (choice == 3)
                {
                    Console.WriteLine("Student 1 is " + students[2] + "." + " Would you like to know more? (Enter 1 for \"favorite candy\" or 2 for \"title\":");
                    string entry6 = Console.ReadLine();
                    int choice6 = int.Parse(entry6);
                    if (choice6 < 2)
                    {
                        keepgoing = false;
                    }
                    if (choice6 == 1)
                    {
                        Console.WriteLine("Sandy's favorite candy is " + candy[2] + "." + " Enter 2 for \"title\"");
                        string entry7 = Console.ReadLine();
                        int choice7 = int.Parse(entry7);
                        if (choice7 != 2)
                        {
                            keepgoing = false;
                        }
                        if (choice7 == 2)
                        {
                            Console.WriteLine("Sandy's title is " + title[2] + ".");
                            

                        }
                    }

                }
                Console.WriteLine("Please enter a valid input.  Goodbye.");

                Console.WriteLine("Would you like to know about another student? y/n:");
                string beginAgain = Console.ReadLine();
                if (beginAgain == "y")
                {
                    keepgoing = true;
                }
                if (beginAgain != "y")
                {
                    keepgoing = false;
                }
            }
        }
    }
}
