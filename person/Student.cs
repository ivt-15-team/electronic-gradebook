//waiting for parent classes to be implemented
using System;

namespace Ebook
{
    public class Student : Person
    {
        public string GroupName { get; set; }
        //THAT'S A BAD IDEA
        public int Id { get; set; }
        public string Status { get; set; }

        public Student(string _fname, string _sname, string _mname, DateTime _bdate, string groupName, int id, string status) : base(_fname, _sname, _mname, _bdate)
        {
            
            GroupName = groupName;
            Id = id;
            Status = status;
        }
    }
}

