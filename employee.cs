using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        //переменные
        private string cathedra;
        private string position;

        

        public Employee(string k_cathedra, string k_position) {
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
