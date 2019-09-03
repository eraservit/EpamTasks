using System;


namespace Sorting
{
    class Task1
    {

        public static void ExecTask1()
        {
            Console.WriteLine("TASK 1");
            int[] arr = Function.GetArrayFromConsole();
            Function.SortArray(arr);
            Function.PrintArray(arr);
        }

        
    }
}
