using System.ComponentModel.DataAnnotations;

namespace LearningWebAPI.Models
{
    public class Actor
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string language { get; set; }
    }
}
