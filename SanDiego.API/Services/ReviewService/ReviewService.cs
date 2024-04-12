using Microsoft.EntityFrameworkCore;
using SanDiego.API.Data;
using SanDiego.API.Models;

namespace SanDiego.API.Services.ReviewService
{
    public class ReviewService : IReviewService
    {
        private readonly DataContext _context;

        public ReviewService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Review>> GetReviews()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async Task<Review> AddReview(Review review)
        {
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
            return review;
        }
    }
}
