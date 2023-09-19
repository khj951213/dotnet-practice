using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class AnimalModel
    {
        public abstract void AnimalSound();
        public abstract string AnimalMusic { get; }

        public virtual void Move()
        {
            Console.WriteLine("Moving...");
        }
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class PigModel : AnimalModel
    {
        public override string AnimalMusic => "Wee wee";
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }

        public override void Move()
        {
            Console.WriteLine("Pig moving");
        }
    }

    class CatModel : AnimalModel
    {
        public override string AnimalMusic => "Meow meow";
        public override void AnimalSound()
        {
            Console.WriteLine("The cat says: meow meow");
        }

        public override void Move()
        {
            Console.WriteLine("Cat moving...");
        }
    }
}
