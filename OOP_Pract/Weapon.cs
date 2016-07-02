using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pract
{
    public abstract class Weapon : Equipment
    {
        public int damage;
        public abstract void attack(Human target);
    }
}
