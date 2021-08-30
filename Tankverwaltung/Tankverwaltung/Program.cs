using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tankverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Array tank = new Array[24];


            Tank t1 = new Tank(10, 3); // ID: 1
            t1.Ausgeben();
            Tank t2 = new Tank(10, 3); // ID: 2
            Tank t3 = new Tank(10, 3); // ID: 3
            Tank t4 = new Tank(10, 3); // ID: 4
            Tank t5 = new Tank(10, 3); // ID: 5
            Tank t6 = new Tank(10, 3); // ID: 6

            Console.WriteLine("Bitte geben sie die Höhe in Metern von ihrem neuen Tank an");
            double hoehe = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben sie den Radius in Metern von ihrem neuen Tank an");
            double radius = Convert.ToDouble(Console.ReadLine());

            Tank t7 = new Tank(hoehe, radius);
            t7.Ausgeben();
            Console.WriteLine("Bitte geben sie in ml an wieviel sie den Tank befüllen möchten.");
            double fuellen = Convert.ToDouble(Console.ReadLine());
            t7.Befuellen(fuellen);
            t7.Ausgeben();
            Console.WriteLine("Bitte geben sie in ml an wieviel sie den Tank entleeren möchten.");
            double leeren = Convert.ToDouble(Console.ReadLine());
            t7.Entleeren(leeren);
            t7.Ausgeben();


            t1.Ausgeben();
            Console.ReadLine();
        }
    }
}
