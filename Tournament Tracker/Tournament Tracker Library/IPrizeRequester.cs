using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Tracker_Library.Models;

namespace Tournament_Tracker_Library
{
    public interface IPrizeRequester
    {
        void PrizeComplete(PrizeModel model);
    }
}
