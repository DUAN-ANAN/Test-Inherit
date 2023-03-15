using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_inherit
{
    internal class abstractVSvirtual
    {
        /*
         * 示例中，Animal是一個抽象類別，定義了一個抽象方法MakeSound。
         * Dog和Cat是Animal的子類別，必須實現MakeSound方法。
         * Bird是另一個Animal的子類別，它定義了一個虛擬方法Fly和一個覆寫MakeSound方法。
         * Parrot和Penguin是Bird的子類別，Parrot覆寫了MakeSound方法，而Penguin覆寫了MakeSound方法和Fly方法。
         * 
         * 需要注意的是，抽象方法必須在抽象類別中定義，因此Animal是一個抽象類別。
         * 而虛擬方法可以在普通類別中定義，因此Bird是一個普通類別。
         * 此外，當類別繼承自一個抽象類別時，必須實現該類別中所有的抽象方法。
         * 而虛擬方法可以被子類別選擇性地覆寫或不覆寫。
         */
        public abstract class Animal
        {
            public abstract void MakeSound();
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof!");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow!");
            }
        }

        public class Bird : Animal
        {
            public virtual void Fly()
            {
                Console.WriteLine("I'm flying!");
            }

            public override void MakeSound()
            {
                Console.WriteLine("Chirp!");
            }
        }

        public class Parrot : Bird
        {
            public override void MakeSound()
            {
                Console.WriteLine("Polly wants a cracker!");
            }
        }

        public class Penguin : Bird
        {
            public override void MakeSound()
            {
                Console.WriteLine("...");
            }

            public override void Fly()
            {
                Console.WriteLine("Sorry, I can't fly.");
            }
        }

    }
}
