using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AiController
    {
        public List<GameNode> ColorCombination { get; set; }
        public AiController()
        {
            ColorCombination = new List<GameNode>();
            GenerateRandomCode();

            foreach (var item in ColorCombination)
            {
                Console.Write($"{item.NodeColor} - ");
            }
        }


        private void GenerateRandomCode()
        {
            ColorCombination.Add(new GameNode(1));
            ColorCombination.Add(new GameNode(2));
            ColorCombination.Add(new GameNode(3));
            ColorCombination.Add(new GameNode(4));
        }

    }
}
