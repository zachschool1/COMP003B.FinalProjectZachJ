using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.ZachJ.Models
{
    public class Music
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        [Range(0,10)]
        public double Rating { get; set; }

        public string? Comments { get; set; }

    }
}
