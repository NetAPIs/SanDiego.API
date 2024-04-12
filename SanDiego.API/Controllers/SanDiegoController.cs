using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SanDiego.API.Data;
using SanDiego.API.Models;
using SanDiego.API.Services.ReviewService;
using SanDiego.API.Services.RoomService;

namespace SanDiego.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanDiegoController : ControllerBase
    {
        private readonly IRoomService _service;
        private readonly IReviewService _review;

        public SanDiegoController(IRoomService service, IReviewService review)
        {
            _service = service;
            _review = review;
        }

        [HttpGet]
        public async Task<List<Room>> GetRooms()
        {
            return await _service.GetAllRooms();
        }

        [HttpGet("{roomId}")]
        public async Task<Room> GetRoom(int roomId)
        {
            return await _service.GetRoom(roomId);
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
