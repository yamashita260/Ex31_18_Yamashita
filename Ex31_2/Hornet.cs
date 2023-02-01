using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    internal class Hornet : Character
    {
        public Hornet(string name, float hp, float power, bool animal) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}に針攻撃!");
            if (destination.Animal)
            {
                Console.WriteLine($"{destination.name}は痛そうだ!");
                Console.WriteLine($"{destination.name}は泣き面に蜂!!!");
                destination.hp -= destination.hp;
                Console.WriteLine($"{destination.name}の残りHP{destination.hp}");
                if (destination.hp <= 0)
                {
                    Console.WriteLine($"{destination.name}はもう戦えない");
                }
            }
            else
            {
                Console.WriteLine($"{destination.name}には効果がない!");
            }
        }
    }
}
