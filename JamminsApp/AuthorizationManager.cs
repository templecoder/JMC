using System;
using System.Threading;
using System.Threading.Tasks;

namespace JamminsApp
{
    public class AuthorizationManager
    {
        protected int _delayBeforeExit = 0;
        public bool UserIsAuthorized;

        public AuthorizationManager(int secondsDelay)
        {
            _delayBeforeExit = secondsDelay;
        }

        public async Task WaitForSecondsAndExit(int delayBeforeExit)
        {
            Console.WriteLine();

            await Task.Run(() =>
            {
                for (int i = delayBeforeExit; i > 0; i--)
                {
                    Console.WriteLine($"Exiting orange-juice-catalog in: {i}");
                    Thread.Sleep(1000);
                }             
            });

            Environment.Exit(0);
        }

        public bool IsAuthorizedUser(string userName)
        {
            return userName.ToLower().Equals("jammin") || userName.ToLower().Equals("mark");
        }

        public bool HandleUserAuthorization(string userName)
        {
            if (IsAuthorizedUser(userName))
            {
                HandleAuthorizedUser(userName);
                UserIsAuthorized = true;
                return UserIsAuthorized;
            }

            HandleUnauthorizedUser();
            return UserIsAuthorized;
        }

        private void HandleAuthorizedUser(string userName)
        {
            Console.Clear();
            Console.WriteLine(JamminsAppExtensions.PrintKGBAsciiArt());
            JamminsAppExtensions.PrintEmptyLines(3);
            PrintKGBGreeting(userName);

            InitializeKGBService(userName);
        }

        private void InitializeKGBService(string userName)
        {
            //var kgbService = new KgbAgentFinder(userName);
        }

        private async Task HandleUnauthorizedUser()
        {
            Console.WriteLine($"[Error 3301]: SqlSocketException.. Table 'Mexican-Orangzes' could not be found... ");
            Console.WriteLine("Press any key to exit..");
            JamminsAppExtensions.PrintEmptyLines(1);
            await WaitForSecondsAndExit(_delayBeforeExit).ConfigureAwait(false);
        }

        private void PrintKGBGreeting(string userName)
        {
            Console.WriteLine($"Welcome to the KGB agent finder, {MapUserToAlias(userName)}!");
        }

        private string MapUserToAlias(string userName)
        {
            switch(userName)
            {
                case "jammin":
                    return "Tanuki" ;
                case "mark":
                    return "Supersloth";
                default:
                    return "Who.. are you?..";
            }
        }
    }
}