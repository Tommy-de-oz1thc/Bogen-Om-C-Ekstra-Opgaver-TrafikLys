using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGammon
{
    public class SetCordinates
    {
      

        public SetCordinates() { }

        public static Bricks MoveBricks_Field_X(Bricks brick)
        {
            switch (brick.Field)
            {
                case 0:
                    brick.X = Settings.cordinates[0].x;
                    break;
                case 1:
                    brick.X = Settings.cordinates[1].x;
                    break;
                case 2:
                    brick.X = Settings.cordinates[2].x;
                    break;
                case 3:
                    brick.X = Settings.cordinates[3].x;
                    break;
                case 4:
                    brick.X = Settings.cordinates[4].x;
                    break;
                case 5:
                    brick.X = Settings.cordinates[5].x;
                    break;
                case 6:
                    brick.X = Settings.cordinates[6].x;
                    break;
                case 7:
                    brick.X = Settings.cordinates[7].x;
                    break;
                case 8:
                    brick.X = Settings.cordinates[8].x;
                    break;
                case 9:
                    brick.X = Settings.cordinates[9].x;
                    break;
                case 10:
                    brick.X = Settings.cordinates[10].x;
                    break;
                case 11:
                    brick.X = Settings.cordinates[11].x;
                    break;
                case 12:
                    brick.X = Settings.cordinates[12].x;
                    break;
                case 13:
                    brick.X = Settings.cordinates[13].x;
                    break;
                case 14:
                    brick.X = Settings.cordinates[14].x;
                    break;
                case 15:
                    brick.X = Settings.cordinates[15].x;
                    break;
                case 16:
                    brick.X = Settings.cordinates[16].x;
                    break;
                case 17:
                    brick.X = Settings.cordinates[17].x;
                    break;
                case 18:
                    brick.X = Settings.cordinates[18].x;
                    break;
                case 19:
                    brick.X = Settings.cordinates[19].x;
                    break;
                case 20:
                    brick.X = Settings.cordinates[20].x;
                    break;
                case 21:
                    brick.X = Settings.cordinates[21].x;
                    break;
                case 22:
                    brick.X = Settings.cordinates[22].x;
                    break;
                case 23:
                    brick.X = Settings.cordinates[23].x;
                    break;
                case 24:
                    brick.X = Settings.cordinates[24].x;
                    break;
                case 25:
                    brick.X = Settings.cordinates[25].x;
                    break;
                case 26:
                    brick.X = Settings.cordinates[26].x;
                    break;
                case 27:
                    brick.X = Settings.cordinates[27].x;
                    break;
                case 28:
                    brick.X = Settings.cordinates[28].x;
                    break;
                case 29:
                    brick.X = Settings.cordinates[29].x;
                    break;
                case 30:
                    brick.X = Settings.cordinates[30].x;
                    break;
            }
            return brick;
        }
    }
}
