using System;
using System.Collections.Generic;
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
		public List<Edu_Plan_Content> content;

		public EDU_plan(string spec_nam, string begin_yea)
        {
            spec_name = spec_nam;
            begin_year = begin_yea;
        }

		public void AddContent(string _subject_id, string _total_hours)
		{
			string S;

			Edu_Plan_Content _content = new Edu_Plan_Content();

			// Console.WriteLine("Введите ИД предмета");
			_content.subject_id = _subject_id;

			// Console.WriteLine("Введите количество часов предмета");
			S = Console.ReadLine();
			_content.total_hours = Convert.ToInt32(_total_hours);


			_content.eduPlan = this;

			content.Add(_content);
		}

		public void AddContent(Edu_Plan_Content _content)
		{
			_content.eduPlan = this;
			content.Add(_content);
		}
    }
}
