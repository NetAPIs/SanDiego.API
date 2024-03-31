using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SanDiego.API.Data;
using SanDiego.API.Models;

namespace SanDiego.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanDiegoController : ControllerBase
    {
        private readonly DataContext _context;

        public SanDiegoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Room>> GetRooms()
        {
            return await _context.Rooms.ToListAsync();
        }
    }
}
