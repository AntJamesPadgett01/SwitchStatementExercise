using System;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5+8);
            Console.WriteLine(5%2);
            Console.WriteLine(4+2*3);
            Console.WriteLine( (4+2) * 3);
            Console.WriteLine(5.0 + 8.1);
            Console.WriteLine(   5 + 8.1);
            Console.WriteLine( 5/2); // get interger value back
            Console.WriteLine(5/2.0);// used "double" and got true value back


            int num = 6;
            Console.WriteLine(num);

            int number = 6;
            number++;
            Console.WriteLine(number);

            int number1 = 6;
            number1--;
            Console.WriteLine(number1);


            Console.WriteLine(Math.Abs(-40));

            Console.WriteLine(Math.Pow(3,2));

            Console.WriteLine(Math.Sqrt(18));

            Console.WriteLine(Math.Max(4, 90));

            Console.WriteLine(Math.Min(4,90));

            Console.WriteLine(Math.Round (4.51));
        }

    }
}
