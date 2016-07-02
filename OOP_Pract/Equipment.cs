using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                    //Предмет экипировки    
namespace OOP_Pract
{
    public abstract class Equipment : Item       
                                    
    {


        public override void use()
        {
            throw new NotImplementedException();
        }

        //public abstract void attack(Human target);
    }
}
