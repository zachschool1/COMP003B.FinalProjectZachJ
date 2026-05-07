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
        public virtual ICollection<Games> FavoriteGames { get; set; } = new List<Games>();
        public virtual ICollection<Movies> FavoriteMovies { get; set; } = new List<Movies>();
        public virtual ICollection<Shows> FavoriteShows { get; set; } = new List<Shows>();
        public virtual ICollection<Songs> FavoriteSongs { get; set; } = new List<Songs>();

    }
}
