using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                    //Предмет экипировки    
namespace OOP_Pract
{
    public class Equipment : Item       
                                    
    {
        
        public string   organ;      //Часть тела, на которую эта хня надевается 
        public int      armor,      //Броня, добавляемая предметом
                        damage;     //Урон предмета

        public override void use()
        {
            throw new NotImplementedException();
        }
    }
}
