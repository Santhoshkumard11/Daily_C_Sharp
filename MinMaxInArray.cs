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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] array) {


        int length = array.Length;

        long MaxSum=0,MinSum=0;
        
        //sort the array using the array sort function
        Array.Sort(array);

        //main loop for calculating the max and min sum
        for(int index=0,RevIndex=length-1;index<length-1;index++,RevIndex--)
        {
            MinSum += array[index];
            MaxSum += array[RevIndex];    

        }

        

        Console.WriteLine("{0} {1}",MinSum,MaxSum);


    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
/*
Sample Input

1 2 3 4 5

Sample Output

10 14

Solved by SanthoshGoku
HackerRank Problem
*/
