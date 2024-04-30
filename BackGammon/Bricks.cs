
namespace BackGammon
{
    public struct Bricks
    {
        public enum BrickColor
        {
            Black,
            White
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int Field { set; get; }
        public BrickColor Color { get; set; }
        public int BrickNr {get;}
        public Bricks() { }
        public Bricks(int bricknr, string color, int x, int y, int field)
        { 
            this.BrickNr = bricknr;
            Color = ParseColor(color);
            X = x;
            Y = y;
            Field = field;
        }
        private BrickColor ParseColor(string color)
        {
            switch (color.ToLower())
            {
                case "black":
                    return BrickColor.Black;
                case "white":
                    return BrickColor.White;
                default:
                    throw new ArgumentException("Invalid color specified.");
            }
        }

       
    }
}