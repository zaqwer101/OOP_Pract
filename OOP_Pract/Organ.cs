using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pract
{
    class Organ
    {
        public bool         blocked;            //Может ли данная часть тела функционировать
        public Equipment    equipment;          //Надетая шмотка. Управлять шмотками будет непосредственно человек
        public string       name;
        public int          hp                  //Состояние части тела
        {
            get
            {
                return this.hp;
            }

            set
            {
                this.hp = value >= 0 ? value : 0;
            }
        } 

        public void heal(int hp)                //Лечение части
        {
            this.hp += hp;
        }

        public void damage(int hp)              //Повреждение части 
        {
            this.hp -= hp;
        }
    }
}
