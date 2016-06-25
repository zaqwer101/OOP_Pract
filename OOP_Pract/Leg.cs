using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pract
{
    class Leg : Organ
    {
        public Leg(Human human) : base(human)
        {
            this.hp = 30;
            this.name = "Нога";
        }
    }

}
