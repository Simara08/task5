using System;

namespace proje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int m = 50;
            int i;
            int caunt = 0;
            for (i =n; i < m; i++)
            {
                if (i%15==0)
                {
                    caunt++;
                }

            }
            Console.WriteLine(caunt);
        }
    }
}
