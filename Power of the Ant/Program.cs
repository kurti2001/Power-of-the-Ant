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
        Console.WriteLine("Give the X position of the colony, the Y position of the colony, the ANT's X starting position and the ANT's Y starting position\n\n");

        int colonyX = Convert.ToInt32(Console.ReadLine());

        int colonyY = Convert.ToInt32(Console.ReadLine());// the Y position of the colony

        int initialX = Convert.ToInt32(Console.ReadLine());// The Ant's starting X position

        int initialY = Convert.ToInt32(Console.ReadLine());



        int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns the Ant can move. Do not remove this line.
        bool Destination = true;
        while (Destination = true)
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
                Destination = false;
                return;
            }

        }
    }
}

