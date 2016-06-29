using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IstericaGame
{
    class ActionsOnWords
    {
        public List<string> words = new List<string>();
        public List<string> wordsWinsPlayers = new List<string>();

        public void FillWord(int q)
        {
            string word;
            for (int i = q; i > 0; i--)
            {
                do
                {
                    word = Console.ReadLine();
                } while (!IsWordCorrent(word));
                words.Add(word);
            }
        }

        public static bool IsWordCorrent(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsLetter(str[i])||str[i]==' ')
                {
                    Console.WriteLine("Not correct word");
                    return false;
                }
            }
            return true;
        }

        static public void DisplayAllWord(List<string> ls)
        {
            Type t = ls.GetType();
            Console.WriteLine("list of {0} contein", t.Name);
            foreach (string s in ls)
                Console.WriteLine(s);
        }

    }
}
