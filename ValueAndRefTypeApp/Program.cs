using System;
using ValueAndReferenceTypes;

namespace ValueAndRefTypeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new ReferenceType(){x=10,y=20};
            var p2 = p1;
            p2.x = 30;
            Console.WriteLine($"P1:{p1.x} {p1.y}");
            Console.WriteLine($"P2:{p2.x} {p2.y}");
        }
    }
}
