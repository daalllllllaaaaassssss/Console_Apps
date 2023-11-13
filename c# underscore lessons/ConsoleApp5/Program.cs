// dallas
// comp sci 20
//
namespace wörk
{
    public class help
    {
        public static void Main()
        {
            Console.WriteLine("pay \nwhats ur pay \nper hour btw");
            int pay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how much hours do u wörk......");
            int hours = Convert.ToInt32(Console.ReadLine());

            int t = 0;

            if (hours > 40)
            {

                t = hours - 40;

            }

            int reg = pay * hours;
            double over = t * 1.5 * pay;
            double total = reg + over;

            Console.WriteLine("u get payed $" + reg + " per day");
            Console.WriteLine("plus the $" + over + " overtime");
            Console.WriteLine("ur total pay is $" + total);
        }
    }
}