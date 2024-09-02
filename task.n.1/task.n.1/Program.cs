
namespace task.n._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceLargePetIs = 35;
            int priceSmallPetIs = 25;
         
            Console.WriteLine(" Welcome in our carpet cleaning service ");
            Console.WriteLine(" We have estimate for 30 days. ");
            Console.WriteLine(" the small pet = 25  AND  the large pet = 35 ");
            Console.Write("So pleas enter how many small pet do you have: ");
            int smallPet = int.Parse(Console.ReadLine());
            Console.Write("and how many largepets do you have: ");
            int largePet = int.Parse(Console.ReadLine());

            int large = priceLargePetIs * largePet;
            int small = priceSmallPetIs * smallPet;
            int cost = large + small;
            Console.WriteLine($"the price befour the tax is {cost}");

            double total = cost / 1.06;

            Console.WriteLine($"the price after tax is {total}");

        }
    }
}
