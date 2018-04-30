using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook
{
    public class mark
    {
        [Key]
        public int Id { get; set; }

        private string Student
        {
            get
            {
                return Student;
            }
            set
            {
                Student = value;
            }
        }
        public string Lesson
        {
            get
            {
                return Lesson;
            }
            set
            {
                Lesson = value;
            }
        }
        public int Points;
        public string Edu_actions
        {
            get
            {
                return Edu_actions;
            }
            set
            {
                Edu_actions = value;
            }
        }
        public DateTime Lesson_date {
            get
            {
                return Lesson_date;
            }
            set
            {
                Lesson_date = value;
            }
        }



        public mark (int points, DateTime lesson_date,  Student student, Schedule lesson, EDU_actions actions)
        {
            Points = points;
            Lesson_date = lesson_date;
            Student = student;
            Lesson = lesson;
            Edu_actions = actions;

        }
    }
}
