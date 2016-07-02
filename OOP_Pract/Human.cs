using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Pract
{
    public class Human
    {
        public Human target;
        public Armor armor;
        public int total_damage, base_damage;
        public int blood;                          //Кровь чела
        public int bleeding_power;                 //Сила кровотечения int/шаг
        public int chance_for_bleeding;            //Шанс заставить противника кровоточить
        public bool isBleeding = false;
        public string name;
        public List<Item> inventory;
        public Head head;
        public Body body;
        public Hand rightHand,leftHand;
        public Leg rightLeg,leftLeg;
        public Human(string name)
        {
            this.name = name;
            onStep += _step;
            this.onAttack += base_attack;
            chance_for_bleeding = 10;
            bleeding_power = 5;
            base_damage = 5;
            total_damage = base_damage;
            this.blood = 100;
            inventory = new List<Item>();
            #region Конечности
            rightHand = new Hand(this);
            leftHand = new Hand(this);
            head = new Head(this);
            body = new Body(this);
            rightLeg = new Leg(this);
            leftLeg = new Leg(this);
            #endregion

        }
        public delegate void effects();                 //Делегат без параметров для обработки различных эффектов
        public delegate void Attack(Human target);      //Делегат для атаки 
        public event effects onTakeDamage;              //Действие при получение урона
        public event effects onStep;                    //Действие на каждый ход чела
        public event Attack onAttack;                   //Действие на атаку другого чела со всякими орб-эффектами
        /*TODO: Реализовать событие onDead */
        public event effects onDead;                    //Действие на смерть чела
        public bool isAlive()                           //Чел погибает лишь при уничтожении тела или головы или от потери крови

        {
            if (this.head.hp <= 0 || this.body.hp <= 0) return false;
            else
                if (this.blood <= 0) return false;
            else
                return true;
        }
        public void base_attack(Human target)           //Базовая атака без оружия/орб-эффектов/прочего
        {
            this.target = target;
            int limb_to_hurt = new Random().Next(7);
            switch (limb_to_hurt)
            {
                case 0:
                    Program.log += name + " промазал\n";
                    break;
                case 1:
                    target.head.damage(this.total_damage);
                    Program.log += name + " стукнул " + target.name + " по голове " + target.head.hp + "\n";
                    break;
                case 2:
                    target.body.damage(this.total_damage);
                    Program.log += name + " стукнул " + target.name + " по телу " + target.body.hp + "\n";
                    break;
                case 3:
                    target.rightHand.damage(this.total_damage);
                    Program.log += name + " стукнул " + target.name + " по правой руке " + target.rightHand.hp + "\n";
                    break;
                case 4:
                    target.leftHand.damage(this.total_damage);
                    Program.log += name + " стукнул " + target.name + " по левой руке " + target.leftHand.hp + "\n";
                    break;
                case 5:
                    target.rightLeg.damage(this.total_damage);
                    Program.log += name + " стукнул " + target.name + " по правой ноге " + target.rightLeg.hp + "\n";
                    break;
                case 6:
                    target.leftLeg.damage(this.total_damage);
                    Program.log += name + " стукнул " + target.name + " по левой ноге " + target.leftLeg.hp + "\n";
                    break;
            }

            if (limb_to_hurt != 0) //Если попал по врагу
            {
                if (chance_for_bleeding > new Random().Next(100))
                {
                    //Враг начинает кровоточить
                    target.start_bleeding();
                }
            }
        }
        public void start_bleeding()                    //Начало кровотечения
        {
            if (!isBleeding)
            {
                Program.log += name + " начал кровоточить\n";
                isBleeding = true;
                onStep += bleed;
            }
            else                                        //Или кровотечение усиливается, если враг уже был ранен
            {
                bleeding_power += 5;
            }
        }
        public void stop_bleeding()                     //Конец кровотечения

        {
            if (isBleeding)
            {
                Program.log += name + " закончил кровоточить\n";
                onStep -= bleed;
                bleeding_power = 0;
            }
        }
        public void bleed()                             //Кровотечение
        {
            blood -= bleeding_power;
            Program.log += name + " кровоточит " + blood;
            if (blood < 0) blood = 0;
        }
        private void _step()
        {
            if (isAlive() == false)
            {
                onDead();
            }
        }
        public void attack(Human target)
        {
            onAttack(target);
        }
        public void step()                              //Действие на каждый ход чела
        {
            this.onStep();
        }
        public void equip(Armor armor)
        {
            armor.equip(this);
        }               //Надеть комплект брони
        public void unequipArmor()                      //Снять броню
        {
            this.armor.unequip(this);
        }                   
        public void equip(Weapon weapon)                //Взять в руки оружие
        {
            if (!rightHand.blocked) //Если правая рука работоспособна
            {
                unequip(rightHand); //Снимаем оружие
                rightHand.equipment = weapon;//Надеваем новое
                total_damage += weapon.damage;//Прибавляем урон
                onAttack += weapon.attack;    //Устанавливаем модификаторы
            }
        }             
        public void unequip(Hand hand)                  //Снять оружие
        {
            if (hand.equipment != null)
            {
                total_damage -= hand.equipment.damage;
                onAttack -= hand.equipment.attack;
                if(isInventoryFull())
                {
                    drop(hand.equipment);
                }
                else
                {
                    inventory.Add(hand.equipment);
                }
                hand.equipment = null;
            }
        }
        public void drop(Equipment equipment)           //Выбросить вещь
        {
            throw new NotImplementedException();
            //TODO: Реализовать выброс предметов
        }
        public bool isInventoryFull()
        {
            if (inventory.Count >= 20)
            {
                return true;
            }
            else return false;
        }
    }
}