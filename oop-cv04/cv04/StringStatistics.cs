using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv04
{
    class StringStatistics
    {
        private string text { set; get; }
        public StringStatistics(string text)
        {
            this.text = text;
        }

        public int NumberOfWords()
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            int words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            return words;
        }

        public int NumberOfRows()
        {
            int rows = text.Split('\n').Length;
            return rows;
        }
        public int NumberOfSentences()
        {
            char[] delimiters = new char[] { '.', '!', '?' };
            string textReplaced = text.Replace("\n", "").Replace(" ", "");
            string[] rows = textReplaced.Split(delimiters);
            int sentences = 0;
            for (int i = 0; i < rows.Length - 2; i++)
            {
                if(i == 0 && Char.IsUpper(rows[i][0]))
                {
                    sentences++;
                }
                if (Char.IsUpper(rows[i + 1][0]))
                {
                    sentences++;
                }
            }
      
            return sentences;                                                                               
        }

        public ArrayList LongestWords()
        {
            ArrayList longestWords = new ArrayList();
            string textReplaced = text.Replace("\n", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace("\r", "").Replace("(", "").Replace(")", "").Replace(",", "");
            
            string[] words = textReplaced.Split(' ');
            int maxLength = 0;
            foreach (var word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    longestWords.Clear();
                    longestWords.Add(word);
                }
                else if (word.Length == maxLength)
                {
                    longestWords.Add(word);
                }

            }
            return longestWords;
        }

        public ArrayList ShortestWords()
        {
            ArrayList shortestWords = new ArrayList();
            string textReplaced = text.Replace("\n", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace("\r", "").Replace("(", "").Replace(")", "").Replace(",", "");
            string[] words = textReplaced.Split(' ');
            int minLength = 100;
            foreach (var word in words)
            {
                if (word.Length < minLength)
                {
                    minLength = word.Length;
                    shortestWords.Clear();
                    shortestWords.Add(word);
                }
                else if (word.Length == minLength)
                {
                    shortestWords.Add(word);
                }

            }
            return shortestWords;
        }

        public ArrayList MostCommonWords()
        {
            var freq = new Dictionary<string, int>();
            ArrayList commonWords = new ArrayList();
            int highestFreq = 0;
            string textReplaced = text.Replace("\n", " ").Replace(".", "").Replace("!", "").Replace("?", "").Replace("\r", "").Replace("(", "").Replace(")", "").Replace(",", "");
            string[] words = textReplaced.Split(' ');
            foreach (var word in words)
            {

                if (freq.ContainsKey(word))
                {
                    freq[word]++;
                }
                else
                {
                    freq.Add(word, 1);
                }
            }
            foreach (var key in freq)
            {
                if (key.Value > highestFreq)
                {
                    highestFreq = key.Value;
                    commonWords.Clear();
                    commonWords.Add(key.Key);
                }
                else if (key.Value == highestFreq)
                {
                    commonWords.Add(key.Key);
                }
            }
            return commonWords;

        }

        public ArrayList SortedWords()
        {
            ArrayList wordList = new ArrayList();
            string textReplaced = text.Replace("\n", " ").Replace(".", "").Replace("!", "").Replace("?", "").Replace("\r", "").Replace("(", "").Replace(")", "").Replace(",", "");
            string[] words = textReplaced.Split(' ');
            foreach (var item in words)
            {
                wordList.Add(item);
            }
            wordList.Sort();
            return wordList;
        }

        public bool IsSafeFromPutin()
        {
            List<string> problematicWords = new List<string> { "svoboda", "ropa", "plyn", "ukrajina", "nato", "putin" };
            string textReplaced = text.Replace("\n", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace("\r", "").Replace("(", "").Replace(")", "").Replace(",", "").ToLower();
            string[] words = textReplaced.Split(' ');
            for (int i = 0; i < problematicWords.Count; i++)
            {
                foreach (var word in words)
                {
                    if (problematicWords[i] == word)
                    {
                        return false;
                    }
                }
            }
            return true;
    

        }

        public StringBuilder PrintList(ArrayList arrayList)
        {
            StringBuilder text = new StringBuilder();
            if (arrayList.Count == 1)
            {
                text.Append(arrayList[0]);
            }
            else
            {
                foreach (var item in arrayList)
                {
                    text.Append(item).Append(", ");
                }
            }
            return text;
        }


        public override string ToString()
        {
            return this.text;
        }
    }

}
