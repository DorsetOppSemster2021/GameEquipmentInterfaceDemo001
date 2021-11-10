using GameEquipmentInterfaceDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEquipmentInterfaceDemo.Models
{
    public class Sword : IItem, IDamagable
    {
        public string name { get; set; } 
        public int goldValue { get; set; }
        public int durability { get; set; }

        public Sword(string _name)
        {
            name = _name;
            goldValue = 100;
            durability = 100;
        }

        public void Equip()
        {
            // throw new NotImplementedException();
            Console.WriteLine($"{name} is equipped");
        }

        public void Sell()
        {
            Console.WriteLine($"{name} is sold for {goldValue} imaginary dollars!");
        }

        public void TakeDamage(int _amountOfDamage)
        {
            durability -= _amountOfDamage;

            Console.WriteLine($"{name} damaged by {_amountOfDamage}. It now has a durability of {durability}");
        }


    }
    
}
