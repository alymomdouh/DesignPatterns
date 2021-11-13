using Builder.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void WriteColoredLine( string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Word 1,");
            sb.Append("Word 2"); 
            WriteColoredLine(sb.ToString(), ConsoleColor.Cyan);
            //////////////
             WriteColoredLine("***Builder Pattern***",ConsoleColor.Yellow);
            Director director = new Director();
            IBuilder carBuilder = new Car("Jeep");
            IBuilder motorCycleBuilder = new MotorCycle("Honda"); 

            // Making Car
             director.Construct(carBuilder);
            Product car = carBuilder.GetVehicle();
            WriteColoredLine($"Car {car.Show()}");
            
            //Making MotorCycle
            director.Construct(motorCycleBuilder);
            Product motorCycle = motorCycleBuilder.GetVehicle();
            WriteColoredLine($"MotorCycle {motorCycle.Show()}"); 
            Console.ReadKey();
        }
    }
}
