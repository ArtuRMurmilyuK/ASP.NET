using System.ComponentModel.DataAnnotations;

namespace CandidatesData.Models
{
    public class User : CandidateAsset
    {
        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string DeweyIndex { get; set; }
    }
}