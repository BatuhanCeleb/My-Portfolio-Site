using System.ComponentModel.DataAnnotations;

namespace WebProgrammingFinal.Models
{
    public class Hakkimda
    {
        public int Id { get; set; }

        [MaxLength(1000)]
        public string Text { get; set; }

        [MaxLength(500)]
        public string Links { get; set; }

    }
}
