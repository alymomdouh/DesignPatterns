using PrototypeDesignPattern.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  prototype
            Employee tempEmp = new TemEmployee();
            tempEmp.Id = 1;
            tempEmp.Name = "aly";
            tempEmp.address = new Address { Cite = "c1", StreetName = "s1", Building = "b1" };

            Employee tempEmp2 = tempEmp.ShallowCopy();
            Employee tempEmp3 = tempEmp.DeepCopy();
            Console.WriteLine("========= Temp Emp 1 Original Values=============");
            Console.WriteLine(tempEmp.ToString());
            Console.WriteLine("========= Temp Emp 2 ShallowCopy========================");
            Console.WriteLine(tempEmp2.ToString());
            Console.WriteLine("========= Temp Emp 3 DeepCopy========================");
            Console.WriteLine(tempEmp3.ToString());

            //tempEmp.address = new Address {Cite= "new city",Building="new b",StreetName="new s" };
            tempEmp.address.Cite = "new cite";
            tempEmp.Name = "ahmed";
            tempEmp.Id = 1000;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========= Temp Emp 1 Original After Change =============");
            Console.WriteLine(tempEmp.ToString());
            Console.WriteLine("========= Temp Emp 2 ShallowCopy After Change ==========================");
            //(tempEmp.address.Cite ) will change because it reference type 
            // id ,name not change 
            Console.WriteLine(tempEmp2.ToString());
            Console.WriteLine("========= Temp Emp 3 DeepCopy After Change ==========================");
            // not change when change in tempEmp
            Console.WriteLine(tempEmp3.ToString());
            #endregion
            Console.ReadKey();
            //Console.WriteLine("test");
        }
    }
}
