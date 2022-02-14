// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//Given a sequence of integers as an array, determine whether it is possible to obtain a strictly increasing sequence by removing no more than one element from the array.

//Note: sequence a0, a1, ..., an is considered to be a strictly increasing if a0 < a1 < ... < an. Sequence containing only one element is also considered to be strictly increasing.

//Example

//For sequence = [1, 3, 2, 1], the output should be
//solution(sequence) = false.

//There is no one element in this array that can be removed in order to get a strictly increasing sequence.

//For sequence = [1, 3, 2], the output should be
//solution(sequence) = true.

//int[] arr = FindBeautifulNumbersInRange(1, 1100);
//Console.WriteLine(arr.Length);  
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

int[] sequence = new int[] { 1, 3, 2 };
var almostIncreasingSequence = solution(sequence);
Console.WriteLine(almostIncreasingSequence);

bool solution(int[] sequence)
{
    int counter = 0;
    if (sequence == null || sequence.Length == 1)
    {
        return true;
    }
    for (int i = 1; i < (sequence.Length); i++)
    {
        if ((i < sequence.Length-1)?(sequence[i] >= sequence[i +1]) == true: false
        ||
        (sequence[i -1] >= sequence[i] == true))
        {
            counter++;
        }
    }
    if (counter > 1)
    {
        return false;
    }
    return true;
}

//int[] FindBeautifulNumbersInRange(int i, int j)
//{
//    List<int> beautifulIntegers= new List<int>();
//    //Dictionary<int, int[]> keyValuePairs = new Dictionary<int, int[]>();
//    for (i = 1; i < j; i++)
//    {
//        string arrayOfDigits = i.ToString();
//        //int[] arrayOfDigits = GetIntArray(i);
//        bool isBeautifulNumber = CheckIfBeautifulNumber(arrayOfDigits);
//        if (isBeautifulNumber)
//        {
//            beautifulIntegers.Add(i);
//        }
//    }

//    return beautifulIntegers.ToArray();
//}

//bool CheckIfBeautifulNumber(string arrayOfDigits)
//{
//    bool isBeautifulNumber = false;
//    var lengthOfTheNumber = arrayOfDigits.Length;
//   // string reverseArrayOfDigits = arrayOfDigits.Reverse().ToString();
//    int preSum = 0; int postSum = 0;

//    if (lengthOfTheNumber % 2 == 0)
//    {

//        for (int i = 0; i <= (lengthOfTheNumber / 2)-1; i++)
//        {
//            preSum += arrayOfDigits[i];
//            postSum += arrayOfDigits[(lengthOfTheNumber/2)+i];
//        }
//        if (preSum == postSum)
//        {
//            isBeautifulNumber = true;
//        }
//    }

//    return isBeautifulNumber;

//}

//int[] GetIntArray(int num)
//{
//    List<int> listOfInts = new List<int>();
//    while (num > 0)
//    {
//        listOfInts.Add(num % 10);
//        num = num / 10;
//    }
//    listOfInts.Reverse();
//    return listOfInts.ToArray();
//}






















//String[] arr = new string[] { "daisy", "Hyacinth", "rose", "Lily"};
////string flagTocheck = solution(arr);
//Console.WriteLine(flagTocheck);





//string solution(string[] arr)
//{
//    int counter = arr.Length;
//    int maxLength = 0;

//    string arrOutput = String.Empty;

//    foreach (var item in arr)
//    {
//        if (maxLength < item.Length)
//        {
//            maxLength = item.Length;
//        }
//    }

//    for (int i = 0; i < counter - 1; i++)
//    {
//        for (int j = 0; j < maxLength - 1; j++)
//        {
//            int currentArrayLenth = arr[i].Length;
//            if (currentArrayLenth <= maxLength)
//            {
//                var newcharString = arr[i].Substring(j, 1);
//                String.Concat(arrOutput, newcharString);
//            }
//        }
//    }
//    return arrOutput;
//}


//int[] a = new int[] { -52, 2, 31, 56, 47, 29, -35 };
//bool flagTocheck = AlmostIncreasinyArray();
//Console.WriteLine(flagTocheck);


//bool AlmostIncreasinyArray()
//{
//    #region CheckCode
//    int[] temp = (int[])a.Clone();
//    int[] b = (int[])a.Clone();

//    Array.Reverse(temp);
//    int sourceArrayLength = a.Length;
//    int j = 0;

//    int counter = 0;

//    for (int i = 0; i < sourceArrayLength / 2;)
//    {
//        if (i == 0 && j == 0)
//        {
//            b[i] = a[i];
//            b[i + 1] = temp[j];
//        }
//        else
//        {
//            b[i*2] = a[i];
//            b[i*2 +1] = temp[j];
//        }
//        i++;
//        j++;
//    }
//    if (sourceArrayLength % 2 == 1)
//    {
//        b[sourceArrayLength-1] = a[sourceArrayLength / 2];
//    }
//    for (int i = 0; i < (b.Length - 1); i++)
//    {
//        Console.WriteLine(b[i].ToString());
//        if (b[i] < b[i + 1] != true)
//        {
//            counter++;
//            if (counter >= 1)
//            {
//                return false;
//            }
//        }
//    }
//    return true;
//}

//if (duplicateCounter > 2 || counter > 1 || (duplicateCounter + counter) > 1)
//    Console.WriteLine(false);
//else Console.WriteLine(true);


//Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non-negative integer size. Since he likes to make things perfect, he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1. He may need some additional statues to be able to accomplish that. Help him figure out the minimum number of additional statues needed.

//Example

//For statues = [6, 2, 3, 8], the output should be
//solution(statues) = 3.

//Ratiorg needs statues of sizes 4, 5 and 7

//int[] inputArray = new int[] { 6, 2, 3, 8 };
//Console.WriteLine(((inputArray.Max() - inputArray.Min() + 1) - inputArray.Length).ToString());







//Below we will define an n-interesting polygon. Your task is to find the area of a polygon for a given n.

//A 1-interesting polygon is just a square with a side of length 1. An n-interesting polygon is obtained by taking the n - 1-interesting polygon and appending 1-interesting polygons to its rim, side by side. You can see the 1-, 2-, 3- and 4-interesting polygons in the picture below.

//int n = 2;
//int output = (Convert.ToInt32(Math.Pow(n-1,2)) + Convert.ToInt32(Math.Pow(n, 2)));

//Console.WriteLine(output.ToString());
//------------------------------
//int[] inputArray = new int[] { -23, 4, -3, 8, -12 };
//int arrayLength = inputArray.Length;
//int previousOutput = int.MinValue;
//for (int i = 0; i < arrayLength - 1; i++)
//{
//    var output = inputArray[i] * inputArray[i + 1];
//    if (output > previousOutput)
//        previousOutput = output;
//}
//Console.WriteLine(previousOutput.ToString());

//)