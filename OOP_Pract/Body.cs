namespace OOP_Pract
{
    public class Body : Organ
    {
        public Body(Human human) : base(human)
        {
            name = "Тело";
            hp = 50;
        }
    }
}