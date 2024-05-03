using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BackGammon
{
    public class PC
    {
        
        public PC() 
        {
           

        }

        public void White(GameLogic gameLogic)
        {
            var canMove = gameLogic.CanMoveBrick(1, Settings.brick2, Settings.field1.GetListBricks());
            MessageBox.Show(canMove.ToString());
            Settings.brick2 = gameLogic.MoveBrick(Settings.field1, Settings.field2, Settings.brick2, Settings.field1.GetListBricks());
            gameLogic.setLocationPictureBox();
        }

        public void Black(GameLogic gameLogic)
        {
            var canMove = gameLogic.CanMoveBrick(5, Settings.brick28, Settings.field4.GetListBricks());
            MessageBox.Show(canMove.ToString());
            Settings.brick28 = gameLogic.MoveBrick(Settings.field5, Settings.field4, Settings.brick28, Settings.field5.GetListBricks());
            gameLogic.setLocationPictureBox();
        }
    }
}
