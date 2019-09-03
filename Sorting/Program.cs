using System;


namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            int choise = ValidationInput.GetValueFromConsole("Input a number of task 1-4. Input 5 - to start all tasks or another to quit.", "Please input correct value");

            switch (choise)
            {

                case 1:
                    Task1.ExecTask1();
                    Console.ReadKey();
                    break;
                case 2:
                    Task2.ExecTask2();
                    Console.ReadKey();
                    break;
                case 3:
                    Task3.ExecTask3();
                    Console.ReadKey();
                    break;
                case 4:
                    Task4.ExecTask4();
                    Console.ReadKey();
                    break;
                case 5:
                    Task1.ExecTask1();
                    Task2.ExecTask2();
                    Task3.ExecTask3();
                    Task4.ExecTask4();
                    break;

                default:
                    if (choise < 1 || choise > 5) Console.WriteLine("Good Bye...");
                    Console.ReadKey();
                    break;

            }
         
        }
    }
}