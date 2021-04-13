using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CandidatesData.Models
{
    public class CandidateBranch
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Telephone { get; set; }
        public string Description { get; set; }
        public DateTime OpenDate { get; set; }

        public virtual IEnumerable<Patron> Patrons { get; set; }
        public virtual IEnumerable<CandidateAsset> CandidateAssets { get; set; }

        public string ImageUrl { get; set; }
    }
}