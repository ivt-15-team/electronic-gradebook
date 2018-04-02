using System.ComponentModel.DataAnnotations;

namespace Ebook
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public Subject(string name)
        {
            Name = name;
        }
    }
}
