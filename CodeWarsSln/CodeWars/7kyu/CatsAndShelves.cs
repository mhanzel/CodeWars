using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._7kyu
{
    public class CatsAndShelves
    {
        public static int Cats(int start, int finish)
        {
            var jumps = 0;
            var levels = finish - start;
            while(levels > 0)
            {
                if(levels > 3)
                {
                    jumps++;
                    levels -= 3;
                }
                else if (levels == 3 || levels == 1) 
                {
                    jumps++;
                    break;
                }
                else
                {
                    jumps += 2;
                    break;
                }
            }
            return jumps;
        }
        public static int CatsBetter(int start, int finish)
        {
            var diff = finish - start;
            return diff / 3 + diff % 3;
        }
    }
}
/*
 * 
 * An infinite number of shelves are arranged one above the other in a staggered fashion.
The cat can jump either one or three shelves at a time: from shelf i to shelf i+1 or i+3 (the cat cannot climb on the shelf directly above its head), according to the illustration:

                 ┌────────┐
                 │-6------│
                 └────────┘
┌────────┐       
│------5-│        
└────────┘  ┌─────► OK!
            │    ┌────────┐
            │    │-4------│
            │    └────────┘
┌────────┐  │
│------3-│  │     
BANG!────┘  ├─────► OK! 
  ▲  |\_/|  │    ┌────────┐
  │ ("^-^)  │    │-2------│
  │ )   (   │    └────────┘
┌─┴─┴───┴┬──┘
│------1-│
└────────┘
Input
Start and finish shelf numbers (always positive integers, finish no smaller than start)

Task
Find the minimum number of jumps to go from start to finish

Example
Start 1, finish 5, then answer is 2 (1 => 4 => 5 or 1 => 2 => 5)
 * 
 */
