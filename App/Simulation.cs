using ConsoleSlots.Facades;
using ConsoleSlots.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSlots.App
{
    public  class Simulation
    {
        private GameLogicFacade _logicFacade;
        public Simulation(GameLogicFacade logicFacade)
        {
            _logicFacade = logicFacade;
        }
        public async Task Run()
        {
            Console.WriteLine("😎");
            while (true)
            {

                Console.WriteLine("Spin?");
                Console.WriteLine("Y/N");

                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine("y");
                        await _logicFacade.Spin();
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("y");
                        break;
                    default:
                        Console.WriteLine("Please input a valid key");
                        break;
                }
            }
        }
    }
}
