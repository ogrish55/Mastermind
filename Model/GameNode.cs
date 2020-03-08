using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GameNode
    {

        public enum Color
        {
            Green,
            Red,
            Yellow,
            White,
            Black
        }

        public Color NodeColor { get; set; }
        public int Position { get; set; }

        public bool Checked { get; set; }

        public GameNode(Color color, int position)
        {
            NodeColor = color;
            Position = position;
            Checked = false;
        }

        public GameNode(int position)
        {
            GenerateRandomColor();
            Position = position;
            Checked = false;
        }

        private void GenerateRandomColor()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int randomNumber = random.Next(1, 6);
            switch (randomNumber)
            {
                case 1:
                    NodeColor = GameNode.Color.Black;
                    break;

                case 2:
                    NodeColor = GameNode.Color.Green;
                    break;

                case 3:
                    NodeColor = GameNode.Color.Red;
                    break;

                case 4:
                    NodeColor = GameNode.Color.White;
                    break;

                case 5:
                    NodeColor = GameNode.Color.Yellow;
                    break;

            }
        }
    }
}
