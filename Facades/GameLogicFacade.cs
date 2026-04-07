using ConsoleSlots.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSlots.Facades
{
    public class GameLogicFacade
    {
        private RandomizerService _randomizerService;
        private PatternService _patternService;
        private SymbolService _symbolService;
        private ScoreService _scoreService;

        public string[,] GameArea = { { "1", "4", "3", "5" }, { "0", "1", "1", "1" } };
        public GameLogicFacade(RandomizerService randomizerService,
            PatternService patternService,
            SymbolService symbolService,
            ScoreService scoreService)
        {
            _patternService = patternService;
            _randomizerService = randomizerService;
            _symbolService = symbolService;
            _scoreService = scoreService;
        }
        public async Task Spin()
        {
            Console.WriteLine("Spinning....");
            for (int i = 0; i < GameArea.GetLength(0); i++)
            {
                for (int j = 0; j < GameArea.GetLength(1); j++)
                {
                    Console.Write(GameArea[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
