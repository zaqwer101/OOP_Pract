using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Pract
{
    public class Helmet : Equipment
    {
        public Helmet(int armor, string name)
        {
            this.name = name;
            this.damage = 0; this.armor = armor;
            this.organ = "Голова";
            
        }
    }
}