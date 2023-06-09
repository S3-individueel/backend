﻿using System.ComponentModel.DataAnnotations.Schema;

namespace VolksmondAPI.Models
{
    public class Solution
    {
        public int Id { get; set; }
        public int ProblemId { get; set; }
        public int CitizenId { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public DateTime? PostDate { get; set; }

        public virtual ICollection<SolutionVote>? Votes { get; set; }
        public virtual ICollection<Reply>? Replies { get; set; }
        public virtual Problem? Problem { get; set; }
        public virtual Citizen? Citizen { get; set; }

        [NotMapped]
        public int? Score { get; set; }
    }
}
