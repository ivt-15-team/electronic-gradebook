using System;
using System.ComponentModel.DataAnnotations;

namespace Ebook
{
    public class EDU_plan
    {
        [Key]
        public int Id { get; set; }

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