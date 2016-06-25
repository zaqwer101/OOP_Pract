﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pract
{
    class Organ
    {
        public Human        owner;
        public bool         blocked;            //Может ли данная часть тела функционировать
        public Equipment    equipment;          //Надетая шмотка. Управлять шмотками будет непосредственно человек
        public string       name;
        public int          armor;
        public int          hp;                 //Состояние части тела

        public Organ(Human human)
        {
            this.owner = human;
            this.armor = 0;
        }

        public void heal(int hp)                //Лечение части
        {
            this.hp += hp;
        }

        public void damage(int hp)              //Повреждение части 
        {
            this.hp -= hp;
            if(this.hp <= 0)
            {
                blocked = true;
                owner.start_bleeding();
            }
        }

        
    }
}
