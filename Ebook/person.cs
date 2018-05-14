using System;
using System.ComponentModel.DataAnnotations;

namespace Ebook
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public Person()
        {

        }

        User PersonOwner;
        private DateTime birthDate;
        private string firstName, secondName, middleName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                secondName = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

        public Person(string _fname, string _sname, string _mname, DateTime _bdate)
        {
            FirstName = _fname;
            SecondName = _sname;
            MiddleName = _mname;
            BirthDate = _bdate;
        }
    }
}
