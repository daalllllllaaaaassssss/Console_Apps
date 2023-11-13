// dallas
// comp sci 20
// bguh
namespace switch_statement
{
    public class switches
    {
        public static void Main()
        {
            /*
            Console.WriteLine("ENTER A NUMBER FROM 1 TO 12 YOU ########");
            int month = Convert.ToInt32 (Console.ReadLine());
            */

            /*
            if (month == 1) { Console.WriteLine("januaby!!!"); }
            else if (month == 2) { Console.WriteLine("vferbrary"); }
            else if (month == 3) { Console.WriteLine("mar"); }
            else if (month == 4) { Console.WriteLine("aprel"); }
            else if (month == 5) { Console.WriteLine("mey"); }
            else if (month == 6) { Console.WriteLine("jone"); }
            else if (month == 7) { Console.WriteLine("jollee"); }
            else if (month == 8) { Console.WriteLine("septeermber"); }
            else if (month == 9) { Console.WriteLine("wait no this is suptemeber"); }
            else if (month == 10) { Console.WriteLine("ocboter"); }
            else if (month == 11) { Console.WriteLine("nabember"); }
            else if (month == 12) { Console.WriteLine("devmeber"); }
            else { Console.WriteLine("go ###"); }
            */

            //this is legit just an easier way to do this compred to bove

            /*
            switch(month)
            {
                case 1:
                    Console.WriteLine("januaby!!!");
                    break;
                case 2:
                    Console.WriteLine("vferbrary");
                    break;
                case 3:
                    Console.WriteLine("mar");
                    break;
                case 4:
                    Console.WriteLine("aprel");
                    break;
                case 5:
                    Console.WriteLine("mey");
                    break;
                case 6:
                    Console.WriteLine("jone");
                    break;
                case 7:
                    Console.WriteLine("jollee");
                    break;
                case 8:
                    Console.WriteLine("septeermber");
                    break;
                case 9:
                    Console.WriteLine("wait no this is suptemeber");
                    break;
                case 10:
                    Console.WriteLine("ocboter");
                    break;
                case 11:
                    Console.WriteLine("nabember");
                    break;
                case 12:
                    Console.WriteLine("devmeber");
                    break;
                default:
                    Console.WriteLine("die");
                    break;
            }
            */
            Console.WriteLine("name plds");
            string name = Console.ReadLine();

            switch (name.ToLower())
            {
                case "greg":
                    Console.WriteLine("85%");
                    break;
                case "magnus":
                    Console.WriteLine("88%");
                    break;
                case "dallas":
                    Console.WriteLine("69420%");
                    break;
                case "lochlan":
                    Console.WriteLine("90%");
                    break;
                default:
                    Console.WriteLine("idk u");
                    break;
            }
        }
    }
}
