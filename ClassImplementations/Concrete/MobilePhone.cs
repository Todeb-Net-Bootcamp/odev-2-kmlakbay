using ClassImplementations.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassImplementations.Concrete
{
    public class MobilePhone:Product
    {
        public MobilePhone(int id, string name) : base(id, name)
        {
        }

        public short Ram { get; set; }
        public string BatteryPower { get; set; }
        public short Memory { get; set; }
        public float ScreenSize { get; set; }
        public override void WriteProductInformation()
        {
            base.WriteProductInformation();
            Console.WriteLine($" - Ram: {Ram}Gb - Memory: {Memory}Gb - ScreenSize: {ScreenSize}inch - BatteryPower: {BatteryPower}");
        }
    }
}
