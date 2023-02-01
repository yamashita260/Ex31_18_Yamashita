using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    internal class Cow : Character
    {
        public Cow(string name, float hp, float power, bool animal) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            if (hp >= 5)
            {
                Console.WriteLine($"{this.name}は{destination.name}に角攻撃!");
                Console.WriteLine($"{destination.name}は痛そうだ!");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ!");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りHP{destination.hp}");
                if (destination.hp <= 0)
                {
                    Console.WriteLine($"{destination.name}はもう戦えない");
                }
                else
                {
                    Console.WriteLine($"{base.name}はまだ戦える!");
                }
            }
        }
    }
}
