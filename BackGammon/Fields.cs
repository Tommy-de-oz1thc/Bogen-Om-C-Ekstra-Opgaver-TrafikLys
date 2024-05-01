using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BackGammon.Bricks;

namespace BackGammon
{
    public class Fields
    {
        private List<Bricks> listBricks = new List<Bricks>();
        public BrickColor colorBricksonField { set; get; }
        public int NR { set; get; }
        public Fields(int nr) { 
            NR = nr;
        }

        public Fields()
        {
        }
        public void AddListBricks(Bricks brick)
        {
            listBricks.Add(brick);
        }

        public List<Bricks> GetListBricks()
        {
            return listBricks;
        }
        
    }
}
