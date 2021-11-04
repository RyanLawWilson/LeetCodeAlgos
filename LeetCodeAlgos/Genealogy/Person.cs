using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAlgos
{
    public class Person
    {
        public string Name { get; set; }
        public Person Spouse { get; set; }
        public Person Mother { get; set; }
        public Person Father { get; set; }
        public List<Person> Children { get; set; }

        public Person(Person spouse)
        {
            Spouse = spouse;
            Name = Tools.GetRandomName();
        }

        public Person(Person mother, Person father)
        {
            Mother = mother;
            Father = father;
            Name = Tools.GetRandomName();
        }

        public Person(Person mother, Person father, Person spouse) : this(mother, father)
        {
            GetMarriedTo(spouse);
        }

        public void GetMarriedTo(Person spouse)
        {
            Spouse = spouse;
            Spouse.Spouse = this;
        }

        public List<Person> HaveChildren(int numOfKids)
        {
            if (Spouse == null)
            {
                Console.WriteLine("You need a Spouse to have children");
                return null;
            }

            Random rand = new Random();
            int numberOfChildren = numOfKids == 0 ? rand.Next(1,5) : numOfKids;

            Children = new List<Person>(numberOfChildren);

            for (int i = 0; i < numberOfChildren; i++)
            {
                Children.Add(new Person(this, Spouse));
            }

            Spouse.Children = Children;

            return Children;
        }
    }
}
