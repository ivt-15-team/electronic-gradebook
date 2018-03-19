public class Mark
{
    public string Student { get; private set; }
    public string Lesson { get; private set; }
    public int Point { get; private set; }
    public DateTime LessonDate { get; private set; }

    public Mark(string student, string lesson, int point, DateTime lessonDate)
    {
        Student = student;
        Lesson = lesson;
        Point = point;
        //edu_actions
        LessonDate = lessonDate;
    }
}
