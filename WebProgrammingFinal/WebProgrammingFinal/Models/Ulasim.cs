using System.ComponentModel.DataAnnotations;

namespace WebProgrammingFinal.Models
{

    public class Ulasim
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Surname { get; set; }

        [MaxLength(100)]
        public string EMail { get; set; }

        [MaxLength(25)]
        public string PhoneNumber { get; set; }
        
        [MaxLength(500)]
        public string Message { get; set; }
    }
}
