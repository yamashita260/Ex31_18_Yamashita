using Ex31_hint;
using System;

namespace Ex31
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("呂布", 500000, 2000, true);
            Character character2 = new Character("ささっき", 10000, 25, true);
            Tank tank1 = new Tank("Tiger", 500000, 250, false);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125, false);
            tank2.bullet = 5;
            Cat cat1 = new Cat("猫", 80000, 800, true);
            Cow cow1 = new Cow("牛", 200000, 400, true);
            Hornet hornet1 = new Hornet("蜂", 150, 10000000, true);
            Character[] characters = { character1, character2, tank1, tank2, cow1, cat1, hornet1 };
            for (var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }
        }
    }
}