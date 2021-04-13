using System;

namespace CandidatesData.Models
{
    public class Patron
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age{ get; set; }
        public string City{ get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual CandidateCard CandidateCard{ get; set; }
        public virtual CandidateBranch HomeCandidateBranch { get; set; }
    }
}