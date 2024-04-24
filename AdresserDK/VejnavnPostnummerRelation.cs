
namespace AdresserDK
{
    public class VejnavnPostnummerRelation
    {
        public string betegnelse { get; set; }
        public string href { get; set; }
        public string vejnavn { get; set; }
        public Postnummer postnummer { get; set; }
        public float[] bbox { get; set; }
        public float[] visueltcenter { get; set; }
        public Kommuner[] kommuner { get; set; }
    }
}