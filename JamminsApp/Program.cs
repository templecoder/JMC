using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JamminsApp
{
    public class Program
    {
        private static AuthorizationManager _authorizationManager;
        private static SuspectDataBase _suspectDataBase;
        private static KgbAgentFinder _kgbAgentFinder;
        private static string _userName;

        private static int delayTimer = 7;

        static void Main(string[] args)
        {
            Initialize(delayTimer);
            GreetUser();
            GetUserName();

            if (IsUserAuthorized())
            {
                _suspectDataBase = new SuspectDataBase();
                var suspectList = _suspectDataBase.CreateSuspectList(50000);

                _kgbAgentFinder = new KgbAgentFinder(_userName, suspectList);
                _kgbAgentFinder.CreateSuspectList();
                PrintSuspects();
            }

            Console.ReadKey();
        }

        public static void PrintSuspects()
        {
            var agentsFound =_kgbAgentFinder.GetFlaggedPositives();

            foreach (var agent in agentsFound)
            {
                Console.WriteLine(agent.GetInfoDetails());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Total agents found: {agentsFound.Count}");
        }

        private static void GreetUser()
        {
            Print(JamminsAppExtensions.PrintOrangeJuiceCatalogArt());
            JamminsAppExtensions.PrintEmptyLines(3);
        }

        private static bool IsUserAuthorized()
        {

            _authorizationManager.HandleUserAuthorization(_userName);
            return _authorizationManager.UserIsAuthorized;
        }

        private static void Initialize(int delayBeforeExit)
        {
            _authorizationManager = new AuthorizationManager(delayBeforeExit);
        }

        private static void GetUserName()
        {
            Console.Write($"Who are you?: ");
            var userName = Console.ReadLine();

            while (EnteredUserNameIsInvalid(userName))
            {
                Console.Clear();
                GreetUser();
                Print($"Please enter a valid Username!..");
                Console.Write($"Who are you?: ");
                userName = Console.ReadLine();
            }

            _userName = userName;
        }

        private static bool EnteredUserNameIsInvalid(string userName)
        {
            return string.IsNullOrWhiteSpace(userName) || userName.Length < 3;
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}



//Pseudo Code App:

//D    Greeet

//    Enter loop for x iterations
//D       Erstellt person
//        Gibt Person in Liste
//        Repeat loop for x - 1 iterations
//    Exit loop

//    Create KgbFinder with loopresult    
//        KgbFinder iteriert über liste => 
//        Filtert personen und speichert in resultliste 

//    Liste wird dargestellt







