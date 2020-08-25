using System;
using Composition2.Entities;

namespace Composition2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment com1 = new Comment("Have a nice trip!");
            Comment com2 = new Comment("Wowww that's awesome!");
            Comment com3 = new Comment("Nice :DDD");

            Post p1 = new Post(
                DateTime.Parse("21/03/2020 13:05:50"),
                "Traveling to China",
                "I'm going visit this country!",
                12
                );

            p1.AddComment(com1);
            p1.AddComment(com2);
            p1.AddComment(com3);

            Console.WriteLine(p1);
        }
    }
}
