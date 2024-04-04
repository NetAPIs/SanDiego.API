using Microsoft.EntityFrameworkCore;
using SanDiego.API.Data;
using SanDiego.API.Models;

namespace SanDiego.API.Services.RoomService
{
    public class RoomService : IRoomService
    {
        private readonly DataContext _context;

        public RoomService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Room>> GetAllRooms()
        {
            return await _context.Rooms.ToListAsync();
        }
    }
}
