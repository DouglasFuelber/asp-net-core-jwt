using System.Text.Json.Serialization;

namespace Shop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
