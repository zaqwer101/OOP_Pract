using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pract
{
    class Body : Organ
    {
        public Body(Human human) : base(human)
        {
            this.name = "Тело";
            this.hp = 100;
        }
    }
}
