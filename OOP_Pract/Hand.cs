using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pract
{
    public class Hand : Organ
    {
        public Weapon equipment;
        public Hand(Human human) : base(human)
        {
            
            this.name = "Рука";
            this.hp = 30;
        }
    }
}
