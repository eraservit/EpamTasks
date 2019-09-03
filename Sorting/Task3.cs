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
            //string text = "!,. @ \\ # $ % ^ & * ( )_ + = -' \\ : | / `~., { }  ) ] [ ]  ()best one two best map three five six& seven test*best two Enything eight map MaP- bool+ nine one enything? six two one seven google. GOOgle !";
            string text = "one a a a nine six a";
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
            var re2 = new Regex(@"\s{2,}");
            text = re.Replace(text.Trim(), " ");
            text = re2.Replace(text.Trim(), "");
            string[] textArray = text.Split(' ');
            Array.Sort(textArray);

            List<string> words = new List<string>();
            List<string> uniqWords = new List<string>();

            foreach (string word in textArray)
            {
                words.Add(word.ToLower());
            }
            Array.Clear(textArray, 0, textArray.Length);

            //words.Sort();
            //foreach (string word in words)
            //    Console.Write(" " + word);
            //Console.WriteLine("Words begin: 1:'{0}' 2:'{1}' 3:'{2}' ALL:'{3}'---",words[0], words[1], words[3],words.Count);
            Console.WriteLine("\nWords: {0} ", words.Count);
            float progress = words.Count; int percent = 0;
            //включаем таймер
            DateTime start = DateTime.Now;

            bool wordFound;
            for (int i = 0; i < words.Count;)
            //for (int i = words.Count-1; i > 0;i--)
            {
                //Console.WriteLine("Main Letter[{1}]:{0}", words[i][0], i);
                wordFound = false;
                bool next = false;
                //for (int j = 1; j < words.Count; j++)
                for (int j =1; j < words.Count & !next; j++)
                //for (int j = words.Count - 1; j > 0 & !next; j--)
                {
                    //Console.WriteLine("Letter[{1}]:{0}", words[j][0], j);
                    if (words[j] == words[i] & j < words.Count)
                    {
                        //Console.WriteLine("Remove word[{1}]:{0}", words[j][0], j);
                        words.RemoveAt(j);
                        wordFound = true;
                        j--;
                    }
                    if (words[i][0] != words[j][0]) next = true;
                }

                if (!wordFound)
                {
                    uniqWords.Add(words[i]);
                }
                //Console.WriteLine("Main remove word[{1}]:{0}", words[i][0], i);
                words.RemoveAt(i);
                if ((100 - (words.Count / progress) * 100) >= percent)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write("Progress: {0:F}%  ", (100 - (words.Count / progress) * 100));
                    percent += 1;
                }

            }
            //выключаем таймер
            DateTime end = DateTime.Now;
            Console.WriteLine((end - start).TotalSeconds.ToString() + " sec");
            //Console.ReadKey();
            if (sort) uniqWords.Sort();
            text = "";
            foreach (string word in uniqWords)
                Console.Write(" " + word);
        }

    }
}
