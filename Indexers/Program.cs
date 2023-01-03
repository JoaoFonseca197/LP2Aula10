using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector vect = new MyVector(1,2);
            Console.WriteLine(vect[0]);
            Console.WriteLine(vect[1]);
            Console.WriteLine(vect["x"]);
            Console.WriteLine(vect["y"]);
            Console.WriteLine(vect["a"]);
        }
    }
}
