namespace SanDiego.API.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int RoomNumber { get; set; }
        public RoomStatus Stauts { get; set; } = RoomStatus.Available;
        public RoomType Type { get; set; } = RoomType.Single;
        public int Price { get; set; }
    }
}
