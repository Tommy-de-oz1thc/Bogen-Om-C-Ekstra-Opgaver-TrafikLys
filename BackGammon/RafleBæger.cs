using System;
using System.Collections.Generic;

namespace BackGammon
{
    public class RafleBæger
    {
        public List<Terning> listTerninger = new List<Terning>();

        public RafleBæger()
        {
        }

        public RafleBæger(int antalTerninger)
        {
            // Opret og tilføj det ønskede antal terninger til listen
            for (int i = 0; i < antalTerninger; i++)
            {
                listTerninger.Add(new Terning());
            }
        }

        // Andre metoder og attributter kan tilføjes her
        public List<Terning> getRafleList()
        {  
            return listTerninger;
        }

        public void Ryst()
        {
            foreach (Terning ter in listTerninger)
            {
                ter.Ryst();

            }
        }
    }
}

