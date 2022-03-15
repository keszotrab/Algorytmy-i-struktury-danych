using System;
using System.Collections.Generic;
using System.Text;

namespace lab_03_03
{
    class CasheRegister
    {

        int one;
        int two;
        int five;

        int[] income = new int[3];

    
        int[] Payment(int[] income, int amount)
        {
            int fiveC = amount % 5;
            amount = amount - fiveC * 5;
            int twoC = amount % 2;
            amount = amount - twoC * 2;
            int oneC = amount;

            int[] outcome = new int[3];
            outcome[1] = oneC;
            outcome[2] = twoC;
            outcome[3] = fiveC;

            return outcome;
        }

        












    }
}
