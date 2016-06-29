using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Message = Service.Constant.CreatePlayersMessages;
using Error = Service.Constant.ErrorMessage;
namespace IstericaGame
{
    class CreatePlayers
    {
        protected List<Player>[] _commands;

        protected int QuontityOfCommands = 0;

        public List<Player>[] Commands { get { return _commands; } }

        public CreatePlayers() 
        {
            CreatePlayerList();

            ShowPlayers();
        }

        protected void InitialCommands()
        {
            for (byte numOfCommand = 0; numOfCommand < _commands.Length; numOfCommand++)
                _commands[numOfCommand] = new List<Player>();
        }

        public void CreatePlayerList()
        {
            WriteNumberOfCommands();
            InitialCommands();
            byte currentCommand = 0;
            string PlayerName;
            Console.WriteLine(Message.InstructionForFillPlayersName, currentCommand + 1);
            while (currentCommand < QuontityOfCommands)
            {
                PlayerName = Console.ReadLine();
                if (ActionsOnWords.IsWordCorrent(PlayerName) && PlayerName.Equals(Message.SingOfEndOfTypingInCycle, StringComparison.OrdinalIgnoreCase) != true)
                {
                    _commands[currentCommand].Add(new Player(PlayerName));
                }
                if (PlayerName.Equals(Message.SingOfEndOfTypingInCycle, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    currentCommand++;
                    Console.WriteLine(Message.InstructionForFillPlayersName, currentCommand + 1); 
                }
            }
        }

        private  void WriteNumberOfCommands()
        {
            bool IsNotAnError = false;
            do
            {
                IsNotAnError = false;
                try
                {
                    Console.WriteLine(Message.WriteNumOfCommand);
                    QuontityOfCommands = Convert.ToInt16(Console.ReadLine());
                    _commands = new List<Player>[QuontityOfCommands];
                }
                catch (FormatException e)
                {
                    IsNotAnError = true;
                    Console.WriteLine(Error.NotNumber);
                }
            } while (IsNotAnError);
        }

        int numberOfWordsByPlayer;

        public static int NumberOfWordsByPlayer { get; private set; }

        public static void WriteNumberOfWords()
        {
            bool IsNotError = false;
            do
            {
                IsNotError = false;
                try
                {
                    Console.Write(Message.QuonityOfWords);
                    NumberOfWordsByPlayer = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    IsNotError = true;
                    Console.WriteLine(Error.NotNumber);
                }
            } while (IsNotError);
        }

        public bool IsChooseFromDataBase()
        {
            bool isOccuredError=false;
            int variant=0;
            do
            {
                Console.WriteLine(Message.ChooseWordsFromDB);
                isOccuredError = false;
                try
                {
                    variant = Convert.ToInt32(Console.ReadLine());
                    if (variant != 1 && variant != 2)
                    {
                        Console.WriteLine(Error.NotCorrectVariantIsChooseFromDB);
                        isOccuredError = true;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(Error.NotCorrectVariantIsChooseFromDB);
                    isOccuredError = true;
                }
            } while (isOccuredError);

            switch (variant)
            {
                case 1:
                    return true;
                case 2:
                    return false;
                default :
                    return true;
            }
        }

        public void FillWordsAnyPlayers()
        {
            WriteNumberOfWords();
            for (byte i = 0; i < _commands.Length;i++ )
            {
                foreach (Player pl in _commands[i])
                {
                    Console.Clear();
                    Console.WriteLine(Message.InstructionForFillWords, pl.ToString());
                    pl.ActionOnWords.FillWord(NumberOfWordsByPlayer);
                    Console.Clear();
                }
            }
        }

        public void ShowPlayers()
        {
            byte b = 0;
            for (int numCommand = 0; numCommand < _commands.Length;numCommand++ )
            {
                Console.WriteLine(Message.ForDisplayCommandName, numCommand);
                Console.WriteLine(Message.ForDisplayNameOfPlayers);
                foreach (Player player in _commands[numCommand])
                {
                    player.ShowPlayerName();
                }
            }
        }

    }
}
