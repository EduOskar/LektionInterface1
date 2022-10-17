using System.Data.Common;
using System.Security.Claims;

namespace LektionInterface1
{
    public class Rektangel : Teckning
    {
        //Column of Class variables
        private double Radius; 
        private double Height;
        private bool b; //Bool for Set for Radius
        private bool a; //Bool for Set for Height 
        public Rektangel(double Radius = 4, double Height = 10) //Default values for Area in here
        {
            this.Radius = Radius; // If user wanna chaange the values 
            this.Height = Height;
            this.b = false;
            this.a = false;
        }
        public double SetR //Get and set method for access to change values inside private  variable Radius
        {
            get { return Radius; }
            set
            {
                b = false; //Sets the method to false so we can re-use the code if we wanna add new numbers later.
                while (b == false) //Added a condition to Set, mostly to play with the code, but also so the user dosent add a value lower than 1 incase of error
                {
                    if (value > 1)
                    {
                        b = true;
                    }
                    else 
                    {
                        try
                        {
                            Console.WriteLine("Skriv 2 eller högre");
                            value = double.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Du måste skriva in en siffra för att det ska fungera");
                        }
                    }
                    Radius = value; //returns users value to Radius
                }                
            }
        }
        public double SetH //Same explenation as in Radius, but for height insted and with bool a insted of bool b.
        { 
            get { return Height; }
            set 
            {
                a = false;
                while (a == false) 
                {
                    if (value >1) 
                    {
                        a = true;
                    } 
                    else
                    {
                        try
                        {
                            Console.WriteLine("Skriv 1 eller högre");
                            value = double.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Du måste skriva in en siffra för att det ska fungera");
                        }
                    }
                    Height = value;
                }
            }
        }   
        public override double Area() //overrides Area from parent-class and also contain the calculation for the program
        {
            double Rarea = Height * Radius;
            return Rarea;
        }

    }
}