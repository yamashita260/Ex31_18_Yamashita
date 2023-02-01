using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    internal class Cat : Character
    {
        public Cat(string name, float hp, float power, bool animal) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}をひっかいた!");
            Console.WriteLine($"{destination.name}はケガをした!");
            Console.WriteLine($"{destination.name}に{this.power}のダメージ!");
            if (destination.hp <= 0)
            {
                Console.WriteLine($"{destination.name}はもう戦えない");
            }
        }
    }
}
