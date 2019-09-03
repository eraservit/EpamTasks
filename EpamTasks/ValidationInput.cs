using System;


namespace EpamTasks
{
    class ValidationInput
    {

        public static int GetValueFromConsole(string suggestMessage, string errorMessage)
        {
            if (!string.IsNullOrEmpty(suggestMessage)) Console.WriteLine(suggestMessage);
            string consoleInput = Console.ReadLine();
            bool success = false;
            success = int.TryParse(consoleInput, out int number);
            while (!success)
            {
                Console.WriteLine(errorMessage);
                consoleInput = Console.ReadLine();
                success = int.TryParse(consoleInput, out number);
            }
            return number;
        }


    }
}
