using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace IstericaGame
{
    class Demo
    {
        static void Main(string[] args)
        {
            CreatePlayers cp = new CreatePlayers();
            WordsTogater wt = new WordsTogater();

            if (cp.IsChooseFromDataBase())
            {
                wt.GetAllWordsFromDB(cp.Commands);
                ShowRandomWord srw = new ShowRandomWord(wt.WordsFromDB.Select(w=>w.Word1).ToList(), cp.Commands);
            }
            else
            {
                cp.FillWordsAnyPlayers();
                wt.PlayersTogether(cp.Commands);
                ShowRandomWord srw = new ShowRandomWord(wt.ListOfWords, cp.Commands);
            }
            System.Threading.Thread.Sleep(5000);
            Console.ReadLine();
        }
    }
    
}
