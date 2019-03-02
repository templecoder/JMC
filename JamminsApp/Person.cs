using System;
using System.Collections.Generic;
using System.Text;

namespace JamminsApp
{
    public class Person
    {
        public string LastName;
        public string FirstName;

        public int Age;

        public int IQ;

        public bool HasWeaponLicence;
        public bool IsKgbAgent;

        public string Language;

        public Person()
        {

        }

        public Person(string firstName, string lastName, string language, bool hasWeaponLicense = false, int age = 0, int iq = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Language = language;

            HasWeaponLicence = hasWeaponLicense;

            Age = age;
            IQ = iq;
        }

        public string GetInfoDetails()
        {
            return $"First name: {FirstName} " +
                $"Last name: {LastName} " +
                $"Age: {Age} " +
                $"IQ: {IQ} " +
                $"Haslicence: {HasWeaponLicence} " +
                $"Speaks languages: {Language}" +
                $"IsAgent: {IsKgbAgent}";
        }
    }
}














