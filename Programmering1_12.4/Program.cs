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
                    Console.WriteLine("När du är klar, tryck [ENTER]");
                    foreach(double element in temperatures) {
                        Console.WriteLine("Ange temperatur: ");
                        temperatures.Add(Convert.ToDouble(Console.ReadLine()));
                    }
                    //for(int i = 0; i < temperature.Length; i++) { // Since I'm working with vectorns, I'll make a for-loop
                    //    Console.Write("Ange temperatur: ");
                    //}
                    if(menuChoice.Key == ConsoleKey.Enter) {
                        break;
                    }
                }
                else if(menuChoice.Key == ConsoleKey.S) {
                    //for(int i = 0; i < temperature.Length; i++) {
                    //    Console.Write(temperature[i] + " ");
                    //}

                    //double sum = 0;
                    //for(int i = 0; i < temperature.Length; i++) {
                    //    sum = sum + temperature[i];
                    //}
                    //sum = sum / temperature.Length;
                    //Console.WriteLine("Medelvärdet blir {0} grader", sum);
                }
                else if(menuChoice.Key == ConsoleKey.T) {
                    Console.Write("Ange index att ta bort: ");

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


            //double[] temperature = new double[0];
            //Console.WriteLine("=== MENY === \n" +
            //                  "[L]ägg till temperaturmätning \n" +
            //                  "[S]kriv ut alla temperaturer samt medeltemeratur \n" +
            //                  "[T]a bort temperaturmätning \n" +
            //                  "[A]vsluta");
            //do {
            //    //string menuChoice = Console.ReadLine();
            //    ConsoleKeyInfo menuChoice = Console.ReadKey(true);

            //    if(menuChoice.Key == ConsoleKey.L) {
            //    //if(menuChoice == "L" || menuChoice == "l") {
            //            Console.Write("Antalet datapunker att lägga in: ");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        temperature = new double[Convert.ToInt32(Console.ReadLine())];

            //        //      INPUTS DATA FROM USER TO VECTOR
            //        for(int i = 0; i < temperature.Length; i++) { // Since I'm working with vectorns, I'll make a for-loop
            //            Console.Write("Ange temperatur: ");
            //            temperature[i] = Convert.ToDouble(Console.ReadLine());
            //        }
            //    }
            //    else if(menuChoice.Key == ConsoleKey.S) {
            //        for(int i = 0; i < temperature.Length; i++) {
            //            Console.Write(temperature[i] + " ");
            //        }

            //        double sum = 0;
            //        for(int i = 0; i < temperature.Length; i++) {
            //            sum = sum + temperature[i];
            //        }
            //        sum = sum / temperature.Length;
            //        Console.WriteLine("Medelvärdet blir {0} grader", sum);
            //    }
            //    else if(menuChoice.Key == ConsoleKey.T) {
            //        Console.Write("Ange index att ta bort: ");
            //        temperature[Convert.ToInt32(Console.ReadLine())] = 0;
            //    }
            //    else if(menuChoice.Key == ConsoleKey.A) {
            //        Console.WriteLine("Tack för denna gången!");
            //        break;
            //    }
            //    else {
            //        Console.WriteLine("=== VÄLJ NÅGOT I MENYN === \n" +
            //                  "[L]ägg till temperaturmätning \n" +
            //                  "[S]kriv ut alla temperaturer samt medeltemeratur \n" +
            //                  "[T]a bort temperaturmätning \n" +
            //                  "[A]vsluta");
            //    }
            //} while(true);



            //double[] temperatur;

            //Console.Write("Antalet datapunker att lägga in: ");
            ////int num = Convert.ToInt32(Console.ReadLine());
            //temperatur = new double[Convert.ToInt32(Console.ReadLine())];

            ////      INPUTS DATA FROM USER TO VECTOR
            //for(int i = 0; i < temperatur.Length; i++) { // Since I'm working with vectorns, I'll make a for-loop
            //    Console.Write("Ange temperatur: ");
            //    temperatur[i] = Convert.ToDouble(Console.ReadLine());
            //}

            ////      WRITES OUT DATA
            //for(int i = 0; i < temperatur.Length; i++) {
            //    Console.Write(temperatur[i] + " ");
            //}
            //Console.WriteLine();

            ////      CALCULATES AVERAGE VALUE
            //double total = 0;
            //for(int i = 0; i < temperatur.Length; i++) {
            //    total = total + temperatur[i];
            //}
            //total = total / temperatur.Length;
            //Console.WriteLine("Medelvärdet blir {0} grader", total);

            Console.ReadLine();
        }
    }
}
