using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.ZachJ.Models
{
    public class Shows
    {
        public int ShowId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string ShowGenre { get; set; }

        [Range(1,10)]
        public double Ranking {  get; set; }

        public string? Comments { get; set; }

    }
}
