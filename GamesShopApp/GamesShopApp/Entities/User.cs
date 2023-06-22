using Google.Protobuf.WellKnownTypes;
using System.Text.Json.Serialization;

namespace GamesShopApp.Entities;

public class User
{
    public int id { get; set; }
    public string? title { get; set; }
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public Timestamp? createdAt { get; set; }
    public Timestamp? modifiedAt { get; set; }
    public Role Role { get; set; }

    [JsonIgnore]
    public string? PasswordHash { get; set; }
}
