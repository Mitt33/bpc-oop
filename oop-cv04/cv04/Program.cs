using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv04
{
    class Program
    {
        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
                                    + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                                    + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                                    + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                                    + "posledni veta!";

            StringStatistics s = new StringStatistics(testovaciText);
            Console.WriteLine("Number of words is: {0}", s.NumberOfWords());
            Console.WriteLine("Number of rows is: {0}", s.NumberOfRows());
            Console.WriteLine("Number of sentences is: {0}", s.NumberOfSentences());
            Console.WriteLine("Longest words are: {0}", s.PrintList(s.LongestWords()));
            Console.WriteLine("Shortest words are: {0}", s.PrintList(s.ShortestWords()));
            Console.WriteLine("Most common words are: {0}", s.PrintList(s.MostCommonWords()));
            Console.WriteLine("Words sorted by alphabet are: {0}", s.PrintList(s.SortedWords()));
            Console.WriteLine("Is this text safe from Putin? {0}", s.IsSafeFromPutin());
            Console.ReadLine();
        }
    }
}
