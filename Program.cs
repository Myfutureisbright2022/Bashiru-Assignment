using System;
namespace solution
{
    class assignment
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Poly ilaro ";

            Console.Write("Enter second Integer: ");
            int g_int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second double: ");
            double g_double = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second string: ");
            string g_str = Console.ReadLine();

            Console.WriteLine(i + g_int);
            Console.WriteLine(d + g_double);
            Console.WriteLine(s + g_str);

        }

    }
}



