using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;

namespace IstericaGame
{
    class WordsTogater
    {
        List<string> wordTogether = new List<string>();
        List<Word> wordsFromDB = new List<Word>();

        public List<string> ListOfWords
        {
            get
            {
                return wordTogether;
            }

        }
        public List<Word> WordsFromDB
        {
            get
            {
                return wordsFromDB;
            }
        }

        public void PlayersTogether(List<Player>[] commands)
        {
            for (byte numCommand = 0; numCommand < commands.Length; numCommand++)
            {
                foreach (Player p in commands[numCommand])
                    GatherAllWords(p.ActionOnWords.words);
            }
        }

        void GatherAllWords(List<string> words)
        {
            foreach (string word in words)
                wordTogether.Add(word);
        }

        Random random = new Random(Convert.ToInt32(DateTime.Now.Millisecond));

        public void GetAllWordsFromDB(List<Player>[] commands)
        {
            List<int> idOfWords = new List<int>();
            CreatePlayers.WriteNumberOfWords();

            using (var _db = new IsterikaGameDBEntities())
            {
                int countOfWordInDb = _db.Words.Count();
                for (byte i = 0; i < commands.Length; i++)
                {
                    for (byte j = 0; j < commands[i].Count(); j++)
                    {
                        for (byte y = 0; y < CreatePlayers.NumberOfWordsByPlayer; y++)
                        {
                            idOfWords.Add(random.Next(0, countOfWordInDb));
                        }
                    }
                }

                var words = from w in _db.Words
                                where idOfWords.Contains(w.id)
                                select w;

                wordsFromDB = words.ToList();
            }

        }

    }
}
