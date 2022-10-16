namespace LektionInterface1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Fyrkant fyr1 = new Fyrkant();
            Rektangel rek1 = new Rektangel();
            Cirkel cirk1 = new Cirkel();
            

            rek1.SetR = double.Parse(Console.ReadLine());
            rek1.SetH = double.Parse(Console.ReadLine());
            Console.WriteLine(rek1.Area());
            rek1.SetR = double.Parse(Console.ReadLine());
            rek1.SetH = double.Parse(Console.ReadLine());
            Console.WriteLine(rek1.Area());


        }

    }

}