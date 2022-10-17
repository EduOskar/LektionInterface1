namespace LektionInterface1
{
     public class Fyrkant : Teckning  //inherit from parent-class
     {
        private double Radius { get; set; } //private class variable
        public Fyrkant() //construct
        {
            this.Radius = 6; //setting default value to 6
        }
        public override double Area() //method that overrides parentclass method and contains calculations for area for Fyrkant
        {
            double Farea = Radius * Radius;
            return Farea;
        }
     }

}