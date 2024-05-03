using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGammon
{
    public class Move
    {
        public Bricks Brick { get; set; }
        public int StartField { get; set; }
        public int EndField { get; set; }
        public int Dice {  get; set; }  
        public Move(Bricks brick, int startField, int endField, int dice)
        {
            Brick = brick;
            StartField = startField;
            EndField = endField;
            Dice = dice;
        }
    }

}
