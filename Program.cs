using System;


namespace ConsoleApplication1
{
    class Demo
    {
        static void Main(string[] args)
        {

            CreatePlayers cp = new CreatePlayers();
            cp.CreatePlayerList();
            cp.ShowPlayers();
            cp.FillWordsAnyPlayers();
            WordsTogater wt = new WordsTogater();
            wt.PlayersTogether(cp.players);
            ShowRandomWord srw = new ShowRandomWord(wt);
            srw.RandomInvoik(cp);
            
                Console.ReadLine();
        }
    }
}
