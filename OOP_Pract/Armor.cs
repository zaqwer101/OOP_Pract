using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pract
{
    public abstract class Armor : Equipment
    {
        public int head_armor, body_armor,      //Значения брони для каждой части тела
            hands_armor, legs_armor; 

        public Armor(int head_armor, int body_armor, int hands_armor, int legs_armor)
        {
            this.head_armor = head_armor;
            this.body_armor = body_armor;
            this.hands_armor = hands_armor;
            this.legs_armor = legs_armor;
        }

        public void equip(Human human)          //Надеть предмет на чела
        {
            if (human.inventory.Contains(this))
            {
                human.armor = this;
                human.head.armor = head_armor;
                human.body.armor = body_armor;
                human.rightHand.armor = hands_armor; human.leftHand.armor = hands_armor;
                human.rightLeg.armor = legs_armor; human.leftLeg.armor = legs_armor;
                human.inventory.Remove(this);
                human.onStep += step;
                human.onTakeDamage += takeDamage;
            }
        }
        public void unequip(Human human)        //Снять предмет с чела
        {
            human.head.armor = 0;
            human.body.armor = 0;
            human.rightHand.armor = 0; human.leftHand.armor = 0;
            human.rightLeg.armor = 0; human.leftLeg.armor = 0;
            if (!human.isInventoryFull())
            {
                human.inventory.Add(this);
            }
            else
                human.drop(this);
            human.armor = null;
            human.onStep -= step;
        }   

        public abstract void step();            //Разные плюшки, которые броня делает каждый ход, ака реген хп, атака противника, прочее(Добавляется к событию onStep чела-носителя)
        public abstract void takeDamage();      //Разные вещи, происходящие при атаке героя, ака ответка, блок, прочее
    }
}
