using System;
using System.Collections.Generic;
using System.Text;

namespace JamminsApp
{
    public class KgbAgentFinder
    {
        private List<Person> Suspects { get; set; }

        public KgbAgentFinder(string userName, IEnumerable<Person> suspects)
        {
            Suspects = (List<Person>) suspects;
        }

        public void GreetUser(string userName)
        {
            Console.WriteLine("Willkommen, " + userName + "!");
        }
    }
}
