using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.entities
{
    public class RegEmployee : Employee
    {
        public override Employee DeepCopy()
        {
            RegEmployee emp = new RegEmployee();
            emp = (RegEmployee)this.MemberwiseClone();
            emp.address = new Address
            {
                Building = emp.address.Building,
                StreetName = emp.address.StreetName,
                Cite = emp.address.Cite
            };
            emp.Name = this.Name;
            return emp;
        }

        public override Employee ShallowCopy()
        {
            return (RegEmployee)this.MemberwiseClone();
        }
    }
}
