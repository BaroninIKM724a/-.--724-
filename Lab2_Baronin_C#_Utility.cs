using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Baronin;

public class Utility
{
    public static bool IsPalindrome(string text)
    {
        string reversed = new string(text.Reverse().ToArray());

        return text == reversed;
    }

    public static int SumOfDigits(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}
