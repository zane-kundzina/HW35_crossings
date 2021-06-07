using System;
using System.Collections.Generic;
using System.Text;

namespace HW35_crossings
{
    public class Route
    {

        public string Name { get; set; }
        public bool[] crossings { get; set; } = new bool[5];

        public bool routeState { get; set; }

        public void PrintCrossings()
        {
            Console.WriteLine($"Route {Name}: ");
            for (int i = 0; i < crossings.Length; i++)
            {                
                if (crossings[i])
                {                    
                    Console.Write("Open  ");
                }
                else
                {                    
                    Console.Write("Closed  ");
                }
            }
            Console.WriteLine();
            CheckRouteState();
        }

        private void CheckRouteState()
        {
            routeState = true;

            for (int i = 0; i < crossings.Length; i++)
            {
                if (!crossings[i])
                {
                    routeState = false;
                }               
            }

            if (!routeState)
            {
                Console.WriteLine("It is not possible to pass the route without stopping.");
                Console.WriteLine("Following crossings are closed:");
                for (int i = 0; i < crossings.Length; i++)
                {
                    if (!crossings[i])
                    {
                        Console.Write((i + 1) + " ");
                    }
                }
                Console.WriteLine();
            }
           
        }

    }
}
