using Microsoft.EntityFrameworkCore;
using SanDiego.API.Models;

namespace SanDiego.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, ImageUrl = "https://media.cnn.com/api/v1/images/stellar/prod/140127103345-peninsula-shanghai-deluxe-mock-up.jpg?q=w_2226,h_1449,x_0,y_0,c_fill", RoomNumber = 101, RoomStatus = RoomStatus.Available, RoomType = RoomType.Single, Price = 50 },
                new Room { Id = 2, ImageUrl = "https://www.seleqtionshotels.com/content/dam/seleqtions/Connaugth/TCPD_PremiumBedroom4_1235.jpg/jcr:content/renditions/cq5dam.web.1280.1280.jpeg", RoomNumber = 102, RoomStatus = RoomStatus.Available, RoomType = RoomType.Double, Price = 80 },
                new Room { Id = 3, ImageUrl = "https://static.dezeen.com/uploads/2021/07/eaton-dc-interiors-hotel-washington-dc-maryland-usa-adrian-gaut_dezeen_2364_col_2.jpg", RoomNumber = 103, RoomStatus = RoomStatus.Available, RoomType = RoomType.Group, Price = 120 },
                new Room { Id = 4, ImageUrl = "https://www.redrockresort.com/wp-content/uploads/2020/12/RR-Standard-2-Queen.jpg", RoomNumber = 201, RoomStatus = RoomStatus.Occupied, RoomType = RoomType.Single, Price = 50 },
                new Room { Id = 5, ImageUrl = "https://www.theshelbourne.com/resourcefiles/roomssmallimages/heritage-parkview-guestroom.jpg?version=2292024113454", RoomNumber = 202, RoomStatus = RoomStatus.InCleaning, RoomType = RoomType.Double, Price = 80 }
            );
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet <Review> Reviews { get; set; }
    }
}
