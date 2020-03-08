using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class NodeController
    {

        public int Round { get; set; }
        public List<GameNode> GuessList { get; set; }

        public NodeController()
        {
            Round = 0;
        }

        public void generateList()
        {
            GuessList = new List<GameNode>();
        }

        public void AddGuess(GameNode node)
        {
            GuessList.Add(node);
        }

        public Score CompareGuess(List<GameNode> codeToCrack)
        {
            Score score = new Score();
            List<GameNode> tempGuessList = new List<GameNode>(GuessList);
            List<GameNode> tempCodeList = new List<GameNode>(codeToCrack);
            CalculateBlackPoints(score, tempGuessList, tempCodeList);
            ClaculateWhitePoints(score, tempGuessList, tempCodeList);
            return score;
        }


        private void ClaculateWhitePoints(Score score, List<GameNode> tempGuessList, List<GameNode> tempCodeList)
        {
            foreach (var guess in tempGuessList)
            {
                foreach (var item in tempCodeList)
                {
                    if (guess.NodeColor == item.NodeColor && !item.Checked && !guess.Checked)
                    {
                        score.WhitePoint++;
                    }
                }
            }
        }
    

        private void CalculateBlackPoints(Score score, List<GameNode> tempGuessList, List<GameNode> tempCodeList)
        {
            foreach (var guess in tempGuessList)
            {
                foreach (var item in tempCodeList)
                {
                    if (guess.NodeColor == item.NodeColor && guess.Position == item.Position)
                    {
                        score.BlackPoint++;
                        item.Checked = true;
                        guess.Checked = true;
                    }
                }
            }
        }
    }
}
