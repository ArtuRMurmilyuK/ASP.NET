using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace CandidatesData.Models
{
    public class Checkout
    {
        public int Id { get; set; }
        
        [Required]
        public CandidateAsset CandidateAsset { get; set; }
        public CandidateCard CandidateCard { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
    }
}