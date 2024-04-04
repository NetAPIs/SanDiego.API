using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SanDiego.API.Data;
using SanDiego.API.Models;
using SanDiego.API.Services.RoomService;

namespace SanDiego.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanDiegoController : ControllerBase
    {
        private readonly IRoomService _service;

        public SanDiegoController(IRoomService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Room>> GetRooms()
        {
            return await _service.GetAllRooms();
        }
    }
}
