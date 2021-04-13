using System;

namespace CandidatesData.Models
{
    public class Hold
    {
        public int Id { get; set; }
        public virtual CandidateAsset CandidateAsset { get; set; }
        public virtual CandidateCard CandidateCard { get; set; }
        public DateTime HoldPlaced { get; set; }
    }
}