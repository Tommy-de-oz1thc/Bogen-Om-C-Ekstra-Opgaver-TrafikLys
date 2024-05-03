using System;

namespace BackGammon
{
    public class Terning
    {
        private Random rand = new Random();

        private int number = 0;

        public Terning() { }

        public void Ryst()
        {
            number = 2;// rand.Next(1, 7);
            
        }

        public int GetTerning()
        { return number; }

    }
}
