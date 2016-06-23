using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pract
{
    class Head : Organ
    {
        public Head()
        {
            this.name = "Голова";
            this.hp = 40;
        }
    }

    class CopyOfHead : Organ
    {
        public CopyOfHead()
        {
            this.name = "Голова";
            this.hp = 40;
        }
    }
}
