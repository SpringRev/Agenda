//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CodilityPractice
//{
//    public class LargestBinaryGap
//    {

//        // write your code in C# 6.0 with .NET 4.5 (Mono)
//        int N = 32;
//        string binaryRep = Convert.ToString(N, 2);

//        int maxGapSize = 0;
//        int currGapSize = 0;

//        foreach (char ch in binaryRep)
//        {
//            if (ch == '0')
//            {
//                currGapSize++;
//            }
//            else
//            {
//                maxGapSize = Math.Max(currGapSize, maxGapSize);
//                currGapSize = 0;
//            }
//        }

//        Console.WriteLine(maxGapSize);



//    }
//}
