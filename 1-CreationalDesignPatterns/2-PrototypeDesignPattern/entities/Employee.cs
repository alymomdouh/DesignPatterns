using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.entities
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address address { get; set; }
        public abstract Employee ShallowCopy();
        public abstract Employee DeepCopy();
        public override string ToString()
        {
            //return base.ToString();
            return
                $@"  
                    ID : {this.Id}   
                    Name:{this.Name}    
                    Address :
                    {this.address.Cite} ,{this.address.StreetName},{this.address.Building}
                ";
        }

    }
}
