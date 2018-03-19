//waiting for parent classes to be implemented
//public class Student : Person
public class Student
{
    public string GroupName { get; set; }
    //THAT'S A BAD IDEA
    public int Id { get; set; }
    public string Status { get; set; }

    public Student(string groupName, int id, string status)
    {
        GroupName = groupName;
        Id = id;
        Status = status;
    }
}
