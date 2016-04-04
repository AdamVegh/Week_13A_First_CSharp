using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room
    {
        private int number;

        public Room(int number)
        {
            this.number = number;
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

    }

    class Employee: Person, ICloneable
    {
        private int salary;
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string profession;
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        private Room room;
        public Room Room
        {
            get { return room; }
            set { room = value; }
        }

        public Employee()
        {
            Room = null;
        }

        public Employee(string name, DateTime birthDate, int salary, string profession):  base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
            Room = null;
        }

        public override string ToString()
        {
            return base.ToString() +
                String.Format(", salary: {0}, profession: {1}, room: {2}", salary, profession, Room.Number);
        }

        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }
    }
}
