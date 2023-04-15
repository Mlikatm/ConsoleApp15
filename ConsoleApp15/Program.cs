using System;
namespace project
{
    class test1
    {
        public static void Main()
        {
            int X= Convert.ToInt32 (Console.ReadLine());
            if (X % 2 == 0)
            {
                Even(X);
            }
            else
            {
                Odd (X);
            }
        }
        private static void Even(int X)
        {
            int sum = 0, zarb = 1;
            for (int i=2; i<=X ; i++)
            {
                sum += i;
                zarb *= i;
                if (i == X)
                {
                    Console.WriteLine("majmoo=" + sum);
                    Console.WriteLine("jvabzarb=" + zarb);
                }
            }
        }
        private static void even (int X)
        {
            int sum=0,zarb=1;
            for(int i=2; i <= X; i++)
            {
                sum += i;
                zarb *= i;
                if (i== X)
                {
                    Console.WriteLine("majmoo=" + sum);
                    Console.WriteLine("javabzarb=" + zarb);
                }
            }
        }
        private static void Odd(int X)
        {
            int sum=0,zarb=1;
            for(int i=1; i<=X; i++)
            {
                sum += i;
                zarb *= i;
                if(i == X)
                {
                    Console.WriteLine("majmoo=" + sum);
                    Console.WriteLine("javabzarb=" + zarb);
                }
            }
        }
    }
}