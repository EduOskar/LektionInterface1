namespace LektionInterface1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Fyrkant fyr1 = new Fyrkant();
            Rektangel rek1 = new Rektangel();
            Cirkel cirk1 = new Cirkel();

            Console.WriteLine(fyr1.Area());
            Console.WriteLine(rek1.Area());
            Console.WriteLine(cirk1.Area());
          

            /*Nedanför har jag gjort en Get och Set som gör att du får välja dina egna värden för att  bestämma Arean av rekangeln! 
             Kommentera bort den om du bara vill ha bas-programmet :)  */

            
            Console.WriteLine("Skriv in två siffror som repressenterar Radius och Höjd: ");
            try
            {
                rek1.SetR = double.Parse(Console.ReadLine());
                rek1.SetH = double.Parse(Console.ReadLine());
                Console.WriteLine(rek1.Area());
                Console.WriteLine("Skriv in två nya siffror utifall du vill fortsätta programmet: ");
                rek1.SetR = double.Parse(Console.ReadLine());
                rek1.SetH = double.Parse(Console.ReadLine());
                Console.WriteLine(rek1.Area());
                Console.WriteLine("Tack för att du spelade!");
            }
            catch (Exception)
            {
                Console.WriteLine("Du måste skriva in en siffra för att programmet ska fungera");
            }
        }
    }
}