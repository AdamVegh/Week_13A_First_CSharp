using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {

        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public enum Genders : int
        {
            Male, Female
        }
        public Genders gender;

        public Person()
        {

        }

        public Person(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return String.Format("name: {0}, birth date: {1}", this.name, this.birthDate);
        }

        //static void Main(string[] args)
        //{
        //    String name = "Adam Vegh";
        //    DateTime birthDate = new DateTime(1991, 01, 05, 9, 55, 00);
        //    Person p = new Person(name, birthDate);
        //    Console.WriteLine(p.ToString());
        //    p.Name = "Adi";
        //    Console.WriteLine(p.Name);
        //    Console.ReadLine();

        //}
    }
}
