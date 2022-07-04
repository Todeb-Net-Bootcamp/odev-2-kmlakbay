using ClassImplementations.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassImplementations.Concrete
{
    public class Computer:Product
    {
        public Computer(int id, string name) : base(id, name)
        {
        }

        public short Ram { get; set; }
        public string Os { get; set; }
        public string ProccessorType { get; set; }
        public float ScreenSize { get; set; }
        public short Memory { get; set; }

        public override void WriteProductInformation()
        {
            base.WriteProductInformation();
            Console.WriteLine($" - Ram: {Ram}Gb - Memory: {Memory}Gb - Os: {Os} - ProcessorType: {ProccessorType} - ScreenSize: {ScreenSize}inch ");
        }
    }
}
