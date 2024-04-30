using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGammon
{
    public class SetBricks
    {
        Settings set = new Settings();
        public SetBricks() 
        {
            Settings.brick1 = new Bricks(1, "White", Settings.cordinates[1].x, Settings.cordinates[1].y + Settings.y_heigh[0], 1);
            Settings.brick2 = new Bricks(2, "White", Settings.cordinates[1].x, Settings.cordinates[1].y + Settings.y_heigh[1], 1);
            Settings.brick3 = new Bricks(3, "White", Settings.cordinates[12].x, Settings.cordinates[12].y + Settings.y_heigh[0], 12);
            Settings.brick4 = new Bricks(4, "White", Settings.cordinates[12].x, Settings.cordinates[12].y + Settings.y_heigh[1], 12);
            Settings.brick5 = new Bricks(5, "White", Settings.cordinates[12].x, Settings.cordinates[12].y + Settings.y_heigh[2], 12);
            Settings.brick6 = new Bricks(6, "White", Settings.cordinates[12].x, Settings.cordinates[12].y + Settings.y_heigh[3], 12);
            Settings.brick7 = new Bricks(7, "White", Settings.cordinates[12].x, Settings.cordinates[12].y + Settings.y_heigh[4], 12);
            Settings.brick8 = new Bricks(8, "White", Settings.cordinates[17].x, Settings.cordinates[17].y - Settings.y_heigh[0], 17);
            Settings.brick9 = new Bricks(9, "White", Settings.cordinates[17].x, Settings.cordinates[17].y - Settings.y_heigh[1], 17);
            Settings.brick10 = new Bricks(10, "White", Settings.cordinates[17].x, Settings.cordinates[17].y -  Settings.y_heigh[2], 17);
            Settings.brick11 = new Bricks(11, "White", Settings.cordinates[19].x, Settings.cordinates[19].y - Settings.y_heigh[0], 19);
            Settings.brick12 = new Bricks(12, "White", Settings.cordinates[19].x, Settings.cordinates[19].y - Settings.y_heigh[1], 19);
            Settings.brick13 = new Bricks(13, "White", Settings.cordinates[19].x, Settings.cordinates[19].y - Settings.y_heigh[2], 19);
            Settings.brick14 = new Bricks(14, "White", Settings.cordinates[19].x, Settings.cordinates[19].y - Settings.y_heigh[3], 19);
            Settings.brick15 = new Bricks(15, "White", Settings.cordinates[19].x, Settings.cordinates[19].y - Settings.y_heigh[4], 19);
            Settings.brick16 = new Bricks(16, "Black", Settings.cordinates[13].x, Settings.cordinates[13].y - Settings.y_heigh[0], 13);
            Settings.brick17 = new Bricks(17, "Black", Settings.cordinates[13].x, Settings.cordinates[13].y - Settings.y_heigh[1], 13);
            Settings.brick18 = new Bricks(18, "Black", Settings.cordinates[13].x, Settings.cordinates[13].y - Settings.y_heigh[2], 13);
            Settings.brick19 = new Bricks(19, "Black", Settings.cordinates[13].x, Settings.cordinates[13].y - Settings.y_heigh[3], 13);
            Settings.brick20 = new Bricks(20, "Black", Settings.cordinates[13].x, Settings.cordinates[13].y - Settings.y_heigh[4], 13);
            Settings.brick21 = new Bricks(21, "Black", Settings.cordinates[7].x, Settings.cordinates[7].y + Settings.y_heigh[0], 7);
            Settings.brick22 = new Bricks(22, "Black", Settings.cordinates[7].x, Settings.cordinates[7].y + Settings.y_heigh[1], 7);
            Settings.brick23 = new Bricks(23, "Black", Settings.cordinates[7].x, Settings.cordinates[7].y + Settings.y_heigh[2], 7);
            Settings.brick24 = new Bricks(24, "Black", Settings.cordinates[7].x, Settings.cordinates[7].y + Settings.y_heigh[3], 7);
            Settings.brick25 = new Bricks(25, "Black", Settings.cordinates[7].x, Settings.cordinates[7].y + Settings.y_heigh[4], 7);
            Settings.brick26 = new Bricks(26, "Black", Settings.cordinates[5].x, Settings.cordinates[5].y + Settings.y_heigh[0], 5);
            Settings.brick27 = new Bricks(27, "Black", Settings.cordinates[5].x, Settings.cordinates[5].y + Settings.y_heigh[1], 5);
            Settings.brick28 = new Bricks(28, "Black", Settings.cordinates[5].x, Settings.cordinates[5].y + Settings.y_heigh[2], 5);
            Settings.brick29 = new Bricks(29, "Black", Settings.cordinates[24].x, Settings.cordinates[24].y - Settings.y_heigh[0], 24);
            Settings.brick30 = new Bricks(30, "Black", Settings.cordinates[24].x, Settings.cordinates[24].y - Settings.y_heigh[1], 24);

            Settings.field1.AddListBricks(Settings.brick1);
            Settings.field1.AddListBricks(Settings.brick2);
            Settings.field12.AddListBricks(Settings.brick3);
            Settings.field12.AddListBricks(Settings.brick4);
            Settings.field12.AddListBricks(Settings.brick5);
            Settings.field12.AddListBricks(Settings.brick6);
            Settings.field12.AddListBricks(Settings.brick7);
            Settings.field17.AddListBricks(Settings.brick8);
            Settings.field17.AddListBricks(Settings.brick9);
            Settings.field19.AddListBricks(Settings.brick10);
            Settings.field19.AddListBricks(Settings.brick11);
            Settings.field19.AddListBricks(Settings.brick12);
            Settings.field19.AddListBricks(Settings.brick13);
            Settings.field19.AddListBricks(Settings.brick14);
            Settings.field19.AddListBricks(Settings.brick15);
            Settings.field6.AddListBricks(Settings.brick16);
            Settings.field6.AddListBricks(Settings.brick17);
            Settings.field6.AddListBricks(Settings.brick18);
            Settings.field6.AddListBricks(Settings.brick19);
            Settings.field6.AddListBricks(Settings.brick20);
            Settings.field8.AddListBricks(Settings.brick21);
            Settings.field8.AddListBricks(Settings.brick22);
            Settings.field8.AddListBricks(Settings.brick23);
            Settings.field13.AddListBricks(Settings.brick24);
            Settings.field13.AddListBricks(Settings.brick25);
            Settings.field13.AddListBricks(Settings.brick26);
            Settings.field13.AddListBricks(Settings.brick27);
            Settings.field13.AddListBricks(Settings.brick28);
            Settings.field24.AddListBricks(Settings.brick29);
            Settings.field24.AddListBricks(Settings.brick30);
        }
    }
}
