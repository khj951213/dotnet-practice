using System;

namespace Algorithm.Problems;

public static class Bulb
{
    public static int MinPresses(int[] bulbs)
    {
        int presses = 0;
        bool flipped = false;

        foreach (int bulb in bulbs)
        {
            int currentState = bulb;

            if (flipped)
            {
                currentState = 1 - currentState;
            }

            if (currentState == 0)
            {
                presses++;
                flipped = !flipped;
            }
        }


        return presses;
    }
}
