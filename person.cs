using System;

namespace person
{
    public class Person
    {
        User PersonOwner
        {
            get => PersonOwner;
            set => PersonOwner = value;
        }
        string FirstName
        {
            get
            {
                return this.FirstName;
            }
            set
            {
                this.FirstName = value;
            }
        }
        string SecondName
        {
            get
            {
                return this.SecondName;
            }
            set
            {
                this.SecondName = value;
            }
        }
        string MiddleName
        {
            get
            {
                return this.MiddleName;
            }
            set
            {
                this.MiddleName = value;
            }
        }
        DateTime BirthDate
        {
            get
            {
                return this.BirthDate;
            }
            set
            {
                this.BirthDate = value;
            }
        }

        public User PersonOwner1 

        Person(string _fname, string _sname, string _mname, DateTime _bdate)
        {
            FirstName = _fname;
            SecondName = _sname;
            MiddleName = _mname;
            BirthDate = _bdate;
        }
    }
}
