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
            ShowRandomWord srw;
            cp.CreatePlayerList();
            cp.ShowPlayers();
            if (cp.IsChooseFromDataBase())
            {
                wt.GetAllWordsFromDB(cp.commands);
                 srw= new ShowRandomWord(wt.WordsFromDB);
            }
            else
            {
                cp.FillWordsAnyPlayers();
                wt.PlayersTogether(cp.commands);
                 srw = new ShowRandomWord(wt.ListOfWords);
            }
            srw.InvokePlayer(cp);
            srw.ShowResult();
            System.Threading.Thread.Sleep(5000);
            Console.ReadLine();
        }
    }
    
}
