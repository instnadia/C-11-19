using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cello pen = new Cello();
            //pen.Open();
            //pen.Write("interfaces are awesome");
            var sq = new Squere(10);
            Console.WriteLine(sq.GetArea());
        }
    }
}
