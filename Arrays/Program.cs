using System;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------Arrays----------");
            int[] arr = new int[5];
            arr[0] = 5;
            arr[2] = 15;
            arr[4] = 25;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("--------------------");

            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("--------------------");

            int[] arr2 = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("--------------------");

            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }

    //public class ArraytoFunction
    //{
    //    static void printArray(int[] arr)
    //    {
    //        Console.WriteLine("Print Array Elements: ");

    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            Console.WriteLine(arr[i]);
    //        }
    //    }
    //    static void printMin(int[] arr)
    //    {
    //        int min = arr[0];
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            if(min > arr[i])
    //            {
    //                min = arr[i];
    //            }
    //        }
    //        Console.WriteLine("Min Element is: " + min);
    //    }
    //    static void printMax(int[] arr)
    //    {
    //        int max = arr[0];
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            if (max < arr[i])
    //            {
    //                max = arr[i];
    //            }
    //        }
    //        Console.WriteLine("Max Element is: " + max);
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("----------Passing Array to Function----------");
    //        Console.WriteLine();
    //        int[] arr1 = { 1, 2, 3, 4, 5 };
    //        int[] arr2 = { 10, 20, 30, 40, 50 };
    //        //printArray(arr1);
    //        //printArray(arr2);
    //        //printMin(arr1);
    //        //printMin(arr2);
    //        printMax(arr1);
    //        printMax(arr2);
    //        Console.ReadLine();
    //    }
    //}

    //public class MultidimensionalArrays
    //{
    //    public static void Main(string[] args)
    //    {
    //        int[,] arr1 = new int[3, 3];
    //        int[,,] arr2 = new int[3, 3, 3];
    //        arr1[0, 0] = 1;
    //        arr1[1, 1] = 2;
    //        arr1[2, 2] = 3;
    //        for (int i = 0; i < 3; i++)
    //        {
    //            for (int j = 0; j < 3; j++)
    //            {
    //                Console.Write(arr1[i, j] + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.WriteLine();

    //        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    //        for (int i = 0; i < 3; i++)
    //        {
    //            for (int j = 0; j < 3; j++)
    //            {
    //                Console.Write(arr[i, j] + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //public class JaggedArrays
    //{
    //    public static void Main(string[] args)
    //    {
    //        //int[][] arr = new int[2][];
    //        ////arr[0] = new int[3] { 1, 2, 3 };
    //        ////arr[1] = new int[5] { 4, 5, 6, 7, 8 };
    //        //arr[0] = new int[] { 1, 2, 3 };
    //        //arr[1] = new int[] { 4, 5, 6, 7, 8 };

    //        //for (int i = 0; i < arr.Length; i++)
    //        //{
    //        //    for (int j = 0; j < arr[i].Length; j++)
    //        //    {
    //        //        Console.Write(arr[i][j] + " ");
    //        //    }
    //        //    Console.WriteLine();
    //        //}
    //        //Console.ReadLine();

    //        int[][] arr1 = new int[3][]{
    //            new int[] { 1, 2, 3 },
    //            new int[] { 4, 5, 6, 7, 8 },
    //            new int[] { 25, 50 }
    //         };

    //        for (int i = 0; i < arr1.Length; i++)
    //        {
    //            for (int j = 0; j < arr1[i].Length; j++)
    //            {
    //                Console.Write(arr1[i][j] + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //public class Paramskeyword
    //{
    //    public void Show(params int[] val)
    //    {
    //        for (int i = 0; i < val.Length; i++)
    //        {
    //            Console.Write(val[i] + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //    public void Show1(params object[] val)
    //    {
    //        for (int i = 0; i < val.Length; i++)
    //        {
    //            Console.Write(val[i] + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Paramskeyword paramskeyword = new Paramskeyword();
    //        paramskeyword.Show(1, 2, 3, 4, 5, 6, 7, 8, 9, 0);
    //        paramskeyword.Show1("jonas", "stive", 1202, true, "A");
    //        Console.ReadLine();
    //    }
    //}

    //public class Arrayclass
    //{
    //    public static void Main(string[] args)
    //    {
    //        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    //        int[] arr1 = { 1, 2, 7, 9, 5, 6, 3, 8, 4 };
    //        int[] arr2 = new int[9];
    //        Console.WriteLine(arr.IsFixedSize);
    //        Console.WriteLine(arr.IsReadOnly);
    //        Console.WriteLine(arr.IsSynchronized);
    //        Console.WriteLine(arr.Length);
    //        Console.WriteLine(arr.LongLength);
    //        Console.WriteLine(arr.Rank);
    //        Console.WriteLine(arr.SyncRoot);
    //        Console.WriteLine(Array.IndexOf(arr1, 9));
    //        Array.Copy(arr1, arr2, arr1.Length);
    //        for (int i = 0; i < arr2.Length; i++)
    //        {
    //            Console.Write(arr2[i] + " ");
    //        }
    //        Console.WriteLine();
    //        Array.Sort(arr1);
    //        for (int i = 0; i < arr1.Length; i++)
    //        {
    //            Console.Write(arr1[i] + " ");
    //        }
    //        Console.WriteLine();
    //        Array.Reverse(arr1);
    //        for (int i = 0; i < arr1.Length; i++)
    //        {
    //            Console.Write(arr1[i] + " ");
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //public class CommandLineArguments
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Arguments Length: " + args.Length);
    //        Console.WriteLine("Enter Arguments:");
    //        foreach (object obj in args)
    //        {
    //            Console.WriteLine(obj);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}