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
            Tank[] tankArray = new Tank[24];
            tankArray[0] = new Tank(5, 3);
            tankArray.SetValue(new Tank(3, 3), 1);
            tankArray[0].Ausgeben();
            tankArray[1].Ausgeben();
            Console.ReadLine();


            // Methode zum Hinzufügen von Elementen in einen Array
            // Wieso gibt es kein .AddValue()?
            /** Wird genutzt wenn Größe nicht bekannt ist
             * dort aber lieber dann List benutzen
            tankArray = AddElementToArray(tankArray, new Tank(10, 3));
            tankArray[2].Ausgeben();
            Tank[] AddElementToArray<Tank>(Tank[] array, Tank element)
            {
                Tank[] newArray = new Tank[array.Length + 1];
                int i;
                for (i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                newArray[i] = element;
                return newArray;
            }
            */
        }

        
    }
}
