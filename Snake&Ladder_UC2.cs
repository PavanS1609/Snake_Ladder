using System;

class SnakeAndLadder_UC2
{
    static void Main(string[] args)
    // UseCase2 for Snake&Ladder
    {
        int die;
        Random random = new Random();
        die = random.Next(1, 7);
        Console.WriteLine(die);

    }
}