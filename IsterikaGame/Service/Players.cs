using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IstericaGame
{
    class Player
    {
        public string name { get; protected set; }

        public ActionsOnWords ActionOnWords = new ActionsOnWords();

        public Player()
        { name = "empty constructor"; }

        public Player(string n)
        { name = n; }

        public void ShowPlayerName()
        {
            Console.WriteLine(name);
        }

        public override string ToString()
        {
            string s = "Player " + name + " ";
            return s;
        }

    }
}
