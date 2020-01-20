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

    // Complete the staircase function below.
    static void staircase(int n) {

        //main loop
        for(int index=1;index<=n;index++,Console.Write("\n"))
        {
            //loop to print the spaces
            for(int SpaceIndex=(n-index);SpaceIndex>0;SpaceIndex--)
                Console.Write(" ");
            
            //loop to print the charater
            for(int PrintIndex=1;PrintIndex<=index;PrintIndex++)
                Console.Write("#");


        }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
/*
Sample Input

6 

Sample Output

     #
    ##
   ###
  ####
 #####
######

Solved by SanthoshGoku
HackerRank Problem
*/
