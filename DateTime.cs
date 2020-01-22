using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string InputString) {
        /*
         * Write your code here.
         */

        //  char[] NewString = InputString.Split(':');


        DateTime NewString = DateTime.Parse(InputString);

        string OutputString = string.Format("{0}",NewString.ToString("HH:mm:ss"));

        // Console.WriteLine(char.Parse(InputString[1]));
        return (OutputString);
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
/*

Sample Input 0

07:05:45PM

Sample Output 0

19:05:45

Solved by SanthoshGoku
HackerRank Problem
*/
