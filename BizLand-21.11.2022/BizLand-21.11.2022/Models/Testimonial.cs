using System.ComponentModel.DataAnnotations;

namespace BizLand_21._11._2022.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        [MaxLength(30)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(25)]
        public string Position { get; set; }
        [Required]
        [MaxLength(300)]
        public string Desc { get; set; }
    }
}
