using System.ComponentModel.DataAnnotations;

public class Status
{
    [Key]
    public int Id { get; set; }

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