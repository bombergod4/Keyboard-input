using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_input
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greetings
            DateTime year = DateTime.Today;
            string yearS = (year.ToString("yyyy"));
            int yearI = Convert.ToInt32(yearS);
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            string ageS = Console.ReadLine();
            int ageI = Convert.ToInt32(ageS);
            Console.WriteLine("Hello " + name + ", you were born in the year " + (yearI - ageI));
            //Adder
            Console.WriteLine("Please enter a number");
            string firstS = Console.ReadLine();
            int firstI = Convert.ToInt32(firstS);
            Console.WriteLine("Please enter a number");
            string secondS = Console.ReadLine();
            int secondI = Convert.ToInt32(secondS);
            Console.WriteLine("Please enter a number");
            string thirdS = Console.ReadLine();
            int thirdI = Convert.ToInt32(thirdS);
            Console.WriteLine("The total of your numbers is " + (firstI + secondI + thirdI));
            //Distance
            Console.WriteLine("Please enter a distance (kilometers)");
            string distance1S = Console.ReadLine();
            double distance1D  = Convert.ToDouble(distance1S);
            Console.WriteLine("Please enter a distance (kilometers)");
            string distance2S = Console.ReadLine();
            double distance2D = Convert.ToDouble(distance2S);
            Console.WriteLine("Please enter a distance (kilometers)");
            string distance3S = Console.ReadLine();
            double distance3D = Convert.ToDouble(distance3S);
            Console.WriteLine("The average of your three distances is " + Math.Round(((distance1D + distance2D + distance3D) / 3),2));
            // Hypoteneuse
            Console.WriteLine("Please enter side A");
            string sideAs = Console.ReadLine();
            double sideAd = Convert.ToDouble(sideAs);
            Console.WriteLine("Please enter side B");
            string sideBs = Console.ReadLine();
            double sideBd = Convert.ToDouble(sideBs);
            Console.WriteLine("Side C of the triangle is " + Math.Round(Math.Sqrt((sideAd * sideAd + sideBd * sideBd)),2));
        }
    }
}
