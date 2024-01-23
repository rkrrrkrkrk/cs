using System;
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nArr = {1, 2, 3, 4, 5, 6, 7, 8, 9};
 
            Console.WriteLine("nArr[{0}] = {1}", 0, nArr[0]);
            Console.WriteLine("nArr[{0}] = {1}", 3, nArr[3]);
            Console.WriteLine();
 
 
            int nIndex = 0;
 
            foreach(int i in nArr)
            {
                Console.WriteLine("nArr[{0}] = {1}", nIndex++, i);
            }
        }
    }
}