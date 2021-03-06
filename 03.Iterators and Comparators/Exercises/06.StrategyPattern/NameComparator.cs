﻿namespace _06.StrategyPattern
{
    using System.Collections.Generic;

    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            var result = firstPerson.Name.ToLower().
                CompareTo(secondPerson.Name.ToLower());

            if (firstPerson.Name.Length == secondPerson.Name.Length)
            {
                return result;
            }

            return firstPerson.Name.Length.
                CompareTo(secondPerson.Name.Length);
        }
    }
}