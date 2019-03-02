using System;
using System.Collections.Generic;
using System.Text;

namespace JamminsApp
{
    public class Person
    {
        protected string LastName;
        protected string FirstName;

        public int Age;

        protected int IQ;

        protected bool HasWeaponLicence;
        protected bool IsKgbAgent;

        protected string Language;

        public Person(string firstName, string lastName, string language, bool hasWeaponLicense = false, int age = 0, int iq = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Language = language;

            HasWeaponLicence = hasWeaponLicense;

            Age = age;
            IQ = iq;
        }
    }
}














