using System;
using CandidatesData.Models;
using Microsoft.EntityFrameworkCore;

namespace CandidatesData
{
    public class CandidateContext : DbContext
    {
        public CandidateContext(DbContextOptions options) : base(options){ }

        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos{ get; set; }
        public DbSet<Checkout> Checkouts{ get; set; }
        public DbSet<CheckoutHistory> CheckoutHistories{ get; set; }
        public DbSet<CandidateBranch> CandidateBranches{ get; set; }
        public DbSet<BranchHours> BranchHours{ get; set; }
        public DbSet<CandidateCard> CandidateCards{ get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<CandidateAsset> CandidateAssets{ get; set; }
        public DbSet<Hold> Holds{ get; set; }
    }
}
