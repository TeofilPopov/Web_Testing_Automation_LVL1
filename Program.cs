using System;
using CSharpLVL1.Animals;
using CSharpLVL1.Models;

namespace CSharpLVL1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var book = new GoldenEditionBook("Design...", "Anton", 10);
            Console.WriteLine(book);

            Cat cat = new Cat(true, "Mitzi", 4);
            Dog dog = new Dog(true, "Scharo", 6);
            Kitten kitten = new Kitten(false, "Moni", 2);
            Tomcat tomcat = new Tomcat(true, "Bojo", 3);

            cat.ProduceSound();
            Console.WriteLine(cat);
            dog.ProduceSound();
            Console.WriteLine(dog);
            kitten.ProduceSound();
            Console.WriteLine(kitten);
            tomcat.ProduceSound();
            Console.WriteLine(tomcat);
        }
    }
}
