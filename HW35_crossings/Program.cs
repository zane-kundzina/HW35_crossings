using System;
using System.Collections.Generic;

namespace HW35_crossings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Image the situation then you have to plan your route.
            // Your route contains several crossings. Each crossing could be opened or closed.
            // Your program has to determine, is it possible to get through all the crossings, and print out which crossings are closed.
            // During the simplest solution, you should just declare crossings and are they opened or closed.
            // After the simplest solution works, modify your solution that it can handle a list of possible routes.
            // Your program should find, which routes are fully opened and which not.

            RouteManager manager = new RouteManager();
            int input;

            while (true)
            {
                Console.WriteLine("---------------- ROUTE MANAGER ---------------- ");
                Console.WriteLine("Enter MENU option:");
                Console.WriteLine("1 - Add new route");
                Console.WriteLine("2 - Print all routes");
                Console.WriteLine("3 - Exit");
                Console.WriteLine();

                while (true)
                {
                    try
                    {
                        input = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.Write("Input not valid. Please try again: ");
                    }
                }
                Console.WriteLine();

                MenuEnum menu = (MenuEnum)input;

                switch (menu)
                {
                    case MenuEnum.CreateRoute:
                        manager.CreateNewRoute();
                        break;

                    case MenuEnum.PrintRoutes:
                        manager.PrintAllRoutes();
                        break;                    

                    case MenuEnum.Exit:
                        Console.WriteLine("See you next time! Bye!");
                        return;
                    default:
                        Console.WriteLine("No such command in MENU! Try again: ");
                        continue;
                }
            }

            

        }

        

        
    }
}
