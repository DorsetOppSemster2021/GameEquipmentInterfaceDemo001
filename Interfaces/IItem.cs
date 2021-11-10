using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEquipmentInterfaceDemo.Interfaces
{
    interface IItem
    {
        string name { get; set; }
        int goldValue { get; set; }
        void Equip();
        void Sell();
    }


    interface IDamagable {
    
        int durability { get; set; }

        void TakeDamage(int _amount);


    
    }


}
