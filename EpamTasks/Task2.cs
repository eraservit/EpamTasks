using System;


namespace EpamTasks
{
    class Task2
    {
        public static void ExecTask2()
        {
            Console.WriteLine("\n\nTASK 2");
            int[] arr = Function.GetArrayFromConsole();
            arr = Function.SortArray(arr, false);
            Function.PrintArray(arr);

            int findingValue = ValidationInput.GetValueFromConsole("\nInput a number to find in the array", "Please input correct value");
            if (!SearchValue(findingValue, arr))
                Console.WriteLine("Not Found!");
            else
                Console.WriteLine("FOUND !");
        }

        static bool SearchValue(int checkNum, int[] array)
        {
            bool temp = false;
            {
                for (int i = 0; i < array.Length & !temp; i++)
                    if (array[i] == checkNum) temp = true;
                
            }
            return temp;
        }
    }
}
