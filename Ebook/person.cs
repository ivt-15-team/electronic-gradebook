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
        public string FirstName
        {
            get; set;
        }
        public string SecondName
        {
            get; set;
        }
        public string MiddleName
        {
            get; set;
        }
        public DateTime BirthDate
        {
            get; set;
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
