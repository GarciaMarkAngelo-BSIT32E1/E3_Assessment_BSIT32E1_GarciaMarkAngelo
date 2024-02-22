using System;
namespace IterationLoop
{
    class Loop
    {
        static void Main(string[] args)
        {
            int num = 1;
            double sqr;
            for (int i = 1; i <= 10; i++)
            {
                sqr = Math.Sqrt(num);
                Console.WriteLine(num + " " + sqr);
                num = num + 1;
            }
        }
    }
}
