using System;
using System.ComponentModel.DataAnnotations;

namespace CandidatesData.Models
{
    public class CheckoutHistory
    {
        public int Id { get; set; }

        [Required]
        public CandidateAsset CandidateAsset { get; set; }

        [Required]
        public  CandidateCard CandidateCard { get; set; }

        [Required]
        public DateTime CheckedOut { get; set; }

        public DateTime? CheckedIn { get; set; }
    }
}