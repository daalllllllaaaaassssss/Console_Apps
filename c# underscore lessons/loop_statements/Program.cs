// dallas
// comp sci 20
// idk too big of words
namespace loopers
{
    public class ofthestatements
    {
        public static void Main()
        {
            /*
            bool keepRunning = true;
            string decision = "n";
            while (keepRunning)
            {
                Console.WriteLine("loop");
                Console.WriteLine("press y 2 stop & n 2 continue");
                decision = Console.ReadLine();
                if (decision == "y") { keepRunning = false; }
            }
            */

            int count = 1;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count <= 10);
        }
    }
}