using ClassImplementations.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassImplementations.Concrete
{
    public class TShirt:Product
    {
        public TShirt(int id, string name) : base(id, name)
        {
        }

        public string Size { get; set; }
        public override void WriteProductInformation()
        {
            base.WriteProductInformation();
            Console.WriteLine($" - Size: {Size}");
        }
    }
}
