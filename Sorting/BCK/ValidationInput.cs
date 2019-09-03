using System;
using System.Collections;

namespace Sorting
{
    class ValidationInput
    {
        //The Voide to check a colsole input for valid
        //For Example: int a = ValidateConsoleInputForInteger("Input a number of elemets in array", "Please input correct value", ">=0", "Input a value >=0");
        static public int ValidateConsoleInputForInteger(string suggestMessage, string errorMessage, string condition = "", string errorConditionMessage = "")
        {
            if (suggestMessage != "") Console.WriteLine(suggestMessage);            //Don't show if emty
            string consInput = Console.ReadLine();                                  //Reading from console
            int number;                                                           //set variable to return
            string errorString = errorMessage;                                      //set Error string from ARGS
            bool success = int.TryParse(consInput, out number);


            void ReadNParseConsole()                                                //Trying parse a console string to int
            {
                Console.WriteLine(errorString);
                consInput = Console.ReadLine();
                success = int.TryParse(consInput, out number);                    //Have a TRUE if success
            }

            void ShowError()                                                   //Showing errors while cheking for int & Condition
            {
                errorString = errorConditionMessage;
                ReadNParseConsole();
                while (!success)
                {
                    errorString = errorMessage + ". " + errorConditionMessage;
                    ReadNParseConsole();
                }
            }

            while (!success)                                                    //Showing errors while cheking for int
            {
                ReadNParseConsole();
            }

            switch (condition)                                                    //Checking a console string for condition
            {
                case ">0":
                    while (number <= 0)
                    {
                        ShowError();
                    }
                    break;
                case ">=0":
                    while (number < 0)
                    {
                        ShowError();
                    }
                    break;
                case "<0":
                    while (number >= 0)
                    {
                        ShowError();
                    }
                    break;
                case "<=0":
                    while (number > 0)
                    {
                        ShowError();
                    }
                    break;
                default:
                    break;
            }
            return number;
        }
    }
}
