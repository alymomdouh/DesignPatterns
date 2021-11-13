using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.entities
{
    public class Product  // or Builder
    {// collect all parts  very thing is a product
        private LinkedList<string> parts;
        public Product() { parts = new LinkedList<string>(); }
        public void Add(string part)
        {
            //Add parts
            parts.AddLast(part);
        }
        public string Show()
        {
             StringBuilder result = new StringBuilder();
            result.AppendLine("Product components are :");
            foreach (string part in parts)
                result.AppendLine(part);

            return result.ToString();
        }
    }
}
