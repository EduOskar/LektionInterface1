namespace LektionInterface1
{
    public class Teckning : IArea
    {
        private double Radius { get; set; } //Parent-class that child-classes inherit from
        public Teckning() //construct containing 0 value since the value here dosent matter
        {
            this.Radius = 0;
        }

        public virtual double Area() //Method that exists for other methods to override
        {
            return 0;
        }
    }

}