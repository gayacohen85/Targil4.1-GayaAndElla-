using Targil4._1_GayaAndsElla_;

Animal[] animals =
{
    new Dog("Rocky", 5),
    new Cat("Mitsi", 3)
};

foreach (Animal a in animals)
{
    Console.WriteLine(a);

    if (a is Dog d)
    {
        d.Bark();
    }

    if (a is Cat c)
    {
        c.Purr();
    }
}

Console.ReadLine();