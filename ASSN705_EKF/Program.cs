using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSN705_EKF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            int num1, num2, num3;
            string firstnum, secondnum, thirdnum;
            int high, low;

            //User Input
            Console.Write("Input your first number: ");
            firstnum = Console.ReadLine();
            num1 = Convert.ToInt32(firstnum);

            Console.Write("Input your second number: ");
            secondnum = Console.ReadLine();
            num2 = Convert.ToInt32(secondnum);

            Console.Write("Input your third number: ");
            thirdnum = Console.ReadLine();
            num3 = Convert.ToInt32(thirdnum);

            //Processing
            high = Math.Max(num1, num2);
            high = Math.Max(high, num3);

            low = Math.Min(num1, num2);
            low = Math.Min(low, num3);


            //Output
            Console.WriteLine("You input the numbers: {0}, {1}, {2}", num1, num2, num3);
            Console.WriteLine("The lowest number is: {0}", low);
            Console.WriteLine("The highest number is: {0}", high);

            Console.ReadLine();

        }//end main
    }//end class
}//end program