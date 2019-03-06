using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_GUI
{
    public enum LEVEL { FRESHMAN, SOPHOMORE, JUNIOR, SENIOR, GRADUATE, NON_DEGREE };

    public class Student : Person
    {
        private double _gpa;
        private LEVEL _level;

        public Student(string id, string firstName, string midInit, string lastName, int age) : base(id, firstName, midInit, lastName, age)
        {
            GPA = 0;
            Level = LEVEL.FRESHMAN;
        }

        public double GPA { get { return _gpa; } set { _gpa = value; } }
        public LEVEL Level { get { return _level; } set { _level = value; } }

        public override string DisplayInformation()
        {
            return String.Format("Student ID: {0}\nName: {1} {2}{3}\nLevel: {4}\nAge: {5}\nGPA: {6}",
                this.ID,
                this.FirstName,
                (this.MidInit == "") ? "" : String.Format("{0}. ", this.MidInit),
                this.LastName,
                this.Level.ToString(),
                this.Age.ToString(),
                this.GPA.ToString());
        }

        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4},{5},{6}",
                this.ID,
                this.FirstName,
                this.MidInit,
                this.LastName,
                this.Level.ToString(),
                this.Age.ToString(),
                this.GPA.ToString());
        }
    }
}
