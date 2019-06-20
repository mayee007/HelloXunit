using System;

namespace HelloXunit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Add(10,2));
        }

        public static int Add(int x, int y) { 
            return x + y; 
        }
    }

    

}
