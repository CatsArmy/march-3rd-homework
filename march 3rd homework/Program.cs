using System;

Console.WriteLine("select question 1-4");
int selector = int.Parse(Console.ReadLine());
if (selector == 1)
{
    Console.WriteLine("input array v size[n]");
    int n = int.Parse(Console.ReadLine());
    int firstNone0 = 0;
    int lastNone0 = n;
    int[] v = new int[n];
    int inputRand;
    Random r = new Random();
    //Initialize
    Console.WriteLine($"Before v[n] n = {n}\n");
    for (int i = 0; i < n; i++)
    {
        v[i] = i + 1;
        Console.Write($"v[{i}] = {v[i]} ,");
    }
    Console.WriteLine("\n\nRandom Input\n");
    for (int i = 0; i < n; i++)
    {
        inputRand = r.Next(1, 20);
        Console.Write($"input[{i}] = {inputRand}, ");
        if (inputRand % 2 == 0)
        {
            v[lastNone0 - 1] = 0;
            lastNone0--;
        }
        else
        {
            v[firstNone0] = 0;
            firstNone0++;
        }
    }
    Console.WriteLine("\n\nAfter\n");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"v[{i}] = {v[i]} ,");
    }
    Console.WriteLine(" ");
}
if (selector == 2)
{
    static int[] array(int[] arr1, int[] arr2)
    {
        //arr 1 = true, arr 2 = false
        bool arr1OrArr2;
        int arr3Size;
        int match = 0;
        if (arr1.Length > arr2.Length)
        {
            arr3Size = arr2.Length;
            arr1OrArr2 = false;
        }
        else
        {
            arr3Size = arr1.Length;
            arr1OrArr2 = true;
        }
        int[] arr3 = new int[arr3Size];
        for (int i = 0; i < arr1.Length; i++)
        {

            if (CompareToArray(arr2, arr1[i]))
            {
                if (!CompareToArray(arr3, arr1[i]))
                {
                    arr3[match] = arr1[i];
                    match++;
                }
            }
        }
        return arr3;
        static bool CompareToArray(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    i = arr.Length;
                    return true;
                }
            }
            return false;
        }
    }
    Console.Clear();
    int[] arr1 = new int[10];
    int[] arr2 = new int[10];
    Random random = new Random();
    Console.Write("array1 { ");
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = random.Next(1,arr1.Length + 5);
        Console.Write($"{arr1[i]} ,");
    }
    Console.Write(" }\n");
    Console.Write("array2 { ");
    for (int i = 0; i < arr2.Length; i++)
    {
        arr2[i] = random.Next(1,arr2.Length + 5);
        Console.Write($"{arr2[i]}, ");
        
    }
    Console.WriteLine(" }\n");
    int[] arr3 = array(arr1,arr2);
    Console.Write("array3 { ");
    for (int i = 0; i < arr3.Length; i++)
    {
        Console.Write($"{arr3[i]}, ");
    }
        Console.Write(" }");
}
if (selector == 3)
{
    Random random = new Random();
    int[] arr1 = new int[10];
    int[] arr2 = new int[10];
    int[] topTenFromArray = new int[10];

    for (int i = 0; i < arr2.Length; i++)
    {
        arr1[i] = random.Next(1, 30);
        arr2[i] = random.Next(1, 30);
    }
    int[] arrM = SortedMerge(arr1, arr2);
    for (int i = 0; i < arrM.Length; i++)
    {
        Console.Write($"{arrM[i]} ,");
    }
    Console.WriteLine(" \n");
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]} ,");
    }
    Console.WriteLine(" \n");
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write($"{arr1[i]} ,");
    }
    Console.WriteLine(" \n");
    topTenFromArray = max10SortArr(arrM);
    for (int i = 0; i < topTenFromArray.Length; i++)
    {
        Console.Write($"{topTenFromArray[i]} ,");
    }

    

    int[] max10SortArr(int[] arr)
    {
        int[] resultArr = new int[10];
        int indexCounter = resultArr.Length - 1;
        //go thru all the elements of the merged array
        for (int i = arr.Length - 1; i > 0; i--)
        {   //if the values of arrM match arrM-1 we can skip them

            if (arr[i] == arr[i - 1])
            {
                i--;
            }
            else
            {
                resultArr[indexCounter] = arr[i];
                if (indexCounter == 0)
                {
                    i = 0;
                }
                else
                {
                 indexCounter--;
                }
            }

        }
        return resultArr;
    }    
}
if (selector == 4)
{
    Random rand = new Random();
    int[] arr1 = new int[10];
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = rand.Next(1,20000);
    }

    int maxFirstNumIndex = FindMaxFirstDigitIndex(arr1);
    int maxFirstNum = FindMaxFirstDigit(arr1);
    Console.WriteLine("array:");
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.WriteLine($"array[{i}] = {arr1[i]}");
    }
        Console.WriteLine($"Max First Num Index = {maxFirstNumIndex}");
        Console.WriteLine($"Max First Num = {maxFirstNum}");
    static int FindMaxFirstDigit(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                Console.WriteLine("Error Input A Valid Array");
                break;//o no i broke it
            }
        }
        int maxFirstDigit = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (maxFirstDigit < GetFirstDigit(arr[i]))
            {
                maxFirstDigit = GetFirstDigit(arr[i]);
            }
        }
        return maxFirstDigit;
    }
    static int FindMaxFirstDigitIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                Console.WriteLine("Error Input A Valid Array");
                break;//o no i broke it
            }
        }
        int maxFirstDigit = 0;
        int saveIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (maxFirstDigit < GetFirstDigit(arr[i]))
            {
                maxFirstDigit = GetFirstDigit(arr[i]);
                saveIndex = i;
            }
        }
        return saveIndex;
    }
    static int GetFirstDigit(int arr)
    {
        int num;
        num = arr;
        while (num % 10 == 0)
        {
            num /= 10;
        }
        return num;
    }
}
static int[] SortedMerge(int[] arr1, int[] arr2)
{
    bool debug = false;
    int mLength = arr1.Length + arr2.Length;
    int[] mergedArr = new int[mLength];
    int arr1I = 0;
    int arr2I = 0;
    for (int i = 0; i < mLength; i++)
    {
        if (arr1I == arr1.Length)
        {
            mergedArr[i] = arr2[arr2I];
            arr2I++;
            if (debug)
            {
                Console.WriteLine("case1 arr1I == arr1.Length");
                Console.WriteLine($"mArr[{i}] = {mergedArr[i]} \n arr1I = {arr1I} arr2I = {arr2I}");
            }
        }
        else if (arr2I == arr2.Length)
        {
            mergedArr[i] = arr1[arr1I];
            arr1I++;
            if (debug)
            {
                Console.WriteLine("case2 arr2I == arr2.Length");
                Console.WriteLine($"mArr[{i}] = {mergedArr[i]} \n arr1I = {arr1I} arr2I = {arr2I}");
            }
        }
        else if (arr1[arr1I] > arr2[arr2I])
        {
            mergedArr[i] = arr2[arr2I];
            arr2I++;
            if (debug)
            {
                Console.WriteLine("case3 arr1[arr1I] > arr2[arr2I]");
                Console.WriteLine($"mArr[{i}] = {mergedArr[i]} \n arr1I = {arr1I} arr2I = {arr2I}");
            }
        }
        else
        {
            mergedArr[i] = arr1[arr1I];
            arr1I++;
            if (debug)
            {
                Console.WriteLine("case4 arr1[arr1I] < arr2[arr2I]");
                Console.WriteLine($"mArr[{i}] = {mergedArr[i]} \n arr1I = {arr1I} arr2I = {arr2I}");
            }
        }
    }
    if (debug)
    {
        Console.Write("mergedArr = ");
        for (int i = 0; i < mergedArr.Length; i++)
        {
            Console.Write($"{mergedArr[i]}, ");
        }
    }
    return BubbleSort(mergedArr);
}
//using BubbleSort
static int[] BubbleSort(int[] bubble)
{
    int TempSort;
    int tempIndx;
    for (int i = 0; i < bubble.Length - 1; i++)
    {
        for (int j = 0; j < bubble.Length - 1; j++)
        {//brute force go brrrrrrrrrrr
            tempIndx = j + 1;
            TempSort = bubble[j];
            if (bubble[tempIndx] < bubble[j])
            {
                bubble[j] = bubble[tempIndx];
                bubble[tempIndx] = TempSort;
            }
        }
    }
    return bubble;
}
