using System;

namespace proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 28,38,12,22 };
            int i = 0;
            int caunt=0;
            
            
            for ( i =0; i < array.Length; i++)
            {
                int sum = 0;

                while (array[i] != 0)
                {
                    int r = array[i] % 10;
                        sum = sum + r;
                    array[i] = array[i] / 10; }
                if (sum<10)
                {
                    caunt++;
                }
                

                
            }
            
            Console.WriteLine(caunt);

        }
    }
}
