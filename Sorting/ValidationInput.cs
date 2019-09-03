using System;


namespace Sorting
{
    class ValidationInput
    {

        public static int GetValueFromConsole(string suggestMessage, string errorMessage)
        {
            if (!string.IsNullOrEmpty(suggestMessage)) Console.WriteLine(suggestMessage);
            string consoleInput = Console.ReadLine();
            int number;
            bool success = false;
            success = int.TryParse(consoleInput, out number);
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
