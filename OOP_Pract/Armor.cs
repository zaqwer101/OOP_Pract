using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pract
{
    class Armor : Equipment
    {
        public Armor(int armor, string name)
        {
            this.name = name;
            this.damage = 0; this.armor = armor;
            this.organ = "Тело";
        }
    }
}
