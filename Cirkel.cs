namespace LektionInterface1
{
     public class Cirkel : Teckning  //inherits from parent-class
    {
        private double Radius { get; set; } //class variable
        double Pi { get; set; } //another class variable for calculations later
        public Cirkel() //construct
        {
            this.Radius = 4; //sets value to 4
            this.Pi = 3.141; //sets value to 3.141
        }
        public override double Area() //methods with calculations 
        {
            double Oarea = Pi * (Radius * Radius);
            return Oarea;
        }
    }

}