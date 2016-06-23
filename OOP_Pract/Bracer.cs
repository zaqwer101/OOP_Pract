using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Pract
{
    public class Bracer : Equipment
    {
        public Bracer(int armor, string name)
        {
            this.name = name;
            damage = 0; this.armor = armor;
            organ = "Рука";
        }
    }
}