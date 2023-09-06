class SnakeAndLadder_UC2
{
    static void Main(string[] args)
    //UseCase2 for Snake&Ladder
    //{
    //    int die;
    //    Random random = new Random();
    //    die = random.Next(1, 7);
    //    Console.WriteLine(die);

    //}
    //////USE CASE 3
    //{
    //    int roll;
    //    Random random = new Random();
    //    roll = random.Next(0,7);

    //    for(int i = 0; i < 1; i++)
    //    {
    //        if (roll == 0)
    //{
    //    Console.WriteLine("No Play");
    //    Console.WriteLine(roll);
    //}
    //else 
    //{
    //    //Console.WriteLine("Move Forward");
    //    Console.WriteLine(roll);
    //    int back_roll = random.Next(1,7);
    //    if (back_roll < roll)
    //    {
    //        Console.WriteLine("go back");
    //        Console.WriteLine(roll);
    //        Console.WriteLine(back_roll);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Move Forward");
    //    }


    //}
    {
    int roll;
    Random random = new Random();
    roll = random.Next(0,7);

        for(int i = 0; i < 1; i++)
        {
            if (roll == 0)
            {
                Console.WriteLine("No Play");
                Console.WriteLine(roll);

            }
            else
            {
                //Console.WriteLine("Move Forward");
                Console.WriteLine(roll);
                Console.WriteLine("Move Forward");
                int back_roll = random.Next(1, 7);
                Console.WriteLine(back_roll);
                if (back_roll < roll)
                {
                    Console.WriteLine("go back");
                   // Console.WriteLine(roll);
                    Console.WriteLine(back_roll);
                }
                else
                {
                    Console.WriteLine("Move Forward");
                }
            }
    
   


        }






    }
       
          
       
    
}