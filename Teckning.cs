namespace LektionInterface1
{
    public class Teckning : IArea
    {
        double Radius { get; set; }
        public Teckning()
        {
            this.Radius = 4;
        }

        public virtual double Area() 
        {
            return 0;
        }
    }

}