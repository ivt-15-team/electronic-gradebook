using System;
using System.Collections.Generic;
using System.Text;

namespace Edu_Plan_Content
{
    public class Edu_Plan_Content
    {
        ///private EduPlan eduPlan;
        //private Subject subject;
        //private Employee employee;
        //private ControlType controlType;
        /////////////
        private string _subject_id;
        private int _total_hours;
        public string subject_id
        {
            get
            {
                return this._subject_id;
            }
            set
            {
                this._subject_id = value;
            }
        }
        public int total_hours
        {
            get
            {
                return this._total_hours;
            }
            set
            {
                this._total_hours = value;
            }
        }
    }
}
