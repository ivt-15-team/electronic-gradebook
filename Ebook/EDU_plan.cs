using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ebook
{
    public class EDU_plan
    {
        [Key]
        public int UId { get; set; }
        private int ContentsCount = 0;
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
        private int begin_year;
        public int Begin_year
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
        //public List<Edu_Plan_Content> content;

        public EDU_plan()
        {

        }

        public EDU_plan(string spec_nam, string begin_yea)
        {
            //UId = Program.EDU_plans.Count + 1;
            spec_name = spec_nam;
            begin_year = Convert.ToInt32(begin_yea);
        }

		public void AddContent(string _subject_id, string _total_hours, string _ctr_type, string _employee)
		{
			string S;

            ContentsCount++;

            Edu_Plan_Content _content = new Edu_Plan_Content();

            // Console.WriteLine("������� �� ��������");
            _content.subject_id = _subject_id;

			// Console.WriteLine("������� ���������� ����� ��������");
			//S = Console.ReadLine();
			_content.total_hours = Convert.ToInt32(_total_hours);

            _content.ControlType = _ctr_type;

            _content.Employee = _employee;

            _content.EduPlanUID = UId;

            // �������� �� ������ ���������� � ��
            //Program.EDU_plan_Contents.Add(_content);
        }

		public void AddContent(Edu_Plan_Content _content)
		{
			_content.EduPlanUID = UId;
            //Program.EDU_plan_Contents.Add(_content);
		}
    }
}
