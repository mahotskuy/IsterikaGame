using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Models;
using Message = Service.Constant.ShowRandomWords;

namespace IstericaGame
{
    class ShowRandomWord
    {
        Random rw = new Random();
        List<string> Words;
        List<Word> WordsFromDB;
        static int timerInms = 30000;
        public List<Player>[] Commands { get; set;}

        public ShowRandomWord(List<string> words, List<Player>[] commands)
        { 
            Words=words;
            Commands = commands;

            InvokePlayer();
            ShowResult();
        }

        public ShowRandomWord(List<Word> wordsFromDB)
        {
            WordsFromDB = wordsFromDB;
        }

        public T RandomWord <T>(List<T> listOfWords) 
        {
            return listOfWords[rw.Next(listOfWords.Count)];
        }

        public System.Timers.Timer t = new System.Timers.Timer(10000);
        bool IsTimerOccured = false;
        int currentCommand = 1;
        public int []currentPlayerForCommand;

        public void InvokePlayer()
        {
            currentPlayerForCommand = new int[Commands.Length];
            t.Elapsed += ShowWhenTimeOccured;
            Console.WriteLine(Message.WaitNextPlayer, Commands[currentCommand][currentPlayerForCommand[currentCommand]].ToString());
            Console.ReadLine();

            ShowWord();

            Console.Clear();
            Console.WriteLine(Message.AllWordIsExplained);
        }

        private void ShowWord()
        {
            while (Words.Count != 0)
            {
                t.Enabled = true;
                IsTimerOccured = false;
                Console.Clear();
                string st = RandomWord<string>(Words);
                Console.WriteLine(st);
                Console.ReadLine();
                if (!IsTimerOccured)
                {
                    Console.Beep();
                    Commands[currentCommand][currentPlayerForCommand[currentCommand]].ActionOnWords.wordsWinsPlayers.Add(st);
                    Words.Remove(st);
                }
            } t.Enabled = false;
        }

        void ShowWhenTimeOccured(Object source, System.Timers.ElapsedEventArgs e)
        {
            IsTimerOccured = true;
            Console.Clear();
            t.Enabled = false;
            Math.DivRem(++currentPlayerForCommand[currentCommand], Commands[currentCommand].Count, out currentPlayerForCommand[currentCommand]);
            Math.DivRem(++currentCommand, Commands.Length, out currentCommand);
            Console.Beep(1000, 1500);
            Console.WriteLine(Message.WaitNextPlayer, Commands[currentCommand][currentPlayerForCommand[currentCommand]].ToString());
        }

       public void ShowResult()
        {
            List<int> result = new List<int>();
            string WinerCommand=" ";
            int CurrentGoals;
            int MostGoals=0;
            for (byte numOfCommand = 0; numOfCommand < Commands.Length; numOfCommand++)
            {
                CurrentGoals=0;
                foreach (Player player in Commands[numOfCommand])
                {
                    {
                        CurrentGoals += player.ActionOnWords.wordsWinsPlayers.Count;
                    }
                    if (CurrentGoals > MostGoals)
                    {
                        MostGoals = CurrentGoals;
                        WinerCommand = Convert.ToString(currentCommand);
                    }
                }
            }
            Console.WriteLine(Message.ShowWiner, WinerCommand, MostGoals);

            for (byte numOfCommand = 0; numOfCommand < Commands.Length; numOfCommand++)
            {
                Console.WriteLine(Message.ForShowingNameOfCommand,numOfCommand+1);
                foreach (Player p in Commands[numOfCommand])
                {
                    Console.WriteLine(Message.ShowHowManyWordExplainedByPlayer, p.ToString(), p.ActionOnWords.wordsWinsPlayers.Count);
                    result.Add(p.ActionOnWords.wordsWinsPlayers.Count);
                    Console.WriteLine(Message.ForShowingListOfExplainedWordByPlayer);
                    foreach (string s in p.ActionOnWords.wordsWinsPlayers)
                        Console.WriteLine(s);
                }
            }
        }
    }
}
