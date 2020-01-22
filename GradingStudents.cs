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

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        int modulo1 = 0, modulo2 = 0, SampleMark = 0;
            List<int> NewMark = new List<int>(grades.Count);

            // Main Loop
            for (int index = 0; index < grades.Count; index++)
            {
                
                if (grades[index] >= 38 && grades[index]%5!=0)
                {
                    modulo1 = grades[index] % 10; 
                    modulo2 = grades[index] / 10;

                    //values less than 5
                    if ((5 - modulo1) > 0)
                    {
                        SampleMark = modulo2 * 10 + 5;

                        if(SampleMark-grades[index]<=2)
                        {
                            grades[index] = SampleMark;
                        }

                    }

                    //values greater than 5
                    if ((5 - modulo1) <= -1)
                    {
                        SampleMark = modulo2 * 10 + 10;

                        if(SampleMark- grades[index]<=2)
                        {
                            grades[index] = SampleMark;
                         
                        }
                    }
                }

            }

            return grades;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
/*
Sample Input 0

4
73
67
38
33
Sample Output 0

75
67
40
33

Solved by SanthoshGoku
HackerRank Problem
*/
