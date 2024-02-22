using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._6kyu;

public static class MultiplesOf3Or5
{
    public static int Solution(int value)
    {
        if (value < 0) return 0;
        var tempValue = value;
        var sumOfVerdelers = 0;
        while (tempValue > 0)
        {
            tempValue--;
            if (tempValue % 3 == 0 || tempValue % 5 == 0) 
                sumOfVerdelers += tempValue;
            
        }
        return sumOfVerdelers;
    }
}

/*
 * 
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).

Note: If the number is a multiple of both 3 and 5, only count it once.
 * 
 */
