using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pract
{
    public class Head : Organ
    {
        public Head(Human human) : base(human)
        {
            this.name = "Голова";
            this.hp = 30;
        }
    }

}
