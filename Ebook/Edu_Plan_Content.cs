using System;
using System.ComponentModel.DataAnnotations;

namespace Ebook
{
    public class Edu_Plan_Content
    {
        [Key]
        public int UId { get; set; }
		//private EDU_plan _eduPlan;
        private Subject subject;
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
		//public EDU_plan eduPlan
		//{
		//	get
		//	{
		//		return this._eduPlan;
		//	}
		//	set
		//	{
		//		this._eduPlan = value;
		//	}
		//}
        public string employee;
        public string Employee
        {
            get
            {
                return this.employee;
            }
            set
            {
                this.employee = value;
            }
        }
        public string controlType;
        public string ControlType
        {
            get
            {
                return this.controlType;
            }
            set
            {
                this.controlType = value;
            }
        }
        public int EduPlanUID
        {
            get
            {
                return this.EduPlanUID;
            }
            set
            {
                this.EduPlanUID = value;
            }
        }
    }
}
