namespace LektionInterface1
{
     public class Fyrkant : Teckning 
     {
        private double Radius { get; set; }
        public Fyrkant()
        {
            this.Radius = 6;
        }
        public override double Area()
        {
            double Farea = Radius * Radius;
            return Farea;
        }
     }

}