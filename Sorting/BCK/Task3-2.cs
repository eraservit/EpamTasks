using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;


namespace Sorting
{
    class Task3
    {
        public static void ExecTask3()
        {
            string text = "!,. @ \\ # $ % ^ & * ( )_ + = -' \\ : | / `~., { }  ) ] [ ]  () one two three five six& seven test*best two Enything eight map MaP- bool+ nine one enything? six two one seven google. GOOgle !";
            Console.WriteLine("\n\nTASK 3 \nOur string: {0}", text);
            Console.WriteLine("\nUnique words in string: {0}");
            GetUniqueWords(text);

            text = "";

            string filePath = "D:\\Sample.txt";
            try
            {
                StreamReader textFile = new StreamReader(filePath);
                text = textFile.ReadToEnd();
                textFile.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("\nUnique words in file {0}:", filePath);
                GetUniqueWords(text, true);
            }
        }


        static void GetUniqueWords(string text, bool sort = false)
        {
            var re = new Regex(@"[^\w]+|(_)+|[0-9]");
            text = re.Replace(text.Trim(), " ");
            string[] textArray = text.Split(' ');

            List<string> words = new List<string>();
            List<string> uniqWords = new List<string>();

            foreach (string word in textArray)
            {
                words.Add(word.ToLower());
            }

           // words.Sort();
            Console.WriteLine("Words: {0}", words.Count);
            float progress = words.Count; int percent = 0;

            
            bool wordFound;
            for (int i = 0; i < words.Count;)
            {
                
                wordFound = false;
                for (int j = 1; j < words.Count; j++)
                {
                    if (words[i] == words[j])
                    {
                        words.RemoveAt(j);
                        wordFound = true;
                    }
                }
                
                if (!wordFound) uniqWords.Add(words[i]);
                words.RemoveAt(i);
                if ((100 - (words.Count / progress) * 100) >= percent)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write("Progress: {0:F}%  ", (100 - (words.Count / progress) * 100));
                    percent += 1;
                }

            }
            if (sort) uniqWords.Sort();
            text = "";
            foreach (string word in uniqWords)
                Console.Write(" " + word);
        }

    }
}
