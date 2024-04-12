using SanDiego.API.Models;

namespace SanDiego.API.Services.ReviewService
{
    public interface IReviewService
    {
        Task<List<Review>> GetReviews();   
        Task<Review> AddReview(Review review);
    }
}
