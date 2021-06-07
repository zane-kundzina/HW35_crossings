using System;
using System.Collections.Generic;
using System.Text;

namespace HW35_crossings
{
    public class RouteManager
    {
        private List<Route> _routes { get; set; } = new List<Route>();

        public void CreateNewRoute()
        {
            Route route = new Route();
            Random rd = new Random();

            Console.Write("Enter name of the new route: ");
            route.Name = Console.ReadLine();
            
            for (int i = 0; i < route.crossings.Length; i++)
            {
                int state = rd.Next(2);
                if (state == 0)
                {
                    route.crossings[i] = false;                    
                }
                else
                {
                    route.crossings[i] = true;                    
                }
            }

            _routes.Add(route);

            Console.WriteLine();
        }

        public void PrintAllRoutes()
        {
            if (_routes.Count != 0)
            {
                Console.WriteLine("We have following routes and crosings states: ");
                foreach (var route in _routes)
                {
                    route.PrintCrossings();
                }
            }
            else
            {
                Console.WriteLine("List is empty. Nothing to print.\n");
            }
        }

        
    }
}
