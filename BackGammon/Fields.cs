using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BackGammon.Bricks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BackGammon
{
    public class Fields
    {
       
        private List<Bricks> listBricks = new List<Bricks>();
       
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

        public void RemoveListBricks()
        {
            listBricks.RemoveAt(listBricks.Count - 1);
        }

        public void ClearList()
        { listBricks.Clear(); }

        public List<Bricks> GetListBricks()
        {
            return listBricks;
        }
        
    }
}
