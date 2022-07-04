using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassImplementations.Abstract
{
    public abstract class Product
    {
        private int _Id { get; set; }
        private string _Name { get; set; }
        public Product(int id, string name)
        {
            _Id = id;
            _Name = name;
        }

        public int UnitsInStock{ get; set; }
        public float UnitPrice { get; set; }
        public string Brand { get; set; }

        public virtual void WriteProductInformation() 
        {
            Console.Write($"Name: {_Name} - Brand: {Brand} - UnitsInStock: {UnitsInStock} - UnitPrice: {UnitPrice}") ;
        }

    }
}
