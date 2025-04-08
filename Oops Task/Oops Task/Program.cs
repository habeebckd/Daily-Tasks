using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Speak()
    {
        Console.WriteLine($"I am {Name} and I am {Age} years old.");
    }
}


class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public override void Speak()
    {
        Console.WriteLine($"I am {Name}, a {Breed}, and I am {Age} years old. ttrrr");
    }
}


class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void Speak()
    {
        Console.WriteLine($"I am {Name} and I am {Age} years old. Meow!");
    }

    public void Meow()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog("husky", 3, "akakak");
        Animal cat = new Cat("kitty", 2);

        dog.Speak();
        cat.Speak();
    }
}
