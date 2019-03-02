using System;
using System.Collections.Generic;
using System.Text;

namespace JamminsApp
{
    public class SuspectDataBase
    {
        #region Fields
        private string[] FirstNames;
        private string[] LastNames;
        private string[] Languages;

        private Random _rngGenerator;

        public enum Countries
        {
            USA,
            Russia,
            China,
            Japan,
            Mongolia,
            Azerbajan,
            Germany,
            Austria
        }
        #endregion

        public SuspectDataBase()
        {
            InitializeDatabase();
        }

        private bool GetRandomBoolean()
        {
            return _rngGenerator.Next(0, 2) == 1;
        }

        private void InitializeDatabase()
        {
            FirstNames = new string[] { "Mark", "Jammin", "Alex", "Christoph", "Jasmine", "Sue", "Thomas", "Vladimir", "Görümz", "Georgi", "Martin", "Armin", "Artur", "Sam", "Heinrich" };
            LastNames = new string[] { "Bachleitner", "Korjagin", "Panzenboek", "Balber", "Krastiev", "Putin", "Trump", "Smith", "Merkel", "Erdogan", "Kural", "LolITrollYou", "Williams", "Musterman" };
            Languages = new string[] { "English", "German", "Japanese", "Russian", "Portuguese", "French", "Spanish", "Chinese" };

            _rngGenerator = new Random();
        }

        public Person GetSuspect()
        {
            var randomFirstName = FirstNames[_rngGenerator.Next(0, FirstNames.Length)];
            var randomLastName = LastNames[_rngGenerator.Next(0, LastNames.Length)];
            var randomLanguage = Languages[_rngGenerator.Next(0, Languages.Length)];

            var randomAge = _rngGenerator.Next();
            var randomIQ = _rngGenerator.Next();

            var randomHasWeaponLicense = GetRandomBoolean();

            var foundSuspect = new Person(randomFirstName, randomLastName, randomLanguage, randomHasWeaponLicense, randomAge, randomIQ);

            return foundSuspect;
        }
    }
}
