using System.ComponentModel.DataAnnotations;

namespace CandidatesData.Models
{
    public class CandidateAsset
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public Status Status { get; set; }

        public string ImageUrl { get; set; }

        public virtual CandidateBranch Location { get; set; }
    }
}