using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Score
    {
        public int WhitePoint { get; set; }
        public int BlackPoint { get; set; }

        public Score()
        {
            WhitePoint = 0;
            BlackPoint = 0;
        }
    }
}
