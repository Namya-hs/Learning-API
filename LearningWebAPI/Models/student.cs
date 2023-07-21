using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningWebAPI.Models
{
    public class student
    {
        [Key]
        
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }
    }
}
