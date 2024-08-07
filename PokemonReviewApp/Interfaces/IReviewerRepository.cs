﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);
        bool ReviewerExists(int reviewId);
        bool UpdateReviewer(Reviewer reviewer);
        bool CreateReviewer(Reviewer reviewer);
        bool DeleteReviewer(Reviewer reviewer);
        bool Save();
    }
}
