using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SanDiego.API.Models;
using SanDiego.API.Services.ReviewService;

namespace SanDiego.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _review;

        public ReviewsController(IReviewService review)
        {
            _review = review;
        }

        [HttpPost]
        public async Task<Review> AddReview(Review review)
        {
            return await _review.AddReview(review);
        }

        [HttpGet]
        public async Task<List<Review>> GetReviews()
        {
            return await _review.GetReviews();
        }

    }
}
