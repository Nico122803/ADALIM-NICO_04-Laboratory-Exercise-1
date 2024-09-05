using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADALIM_04_LaboratoryExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GREETING
            Console.WriteLine("WELCOME STIERS!!!");
            Console.WriteLine("");

            //ask for apple
            Console.Write("Please enter the number of apples you want to purchase : ");
            int numberA = int.Parse(Console.ReadLine());

         
            double priceA = 32.50;

            double totalPrice = numberA * priceA;

            Console.WriteLine($"The total price of {numberA} apples is - {totalPrice:F2}.");
            
          int convertedA = (int)totalPrice;
           
            Console.WriteLine($"The value of the converted price is - {convertedA}");

            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
