using System.ComponentModel.DataAnnotations;

namespace WebProgrammingFinal.Models
{
    public class Projelerim
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string ProjectName { get; set; }

        [MaxLength(500)]
        public string ProjectDescription { get; set; }

        [MaxLength(200)]
        public string ProjectYear { get; set; }
    }
}
