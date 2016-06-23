using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Pract
{
    public class Helmet : Equipment
    {
        public Helmet(int armor)
        {
            this.damage = 0; this.armor = armor;
            this.organ = "Голова";
        }

        public override void use()
        {
            base.use();
        }
        

    }
}