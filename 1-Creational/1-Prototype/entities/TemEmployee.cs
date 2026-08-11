namespace _1_Prototype.entities
{
    public class TemEmployee : Employee
    {
        public override Employee DeepCopy()
        {
            TemEmployee emp = new TemEmployee();
            emp = (TemEmployee)this.MemberwiseClone();
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
            return (TemEmployee)this.MemberwiseClone();
        }
    }
}
