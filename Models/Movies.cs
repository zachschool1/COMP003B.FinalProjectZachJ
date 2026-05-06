using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.ZachJ.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        [Range(0,10)]
        public double Rating { get; set; }
        public string? Comments { get; set; }

        
        public int UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
