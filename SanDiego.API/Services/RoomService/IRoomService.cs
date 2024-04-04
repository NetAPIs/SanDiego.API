using SanDiego.API.Models;

namespace SanDiego.API.Services.RoomService
{
    public interface IRoomService
    {
        Task<List<Room>> GetAllRooms();
    }
}
