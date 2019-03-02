using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JamminsApp
{
    public class KgbAgentFinder
    {
        private List<Person> Suspects { get; set; }
        private List<Person> FlaggedPositives { get; set; }

        public KgbAgentFinder(string userName, List<Person> suspects)
        {
            Suspects = suspects;
            FlaggedPositives = new List<Person>();
        }

        public void GreetUser(string userName)
        {
            Console.WriteLine("Willkommen, " + userName + "!");
        }

        public void CreateSuspectList()
        {
            CreateSuspectedAgentsList();
        }

        public List<Person> GetFlaggedPositives()
        {
            if (!FlaggedPositives.Any())
            {
                throw new ArgumentNullException($"Please run engine before fetching flagged positives list.");
            }

            return FlaggedPositives;
        }

        private void CreateSuspectedAgentsList()
        {
            FlaggedPositives.AddRange(Suspects.Where(s => IsKGBAgent(s)));
        }

        private bool IsKGBAgent(Person suspect)
        {

            if (suspect.Age >= 30 &&
                suspect.Language == "Russian" ||
                suspect.Language == "English" ||
                suspect.Language == "Chinese" ||
                suspect.Language == "German " &&
                suspect.HasWeaponLicence &&
                suspect.IQ >= 130)
            {
                suspect.IsKgbAgent = true;
                return true;
            }

            return false;
        }
    }
}
