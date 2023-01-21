using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduSam.Models
{
    public class Blog
    {
       
        public int Id { get; set; }
        [Required]
        public string ? title { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string? description { get; set; } 
        public string? image { get; set; }
        public string ? author { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? createdAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? updatedAt { get; set; }
       

    }
}
