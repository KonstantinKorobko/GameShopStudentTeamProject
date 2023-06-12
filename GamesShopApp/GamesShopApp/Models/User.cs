using Google.Protobuf.WellKnownTypes;

namespace GamesShopApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? userName { get; set; }
        public string? passwordHash { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public Timestamp? createdAt { get; set; }
        public Timestamp? modifiedAt { get; set; }
    }
}
