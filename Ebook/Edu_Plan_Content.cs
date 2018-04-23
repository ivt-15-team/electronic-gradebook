using System;
using System.ComponentModel.DataAnnotations;

namespace Ebook
{
    public class Edu_Plan_Content
    {
        [Key]
        public int Id { get; set; }
		private EDU_plan _eduPlan;
        private Subject subject;
        private Employee employee;
        private ControlType controlType;
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
		public EDU_plan eduPlan
		{
			get
			{
				return this._eduPlan;
			}
			set
			{
				this._eduPlan = value;
			}
		}
	}
}
