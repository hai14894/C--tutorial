using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(2));

        }
        static void SayHi(string name){
            Console.WriteLine("hello " + name);
        }

        static double cube(int num){
            double result = Math.Pow( num, 3);
            return result;
        }
    }
}
