using System.ComponentModel.DataAnnotations;

namespace BizLand_21._11._2022.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(75)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(25)]
        public string Title { get; set; }
        [Required]
        [MaxLength(300)]
        public string Desc { get; set; }
    }
}
