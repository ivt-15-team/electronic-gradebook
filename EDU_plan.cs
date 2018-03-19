using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EDU_plan
    {
        private string spec_name;
        public string Spec_name
        {
            get
            {
                return spec_name;
            }
            set
            {
                spec_name = value;
            }
        }
        private string begin_year;
        public string Begin_year
        {
            get
            {
                return begin_year;
            }
            set
            {
                begin_year = value;
            }
        }
        public EDU_plan(string spec_nam, string begin_yea)
        {


            spec_name = spec_nam;
            begin_year = begin_yea;
           
        }
    }
}
