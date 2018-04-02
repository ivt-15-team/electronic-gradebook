using System;

namespace Ebook
{
    public class Employee : Person
    {
        //переменные
        private string cathedra;
        private string position;

        

        public Employee(string _fname, string _sname, string _mname, DateTime _bdate, string k_cathedra, string k_position) : base(_fname, _sname, _mname, _bdate)
        {
            cathedra = k_cathedra;
            position = k_position;
        }

        public string Cathedra {
            get {
                  return cathedra;
            }

            set {
                cathedra = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }
        //функции


    }
}
