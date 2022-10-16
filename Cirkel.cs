namespace LektionInterface1
{
     public class Cirkel : Teckning 
    {
        double Radius { get; set; }
        double Pi { get; set; }
        public Cirkel()
        {
            this.Radius = 4;
            this.Pi = 3.141;
        }
        public override double Area() 
        {
            double Oarea = Pi * (Radius * Radius);
            return Oarea;
        }
    }

}