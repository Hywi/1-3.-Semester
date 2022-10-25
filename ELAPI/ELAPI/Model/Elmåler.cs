namespace ELAPI.Model
{
    public class Elmåler
    {
        public long MeterId { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
        public double Value { get; set; }
        public double ElSpotPrice { get; set; } //skal ikke kunne sette den,
                                                //skal fås fra elspotpris.dk
        public double TotalPrice { get; set; }  //Value*ElSpotPrice
    }
}
