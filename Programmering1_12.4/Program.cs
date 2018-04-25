using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_12._3 {
    class Program {
        static void Main(string[] args) {
            List<double> temperatures = new List<double>(); ;
            Console.WriteLine("=== MENY === \n" +
                              "[L]ägg till temperaturmätning \n" +
                              "[S]kriv ut alla temperaturer samt medeltemeratur \n" +
                              "[T]a bort temperaturmätning \n" +
                              "[A]vsluta");
            do {
                ConsoleKeyInfo menuChoice = Console.ReadKey(true);

                if(menuChoice.Key == ConsoleKey.L) {
                        Console.Write("Ange temperatur: ");
                        temperatures.Add(Convert.ToDouble(Console.ReadLine()));
                }
                else if(menuChoice.Key == ConsoleKey.S) {
                    Console.Write("Följande temperaturer har angets: ");
                    foreach(double element in temperatures) {
                        Console.Write(element + ", ");
                    }
                    double sum = 0;
                    double midValue = 0;
                    foreach(double element in temperatures) {
                        sum = sum + element;
                        midValue = sum / temperatures.Count;
                    }
                    Console.WriteLine("\nMedeltemperaturen är: " + midValue);
                }
                else if(menuChoice.Key == ConsoleKey.T) {
                    Console.Write("Ange index att ta bort: ");
                    temperatures.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                }
                else if(menuChoice.Key == ConsoleKey.A) {
                    Console.WriteLine("Tack för denna gången!");
                    break;
                }
                else {
                    Console.WriteLine("=== VÄLJ NÅGOT I MENYN === \n" +
                              "[L]ägg till temperaturmätning \n" +
                              "[S]kriv ut alla temperaturer samt medeltemeratur \n" +
                              "[T]a bort temperaturmätning \n" +
                              "[A]vsluta");
                }
            } while(true);
            Console.ReadKey();
        }
    }
}
