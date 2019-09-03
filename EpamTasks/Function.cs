using System;
using System.Collections;

namespace EpamTasks
{
    class Function
    {

        public static int[] GetArrayFromConsole()
        {

            int nArr = ValidationInput.GetValueFromConsole("Input a number of elemets in array", "Please input correct value");
            while (nArr <= 0)
            {
                nArr = ValidationInput.GetValueFromConsole("Input a number of elemets in array", "Please input correct value");
            }
            int[] mainArray = new int[nArr];
            int iArr = 0;
            while (iArr < nArr)
            {
                string element = "Input " + (iArr + 1) + " of " + nArr;
                mainArray[iArr] = ValidationInput.GetValueFromConsole(element, "Please input correct value");
                iArr++;
            }

            return mainArray;
        }
        public static void PrintArray(int[] incomingArray)
        {
            Console.Write("Your Array: ");
            for (int i = 0; i < incomingArray.Length; i++)
            {
                Console.Write(" {0}", incomingArray[i]);
            }
        }

        public static int[] SortArray(int[] arr, bool comments = true)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int iMin = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[iMin])
                    {
                        iMin = j;
                    }
                }
                if (iMin != i)
                {
                    int c = arr[iMin];
                    arr[iMin] = arr[i];
                    arr[i] = c;
                }

                if (comments)
                {
                    Console.Write("\nSort step {0}:", i + 1);
                    for (int k = 0; k < arr.Length; k++)
                    {
                        Console.Write(" {0}", arr[k]);
                    }
                    Console.WriteLine();
                }
            }
            return arr;
        }
    }
}
