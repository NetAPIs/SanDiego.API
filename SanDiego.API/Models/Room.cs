namespace SanDiego.API.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int RoomNumber { get; set; }
        public RoomStatus RoomStatus { get; set; } = RoomStatus.Available;
        public RoomType RoomType { get; set; } = RoomType.Single;
        public int Price { get; set; }
    }
}
