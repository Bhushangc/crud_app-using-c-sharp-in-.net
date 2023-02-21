using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace basic_crud
{
    internal class Program
    {
        static List<string> items = new List<string>();
        static string user_choice;
        static void Main(string[] args)
        {
            Menu();


        }
        static void Menu()
        {
            Console.WriteLine("Welcome to the basic crud code");
            Console.WriteLine("Press 1 to create:");
            Console.WriteLine("Press 2 to read");
            Console.WriteLine("Press 3 to update");
            Console.WriteLine("Press 4 to delete");
            Console.WriteLine("Press 5 to stop the program");
            Console.WriteLine("Please enter your number: ");
            user_choice = Console.ReadLine();
            Choice();

        }
        static void Choice()
        {
            switch (user_choice)
            {
                case ("1"):
                    Create();
                    break;
                case ("2"):
                    Read();
                    break;
                case ("3"):
                    Update();
                    break;
                case ("4"):
                    Delete();
                    break;
                case ("5"):
                    Console.WriteLine("Closing the program");
                    Console.ReadLine();
                    return;
                default: 
                    Console.WriteLine("Error");
                    Console.WriteLine("!!!!           Going back to the main menu           !!!!");
                    Console.ReadLine();
                    Menu();
                    break;

            }
        }
        static void Create()
        {
            Console.WriteLine("Enter your message: ");
            string item = Console.ReadLine();
            items.Add(item);
            Console.WriteLine("Your message has been saved");
            Console.WriteLine("!!!!           Going back to the main menu           !!!!");
            Console.ReadLine();
            Menu();

        }
        static void Read()
        {
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("This is all the message");
            Console.WriteLine("!!!!           Going back to the main menu           !!!!");
            Console.ReadLine();
            Menu();
        }
        static void Update()
        {
            Console.WriteLine("Please enter the number of message you want to delete. Remember numbering starts from 0: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine(" Message number cant be " + number);
                Console.WriteLine("!!!!           Going back to the main menu           !!!!");
                Console.ReadLine();
                Menu();
            }
            if (number >= items.Count)
            {
                Console.WriteLine(" We don't have message number " + number);
                Console.WriteLine("!!!!           Going back to the main menu           !!!!");
                Console.ReadLine();
                Menu();
            }
            Console.WriteLine("Please enter the new message:");
            string item = Console.ReadLine();
            items[number] = item;
            Console.WriteLine("Message updated");
            Console.WriteLine("!!!!           Going back to the main menu           !!!!");
            Console.ReadLine();
            Menu();
        }
        static void Delete()
        {
            Console.WriteLine("Please enter the message number you want to delete. Remember numbering starts from 0: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine(" Message number cant be " + number);
                Console.WriteLine("!!!!           Going back to the main menu           !!!!");
                Console.ReadLine();
                Menu();
            }
            if (number >= items.Count)
            {
                Console.WriteLine(" We don't have message number " + number);
                Console.WriteLine("!!!!           Going back to the main menu           !!!!");
                Console.ReadLine();
                Menu();
            }
            items.RemoveAt(number);
            Console.WriteLine("Your message has been deleted");
            Console.WriteLine("!!!!           Going back to the main menu           !!!!");
            Console.ReadLine();
            Menu();
        }
    }
}
