﻿//waiting for parent classes to be implemented
using System;
using System.ComponentModel.DataAnnotations;

namespace Ebook
{
    public class Student : Person
    {
        public string GroupName { get; set; }
        //THAT'S A BAD IDEA
        public string Status { get; set; }
        public string zachentka { get; set; }

        public Student()
        {

        }

        public Student(string _fname, string _sname, string _mname, DateTime _bdate, string groupName, string status) : base(_fname, _sname, _mname, _bdate)
        {  
            GroupName = groupName;
            Status = status;
        }
    }
}

