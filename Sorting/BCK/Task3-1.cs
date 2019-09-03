using System;
using System.Collections;

namespace Sorting
{
    class Task3
    {
        public static void ExecTask3()
        {
            string text = "one two three five six seven two eight nine one six";
            Console.WriteLine("\n\nTASK 3, Our string: {0}", text);
            string[] textArray = text.Split(' ');
            Queue totalwords = new Queue();
            foreach (string word in textArray)
            {
                int findcount = 0;
                while (findcount < 2)
                {
                    for (int i = 0; i < textArray.Length; i++)
                    {
                        if (textArray[i] == word)
                            findcount++;
                    }

                    if (findcount < 2)
                    {
                        totalwords.Enqueue(word);
                    }
                }
            }
            PrintTotalWords(totalwords);

        }

        static void PrintTotalWords(IEnumerable myCollection)
        {
            Console.Write("Uniquie words :");
            foreach (Object obj in myCollection)
                Console.Write(" {0}", obj);
        }
    }
}
