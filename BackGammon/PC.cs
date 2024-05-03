using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGammon
{
    public class PC
    {
        
        public PC(GameLogic gameLogic) 
        {
            var canMove = gameLogic.CanMoveBrick(1, Settings.brick2, Settings.field1.GetListBricks());
            MessageBox.Show(canMove.ToString());
            Settings.brick2 = gameLogic.MoveBrick(Settings.field1, Settings.field2, Settings.brick2, Settings.field1.GetListBricks());
            gameLogic.setLocationPictureBox();

        }
    }
}
