public class Schedule
{
    public string GroupName { get; private set; }
    public int WeekDay { get; private set; }
    public string Subject { get; private set; }
    public string Room { get; private set; }
    public bool EvenWeek { get; private set; }
    public int OrderNumber { get; private set; }
    public string SubjectType { get; private set; }

    public Schedule(string groupName, int weekDay, string subject, string room, bool evenWeek, int orderNumber, string subjectType)
    {
        GroupName = groupName;
        WeekDay = weekDay;
        Subject = subject;
        Room = room;
        EvenWeek = evenWeek;
        OrderNumber = orderNumber;
        SubjectType = subjectType;
    }
}
