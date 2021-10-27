using System;
using System.Collections.Generic;
using System.Text;

namespace treeProblem
{
    public class Genealogy
    {
        public static bool AreThesePeopleRelated(Person a, Person b)
        {
            if (a == null || b == null) return false;

            HashSet<Person> travelSet = new HashSet<Person>(256);

            return DetermineIfRelative(a, b, travelSet) || DetermineIfRelative(b, a, travelSet);
        }

        private static bool DetermineIfRelative(Person traveler, Person destination, HashSet<Person> set)
        {
            if (traveler == destination || set.Contains(traveler)) return true;

            set.Add(traveler);

            return DetermineIfRelative(traveler.Mother, destination, set) || DetermineIfRelative(traveler.Father, destination, set);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>An array of 2 people that we are trying to look for</returns>
        public static Person[] CreateGenealogyTree()
        {
            // Family 1:
            Person mom1 = new Person(null, null);
            Person dad1 = new Person(null, null, mom1);
            List<Person> family1Kids = mom1.HaveChildren(3);

            // Family 2:
            Person mom2 = new Person(null, null);
            Person dad2 = new Person(null, null, mom2);
            List<Person> family2Kids = mom2.HaveChildren(3);

            // Family 3:
            Person mom3 = new Person(null, null);
            Person dad3 = new Person(null, null, mom3);
            List<Person> family3Kids = mom3.HaveChildren(3);

            family1Kids[0].GetMarriedTo(family2Kids[0]);
            List<Person> grandKids12 = family1Kids[0].HaveChildren(3);

            family2Kids[2].GetMarriedTo(family3Kids[2]);
            List<Person> grandKids23 = family3Kids[2].HaveChildren(3);


            return new Person[] { mom1, dad2 };

            //// First Tree:
            //// Gen 2:
            //Person person01_gen2 = new Person();
            //Person fatherOfGen1 = new Person();
            //Person motherOfGen1 = new Person();
            //fatherOfGen1.GetMarriedTo(motherOfGen1);

            //// Gen 1:
            //Person person01_gen1 = new Person(motherOfGen1, fatherOfGen1);
            //Person person02_gen1 = new Person(motherOfGen1, fatherOfGen1);
            //Person person03_gen1 = new Person(motherOfGen1, fatherOfGen1);
            //Person person04_gen1 = new Person(motherOfGen1, fatherOfGen1);
            //Person person05_gen1 = new Person(motherOfGen1, fatherOfGen1);
        }
    }
}
