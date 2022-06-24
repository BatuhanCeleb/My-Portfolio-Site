using System.ComponentModel.DataAnnotations;



namespace WebProgrammingFinal.Models
{

    public class Anasayfa
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string TextHeader { get; set; }

        [MaxLength(1000)]
        public string Text { get; set; }

        [MaxLength(50)]
        public string Image { get; set; }
    }
}
