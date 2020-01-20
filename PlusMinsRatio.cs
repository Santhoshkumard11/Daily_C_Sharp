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

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] array) {

        float length = array.Length;
        float positive=0.0f,negative=0.0f,zero=0.0f;

        //calculating the number of positive, negative & zeros
        foreach(int index in array)
        {
            if(index>=1)
                positive +=1;
            if(index==0)
                zero +=1;
            if(index<=-1)
                negative +=1;
        }


        float ratio=0.0f;
        ratio = positive/length;
        Console.WriteLine(ratio);

        ratio = negative/length;
        Console.WriteLine(ratio);

        ratio = zero/length;
        Console.WriteLine(ratio);


    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
/*
Sample Input

6
-4 3 -9 0 4 1     

Sample Output

0.500000
0.333333
0.166667



solved by SanthoshGoku
HackerRank Problem
*/
