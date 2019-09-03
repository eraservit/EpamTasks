using System;

namespace EpamTasks
{
    class Task4
    {
        public static void ExecTask4()
        {
            Console.WriteLine("\n\nTASK 4");
            int s = ValidationInput.GetValueFromConsole("Input a value >0 to calculate a Factorial", "Please input correct value");
            while (s <= 0)
            {
                s = ValidationInput.GetValueFromConsole("Input a value >0 to calculate a Factorial", "Please input correct value");
            }
            Console.WriteLine("Factorial = " + GetFactorial(s));
            Console.ReadKey();
        }

        public static int GetFactorial(int s)
        {
            int F = 1; int c = 1;
            while (c <= s)
            {
                F = F * c;
                c++;
            }
            return F;
        }
    }
}
