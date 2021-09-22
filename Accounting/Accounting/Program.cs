using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;



        static void Main(string[] args)
        {
            // für Vollbild
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            // hier beginnt die Main
            Person p = new Person("Nico", new DateTime(2000, 05, 14), "Thomas-Dehler-Weg", "3", "51109", "Köln");
            Console.WriteLine("Name: " + p.Name +
                              "\nVolljährig?: " + p.IstVolljaehrig + 
                              "\nAktuelle Adresse: " + p.AktuelleAdresseAusgeben());

            Person pm = new Person("Nico", new DateTime(2006, 05, 14), "Thomas-Dehler-Weg", "3", "51109", "Köln");
            Console.WriteLine("Name: " + pm.Name +
                              "\nVolljährig?: " + pm.IstVolljaehrig +
                              "\nAktuelle Adresse: " + pm.AktuelleAdresseAusgeben());
            Console.ReadLine();
        }
    }
}
