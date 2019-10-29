using System;
using System.Linq;

namespace PreparationKit
{
    class Program
    {
        public static void Main(string[] args)
        {
            /******************** STRUCTS ****************************/
            //Person faisal;
            //faisal.name = "faisal";
            //faisal.age = 24;
            //faisal.PrintPerson();

            /******************** Abstract Classes ****************************/

            //var abs = new AbstractTest();
            //abs.Do();

            ///************** DELEGATE **********************/

            //ChangeNumber del1 = new ChangeNumber(Increase);
            //ChangeNumber del2 = new ChangeNumber(Decrease);

            //ChangeNumber del3 = del1 + del2;
            //Console.WriteLine(del3(5));

            //int Increase(int num)
            //{
            //    Console.WriteLine("Increasing Number");
            //    return ++num;
            //}

            //int Decrease(int num)
            //{
            //    Console.WriteLine("Decreasing Number");
            //    return --num;
            //}

            /******************* ROTATE ARRAY *********************/


            //    string input = Console.ReadLine().ToString();
            //    int elementCount = Convert.ToInt32(input.Split(' ')[0]);
            //    int rotations = Convert.ToInt32(input.Split(' ')[1]) % elementCount;
            //    string elements = Console.ReadLine().ToString();
            //    int[] array = new int[elementCount];
            //    array = elements.Split(' ').Select(el => Convert.ToInt32(el)).ToArray();

            //    Console.WriteLine(string.Join(" ", RotateArray(array, rotations)));
            //}

            //static int[] RotateArray(int[] arr, int rotations)
            //{
            //    int arrayLength = arr.Length;
            //    int[] rotatedArray = new int[arrayLength];

            //    for (int i = 0; i < arrayLength; i++)
            //    {
            //        int index = i - rotations < 0 ? i - rotations + arrayLength : i - rotations;
            //        rotatedArray[index] = arr[i];
            //    }
            //    return rotatedArray;

            /***************** Rearrange an array such that arr[i] = i *******************************/

            //    int testCasesCount = Convert.ToInt32(Console.ReadLine());
            //    int[][] testCases = new int[testCasesCount][];
            //    for(int i = 0; i < testCasesCount; i++)
            //    {
            //        int arraySize = Convert.ToInt32(Console.ReadLine());
            //        string[] elements = Console.ReadLine().ToString().Split(' ');
            //        int[] array = new int[arraySize];
            //        array = Array.ConvertAll(elements, s => int.Parse(s));
            //        testCases[i] = array;
            //    }

            //    foreach(var testCaseArray in testCases)
            //    {
            //        Console.WriteLine(string.Join(" ", RearrangeArray(testCaseArray)));
            //    }

            //}

            //static int[] RearrangeArray(int[] arr)
            //{
            //    var rearrangedArray = new int[arr.Length];
            //    for(int i = 0; i < arr.Length; i++)
            //    {
            //        int num;
            //        if (arr[i] == i)
            //            num = arr[i];
            //        else if (!arr.Contains(i))
            //            num = -1;
            //        else
            //            num = i;

            //        rearrangedArray[i] = num;
            //    }
            //    return rearrangedArray;

            /***************** Reverse a string *******************************/

            //    int testCasesCount = Convert.ToInt32(Console.ReadLine());
            //    string[] testCases = new string[testCasesCount];
            //    for (int i = 0; i < testCasesCount; i++)
            //    {
            //        string testString = Console.ReadLine();

            //        testCases[i] = testString;
            //    }

            //    foreach (var testString in testCases)
            //    {
            //        Console.WriteLine(ReverseString(testString));
            //    }

            //}

            //static string ReverseString(string str)
            //{
            //    string reversedString = "";
            //    for(int i = str.Length - 1; i >= 0; i--)
            //    {
            //        reversedString += str[i];
            //    }

            //    return reversedString;

            /***************** Rearrange array (odd/even) *******************************/

            //    int testCasesCount = Convert.ToInt32(Console.ReadLine());
            //    int[][] testCases = new int[testCasesCount][];
            //    for (int i = 0; i < testCasesCount; i++)
            //    {
            //        int arraySize = Convert.ToInt32(Console.ReadLine());
            //        string[] elements = Console.ReadLine().ToString().Split(' ');
            //        int[] array = new int[arraySize];
            //        array = Array.ConvertAll(elements, s => int.Parse(s));
            //        testCases[i] = array;
            //    }

            //    foreach (var testCaseArray in testCases)
            //    {
            //        Console.WriteLine(string.Join(" ", RearrangeOddEvenArray(testCaseArray)));
            //    }
            //}

            //static int[] RearrangeOddEvenArray(int[] arr)
            //{
            //    var sortedArr = arr.OrderByDescending(m => m).ToArray();
            //    var arrangeArr = new int[arr.Length];
            //    int halfLength = (int)Math.Floor((double)(arr.Length / 2));
            //    for(int i = 0; i < arr.Length / 2; i++)
            //    {
            //        arrangeArr[i * 2] = sortedArr[i + halfLength];
            //        arrangeArr[i * 2 + 1] = sortedArr[halfLength - i - 1];
            //    }

            //    return arrangeArr;
            /***************** Rearrange array (-ive/+ive) *******************************/

            //    int testCasesCount = Convert.ToInt32(Console.ReadLine());
            //    int[][] testCases = new int[testCasesCount][];
            //    for (int i = 0; i < testCasesCount; i++)
            //    {
            //        int arraySize = Convert.ToInt32(Console.ReadLine());
            //        string[] elements = Console.ReadLine().ToString().Split(' ');
            //        int[] array = new int[arraySize];
            //        array = Array.ConvertAll(elements, s => int.Parse(s));
            //        testCases[i] = array;
            //    }

            //    foreach (var testCaseArray in testCases)
            //    {
            //        Console.WriteLine(string.Join(" ", RearrangeNvePveArray(testCaseArray)));
            //    }

            //}

            //static int[] RearrangeNvePveArray(int[] arr)
            //{
            //    int[] negArray = arr.Where(a => a < 0).ToArray();
            //    int[] posArray = arr.Where(a => a >= 0).ToArray();
            //    int[] rearrangedArr = new int[arr.Length];
            //    int negIndex = 0;
            //    int posIndex = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (i % 2 == 0 || negIndex + 1 > negArray.Length)
            //        {
            //            rearrangedArr[i] = posArray[posIndex];
            //            posIndex++;
            //            continue;
            //        }
            //        else
            //        {
            //            rearrangedArr[i] = negArray[negIndex];
            //            negIndex++;
            //        }
            //    }



            //    return rearrangedArr;

            /***************** Move zeros to the end *******************************/

            //    int testCasesCount = Convert.ToInt32(Console.ReadLine());
            //    int[][] testCases = new int[testCasesCount][];
            //    for (int i = 0; i < testCasesCount; i++)
            //    {
            //        int arraySize = Convert.ToInt32(Console.ReadLine());
            //        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            //        testCases[i] = array;
            //    }

            //    foreach (var testCaseArray in testCases)
            //    {
            //        Console.WriteLine(string.Join(" ", MoveZeros(testCaseArray)));
            //    }

            //}

            //static int[] MoveZeros(int[] arr)
            //{
            //    //int currZeroIndex = 0;
            //    //for (int i = 0; i < arr.Length; i++)
            //    //{
            //    //    if (arr[i] != 0)
            //    //    {
            //    //        currZeroIndex++;
            //    //        continue;
            //    //    }

            //    //    else
            //    //    {
            //    //        int temp = 0;
            //    //        while (true)
            //    //        {
            //    //            if (currZeroIndex == arr.Length)
            //    //                return arr;

            //    //            temp = arr[currZeroIndex];
            //    //            if (temp != 0)
            //    //                break;

            //    //            currZeroIndex++;
            //    //        }

            //    //        if (currZeroIndex < i)
            //    //            break;

            //    //        arr[currZeroIndex] = arr[i];
            //    //        arr[i] = temp;
            //    //    }
            //    //}

            //    int count = 0;
            //    int temp;
            //    int n = arr.Length;

            //    // Traverse the array. If arr[i] is 
            //    // non-zero, then swap the element at 
            //    // index 'count' with the element at 
            //    // index 'i' 
            //    for (int i = 0; i < n; i++)
            //    {
            //        if ((arr[i] != 0))
            //        {
            //            temp = arr[count];
            //            arr[count] = arr[i];
            //            arr[i] = temp;
            //            count = count + 1;
            //        }
            //    }
            //    return arr;
            /***************** Move zeros to the end *******************************/

            //    int testCasesCount = Convert.ToInt32(Console.ReadLine());
            //    int[][] testCases = new int[testCasesCount][];
            //    int sum = 0;
            //    for (int i = 0; i < testCasesCount; i++)
            //    {
            //        int arraySize = Convert.ToInt32(Console.ReadLine());
            //        sum = Convert.ToInt32(Console.ReadLine());
            //        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            //        testCases[i] = array;
            //    }

            //    foreach (var testCaseArray in testCases)
            //    {
            //        Console.WriteLine(string.Join(" ", FindSumPair(testCaseArray, sum)));
            //    }

            //}

            //static bool FindSumPair(int[] arr, int sum)
            //{
            //    int i = 0;
            //    while(i < arr.Length)
            //    {
            //        if (arr[i] > arr[i + 1])
            //            break;
            //        i++;
            //    }
            //    int rightIndex = i + 1;
            //    int leftIndex = i;

            //    while(true)
            //    {
            //        if (arr[leftIndex] + arr[rightIndex] == sum)
            //        {
            //            Console.WriteLine($"{arr[leftIndex]} and {arr[rightIndex]}");
            //            return true;

            //        }

            //        if (arr[leftIndex] + arr[rightIndex] < sum)
            //        {
            //            rightIndex++;
            //        }

            //        else
            //        {
            //            leftIndex--;
            //        }

            //        if (leftIndex < 0 || rightIndex >= arr.Length)
            //            break;
            //    }
            //    return false;

            /***************** Move zeros to the end *******************************/

            //    int testCasesCount = Convert.ToInt32(Console.ReadLine());
            //    int[][] testCases = new int[testCasesCount][];
            //    for (int i = 0; i < testCasesCount; i++)
            //    {
            //        int arraySize = Convert.ToInt32(Console.ReadLine());
            //        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            //        testCases[i] = array;
            //    }

            //    foreach (var testCaseArray in testCases)
            //    {
            //        Console.WriteLine(string.Join(" ", FindMaxSum(testCaseArray)));
            //    }

            //}

            //static int FindMaxSum(int[] arr)
            //{
            //    int sum = int.MinValue;
            //    for(int i = 0; i < arr.Length; i++)
            //    {
            //        arr = RotateArrayByOne(arr);
            //        int arrSum = arr.Select((num, index) => num * index).Sum();
            //        sum = Math.Max(arrSum, sum);
            //    }
            //    return sum;
            //}

            //static int[] RotateArrayByOne(int[] arr)
            //{
            //    int firstEl = arr[0];
            //    for(int i = 1; i < arr.Length; i++)
            //    {
            //        arr[i - 1] = arr[i];
            //    }
            //    arr[arr.Length - 1] = firstEl;
            //    return arr;
            /***************** Separate -ives and +ives *******************************/

            //    int testCasesCount = Convert.ToInt32(Console.ReadLine());
            //    int[][] testCases = new int[testCasesCount][];
            //    for (int i = 0; i < testCasesCount; i++)
            //    {
            //        int arraySize = Convert.ToInt32(Console.ReadLine());
            //        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            //        testCases[i] = array;
            //    }

            //    foreach (var testCaseArray in testCases)
            //    {
            //        Console.WriteLine(string.Join(" ", SeparateNvePve(testCaseArray)));
            //    }

            //}

            //static int[] SeparateNvePve(int[] arr)
            //{
            //    int negativesIndex = 0;
            //    for(int i = 0; i < arr.Length; i++)
            //    {
            //        if(arr[i] < 0)
            //        {
            //            arr = ShiftLeft(arr, i, i - negativesIndex);
            //            negativesIndex++;
            //        }
            //    }

            //    return arr;
            //}

            //static int[] ShiftLeft(int[] arr, int indexToShift, int shiftBy)
            //{
            //    for(int i = indexToShift, j = shiftBy; j > 0; i--, j--)
            //    {
            //        int temp = arr[i - 1];
            //        arr[i - 1] = arr[i];
            //        arr[i] = temp;
            //    }
            //    return arr;
            /***************** Largest Number from Array *******************************/

            //    int testCasesCount = Convert.ToInt32(Console.ReadLine());
            //    int[][] testCases = new int[testCasesCount][];
            //    for (int i = 0; i < testCasesCount; i++)
            //    {
            //        int arraySize = Convert.ToInt32(Console.ReadLine());
            //        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            //        testCases[i] = array;
            //    }

            //    foreach (var testCaseArray in testCases)
            //    {
            //        Console.WriteLine(string.Join(" ", LargestNumber(testCaseArray)));
            //    }

            //}

            //static double LargestNumber(int[] arr)
            //{
            //    var numStr = string.Join("", Array.ConvertAll(arr, a => Convert.ToString(a)));
            //    var result = Convert.ToDouble(string.Join("", Array.ConvertAll(numStr.Select(n => int.Parse(n.ToString())).OrderByDescending(n => n).ToArray(), a => a.ToString())));
            //    Console.WriteLine(string.Join(" ", result));

            //    return 0;
            /***************** alt min/max *******************************/

            //    int testCasesCount = Convert.ToInt32(Console.ReadLine());
            //    int[][] testCases = new int[testCasesCount][];
            //    for (int i = 0; i < testCasesCount; i++)
            //    {
            //        int arraySize = Convert.ToInt32(Console.ReadLine());
            //        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            //        testCases[i] = array;
            //    }

            //    foreach (var testCaseArray in testCases)
            //    {
            //        Console.WriteLine(string.Join(" ", AltMinMax(testCaseArray)));
            //    }

            //}

            //static int[] AltMinMax(int[] arr)
            //{
            //    var altArr = new int[arr.Length];
            //    for(int i = 0; i < arr.Length; i++)
            //    {
            //        if(i == arr.Length - i - 1)
            //        {
            //            altArr[altArr.Length - 1] = arr[i];
            //            break;
            //        }
            //        if (i > arr.Length - 1 - i)
            //            break;

            //        altArr[2 * i] = arr[arr.Length - 1 - i];
            //        altArr[2 * i + 1] = arr[i];
            //    }

            //    return altArr;
            /***************** alt min/max *******************************/

            int testCasesCount = Convert.ToInt32(Console.ReadLine());
            int[][] testCases = new int[testCasesCount][];
            for (int i = 0; i < testCasesCount; i++)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
                testCases[i] = array;
            }

            foreach (var testCaseArray in testCases)
            {
                Console.WriteLine(string.Join(" ", NextSmallLarge(testCaseArray)));
            }

        }

        static int[] AltMinMax(int[] arr)
        {
        }
    }

}



