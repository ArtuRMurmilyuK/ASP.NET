using System.ComponentModel.DataAnnotations;

namespace CandidatesData.Models
{
    public class Video : CandidateAsset
    {
        [Required]
        public string Director { get; set; }
    }
}