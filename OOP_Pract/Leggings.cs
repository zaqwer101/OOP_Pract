using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pract
{
    public class Leggings : Equipment
    {
        public Leggings(int armor, string name)
        {
            this.damage = 0; this.armor = armor;
            this.name = name;
            this.organ = "Нога";
        }
    }
}
