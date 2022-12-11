using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    public static void PlusMinus(List<int> arr)
    {
        int amount = arr.Count;
        int positive = 0;
        int negative = 0;
        int zero = 0;

        foreach (int integer in arr)
        {
            if (integer > 0)
            {
                positive++;
            } else if (integer < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }
        }

        decimal fractionPositive = Math.Round((decimal)positive / amount, 6);
        decimal fractionNegative = Math.Round((decimal)negative / amount, 6);
        decimal fractionZero = Math.Round((decimal)zero / amount, 6);
        Console.WriteLine($"{fractionPositive:0.000000}");
        Console.WriteLine($"{fractionNegative:0.000000}");
        Console.WriteLine($"{fractionZero:0.000000}");
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.PlusMinus(arr);
    }
}