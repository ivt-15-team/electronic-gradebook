public class Status
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
   

    public Status(string Name)
    {
        name = Name;

    }


}