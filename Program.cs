using GameEquipmentInterfaceDemo.Models;
using System;

namespace GameEquipmentInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Sword s = new Sword("MasterBlade");
            s.TakeDamage(15);
            s.Equip();
            s.Sell();
        }
    }
}
