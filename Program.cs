using System;

/*You have 2 identical eggs and access to a tall building.
    You need to figure out the highest floor an egg can be dropped from without breaking.
    You are allowed to drop an egg again if it stays intact, also You are allowed to break both eggs if it's
    necessary to provide an answer. Describe Your line of thought and implement a solution as a program in a chosen programming language.
*/

namespace Žydrūnas.Grabuskas
{
    class Program
    {
        static void Main(string[] args)
        {
            //My toughts on solving problem:
            //I start dropping egg from first floor, if it's not cracked I go to second floor and etc.
            //If it breaks, I take second egg and drop that too, to see if its breaks at the same floor or not.
            //Random values are created to generate faulty floors, to test my solution. 

            Random rng = new Random();

            bool isEgg1Cracked = false;
            bool isEgg2Cracked = false;

            int egg1Floor = 1;
            int egg2Floor = 1;


            
            Console.WriteLine("How tall bilding is?");
            int floors = Convert.ToInt32(Console.ReadLine());

            int floorToBrakeEgg1 = rng.Next(1, floors - 1);
            int floorToBrakeEgg2 = rng.Next(1, floors - 1);

            for (int i = 1; i < floors;)
            {
                if (i == floorToBrakeEgg1)
                {
                    isEgg1Cracked = true;
                }
                if (i == floorToBrakeEgg2)
                {
                    isEgg2Cracked = true;
                }

                if (isEgg1Cracked == false)
                {
                    i++;
                    egg1Floor++;
                }
                if (isEgg1Cracked == true)
                {
                    if (isEgg2Cracked == false && i > floorToBrakeEgg2)
                    {
                        i++;
                        egg2Floor = egg1Floor++;
                    }
                    else if(isEgg2Cracked == true)
                    {
                        egg2Floor = egg1Floor;
                        break;
                    }
                }

            }
            Console.WriteLine($"First egg broke on flore: {egg1Floor}");
            Console.WriteLine($"Second egg broke on flore: {egg2Floor}");
            Console.ReadLine();
        }
    }
}
