using System;
using CSharpLVL1.Models;

namespace CSharpLVL1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Child kid = new Child("Teo", 10);
            //Child girl = new Child("Gloria", 14);
            //Child boy = new Child("Ivan", 9);
            //Child[] childs = {kid, girl, boy};
            
            //Array.Sort(childs);
            //foreach (var child in childs)
            //{
            //    Console.WriteLine(child);
            //}

            //Console.WriteLine(kid == new Child("George", 10));
            //Console.WriteLine(girl==boy);

            Book book = new Book("Neron", "George M. Bosch", 12.34);
            Book book1 = new Book("Neron", "George 1osch", 12.34);

            GoldenEditionBook goldBook = new GoldenEditionBook("Inferno", "Dan Brown", 100.45);

            Console.WriteLine(book1);
            Console.WriteLine(goldBook);
        }
    }
}
