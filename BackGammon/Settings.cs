using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGammon
{
    public class Settings
    {
        // Opret en tuple med 24 koordinater
        public static (int x, int y)[] cordinates = new (int, int)[28];
        public static List<int> y_heigh = [0, 35, 70, 105, 140, 175, 210, 245, 270];

        public static Fields field0 = new Fields();
        public static Fields field1 = new Fields(1);
        public static Fields field2 = new Fields(2);
        public static Fields field3 = new Fields(3);
        public static Fields field4 = new Fields(4);
        public static Fields field5 = new Fields(5);
        public static Fields field6 = new Fields(6);
        public static Fields field7 = new Fields(7);
        public static Fields field8 = new Fields(8);
        public static Fields field9 = new Fields(9);
        public static Fields field10 = new Fields(10);
        public static Fields field11 = new Fields(11);
        public static Fields field12 = new Fields(12);
        public static Fields field13 = new Fields(13);
        public static Fields field14 = new Fields(14);
        public static Fields field15 = new Fields(15);
        public static Fields field16 = new Fields(16);
        public static Fields field17 = new Fields(17);
        public static Fields field18 = new Fields(18);
        public static Fields field19 = new Fields(19);
        public static Fields field20 = new Fields(20);
        public static Fields field21 = new Fields(21);
        public static Fields field22 = new Fields(22);
        public static Fields field23 = new Fields(23);
        public static Fields field24 = new Fields(24);
        public static Fields field25 = new Fields(25);
        public static Fields field26 = new Fields(26);
        public static Fields field27 = new Fields(27);
      
        public static Bricks brick1 = new Bricks();
        public static Bricks brick2 = new Bricks();
        public static Bricks brick3 = new Bricks();
        public static Bricks brick4 = new Bricks();
        public static Bricks brick5 = new Bricks();
        public static Bricks brick6 = new Bricks();
        public static Bricks brick7 = new Bricks();
        public static Bricks brick8 = new Bricks();
        public static Bricks brick9 = new Bricks();
        public static Bricks brick10 = new Bricks();
        public static Bricks brick11 = new Bricks();
        public static Bricks brick12 = new Bricks();
        public static Bricks brick13 = new Bricks();
        public static Bricks brick14 = new Bricks();
        public static Bricks brick15 = new Bricks();
        public static Bricks brick16 = new Bricks();
        public static Bricks brick17 = new Bricks();
        public static Bricks brick18 = new Bricks();
        public static Bricks brick19 = new Bricks();
        public static Bricks brick20 = new Bricks();
        public static Bricks brick21 = new Bricks();
        public static Bricks brick22 = new Bricks();
        public static Bricks brick23 = new Bricks();
        public static Bricks brick24 = new Bricks();
        public static Bricks brick25 = new Bricks();
        public static Bricks brick26 = new Bricks();
        public static Bricks brick27 = new Bricks();
        public static Bricks brick28 = new Bricks();
        public static Bricks brick29 = new Bricks();
        public static Bricks brick30 = new Bricks();

        public Settings() 
        {
           

        }

        public void Cordinates()
        {

            // Tilføj koordinater til tuplen
            cordinates[0] = (1000, 95);
            cordinates[1] = (217, 95);
            cordinates[2] = (266, 95);
            cordinates[3] = (315, 95);
            cordinates[4] = (364, 95);
            cordinates[5] = (413, 95);
            cordinates[6] = (462, 95);
            cordinates[7] = (556, 95);
            cordinates[8] = (605, 95);
            cordinates[9] = (654, 95);
            cordinates[10] = (703, 95);
            cordinates[11] = (752, 95);
            cordinates[12] = (801, 95);
            cordinates[13] = (217, 639);
            cordinates[14] = (266, 639);
            cordinates[15] = (315, 639);
            cordinates[16] = (364, 639);
            cordinates[17] = (413, 639);
            cordinates[18] = (462, 639);
            cordinates[19] = (556, 639);
            cordinates[20] = (605, 639);
            cordinates[21] = (654, 639);
            cordinates[22] = (703, 639);
            cordinates[23] = (752, 639);
            cordinates[24] = (801, 639);
            cordinates[25] = (183, 295);
            cordinates[26] = (835, 295);
            cordinates[27] = (801, 639);

            
        }

    }
}
