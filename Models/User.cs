using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.ZachJ.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public int? Age { get; set; } = 0;

        public string? AboutMe { get; set; }
        public virtual ICollection<Games> Games { get; set; }

    }
}
