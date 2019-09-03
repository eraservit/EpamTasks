using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;


namespace EpamTasks
{
    class Task3
    {
        public static void ExecTask3()
        {
            string text = "!,. @ \\ # $ % ^ & * ( )_ + = -' \\ : | / `~., { }  ) ] [ ]  ()best one two best map three five six& seven test*best two Enything eight map MaP- bool+ nine one enything? six two one seven google. GOOgle !";
            //string text = "one a a a nine six a";
            Console.WriteLine("\n\nTASK 3 \nOur string: {0}", text);
            GetUniqueWords(text);
        }


        static void GetUniqueWords(string text)
        {
            var re = new Regex(@"[^\w]+|(_)+|[0-9]");
            var re2 = new Regex(@"\s{2,}");
            text = re.Replace(text.Trim(), " ");
            text = re2.Replace(text.Trim(), "");
            string[] textArray = text.Split(' ');

            List<string> words = new List<string>();
            List<string> uniqWords = new List<string>();

            foreach (string word in textArray)
                words.Add(word.ToLower());
            words.Sort();

            Array.Clear(textArray, 0, textArray.Length);

            float totalWords = words.Count, currentPercent;
            int percent = 0;

            DateTime start = DateTime.Now;

            bool wordFound, next;
            for (int i = 0; i < words.Count;)
            {
                wordFound = false;
                next = false;

                for (int j = 1; j < words.Count & !next; j++)
                {
                    if (words[j] == words[i] & j < words.Count)
                    {
                        words.RemoveAt(j);
                        wordFound = true;
                        j--;
                    }
                    if (words[i][0] != words[j][0]) next = true;
                }

                if (!wordFound) uniqWords.Add(words[i]);

                words.RemoveAt(i);
                currentPercent = (100 - (words.Count / totalWords) * 100);

                if (currentPercent >= percent)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write("Progress: {0:F}% ", currentPercent);
                    percent++;
                }
            }

            DateTime end = DateTime.Now;
            Console.WriteLine("for " + (end - start).TotalSeconds.ToString() + " seconds");
            Console.Write("\nUnique words:");
            foreach (string word in uniqWords)
                Console.Write(" " + word);
            uniqWords.Clear();
        }

    }
}
