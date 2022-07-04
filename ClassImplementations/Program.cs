using ClassImplementations.Abstract;
using ClassImplementations.Concrete;
using System;

namespace ClassImplementations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(1, "Dell G3 Notebook");
            //Abstract Product Class'ından gelen özellikler
            computer.UnitPrice = 15000;
            computer.UnitsInStock = 100;
            computer.Brand = "Dell";
            //computer class'ından gelen özellikler
            computer.ScreenSize = 15.6f;
            computer.Ram = 8;
            computer.Os = "Windows 10";
            computer.ProccessorType = "Intel Core i7";
            computer.Memory = 512;
            computer.WriteProductInformation();

            MobilePhone mobilePhone = new MobilePhone(2, "Apple Iphone 12 mini");
            //Abstract Product Class'ından gelen özellikler
            mobilePhone.UnitPrice = 16200;
            mobilePhone.UnitsInStock = 25;
            mobilePhone.Brand = "Iphone";
            //MobilePhone class'ından gelen özellikler
            mobilePhone.ScreenSize = 5.6f;
            mobilePhone.Ram = 4;
            mobilePhone.Memory = 128;
            mobilePhone.BatteryPower = "1800-2400 mAh";
            mobilePhone.WriteProductInformation();

            TShirt tshirt = new TShirt(3, "Mavi Basic Tshirt");
            //Abstract Product Class'ından gelen özellikler
            tshirt.UnitPrice = 125;
            tshirt.UnitsInStock = 220;
            tshirt.Brand = "Mavi";
            //Tshirt class'ından gelen özellikler
            tshirt.Size = "L";
            tshirt.WriteProductInformation();
        }
    }
}
