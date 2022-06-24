using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProgrammingFinal.Models
{
    public class Galerim
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(500)")]
        public string Photo { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Video { get; set; }
    }
   
}
