using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give the X position of the colony \n Enter a number from 0 to 40 ");

        int colonyX = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Give the  Y position of the colony \n Enter a number from 0 to 18 ");

        int colonyY = Convert.ToInt32(Console.ReadLine());// the Y position of the colony

        Console.WriteLine("Give the ANT's X starting position \n Enter a number from 0 to 40 ");

        int initialX = Convert.ToInt32(Console.ReadLine());// The Ant's starting X position

        Console.WriteLine("Give the ANT's Y starting position \n Enter a number from 0 to 18 ");

        int initialY = Convert.ToInt32(Console.ReadLine());


     

        int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns the Ant can move. Do not remove this line.


        while (true)
        {
            int movement = 1;

            if (colonyX > initialX && colonyY > initialY)
            {
                Console.WriteLine("NE");
                initialX = initialX + movement;
                initialY = initialY + movement;

            }
            else if (colonyX < initialX && colonyY < initialY)
            {
                Console.WriteLine("SW");
                initialY = initialY - movement;
                initialX = initialX - movement;
            }
            else if (colonyX == initialX && colonyY > initialY)
            {
                Console.WriteLine("N");
                initialY = initialY + movement;
            }
            else if (colonyX > initialX && colonyY == initialY)
            {
                Console.WriteLine("E");
                initialX = initialX + movement;
            }
            else if (colonyX > initialX && colonyY < initialY)
            {
                Console.WriteLine("SE");
                initialY = initialY - movement;
                initialX = initialX + movement;
            }
            else if (colonyX == initialX && colonyY < initialY)
            {
                Console.WriteLine("S");
                initialY = initialY - movement;
            }
            else if (colonyX < initialX && colonyY == initialY)
            {
                Console.WriteLine("W");
                initialX = initialX - movement;
            }
            else if (colonyX < initialX && colonyY > initialY)
            {
                Console.WriteLine("NW");
                initialY = initialY + movement;
                initialX = initialX - movement;
            }
            else if (colonyX == initialX && colonyY == initialY)
            {
                Console.WriteLine("Ant arrived the destination");
                return;
            }

        }
    }
}

