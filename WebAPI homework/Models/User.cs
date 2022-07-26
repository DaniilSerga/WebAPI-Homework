using Microsoft.EntityFrameworkCore;

namespace WebAPI_homework.Models
{
    public class User
    {
        public int Id { get; set; }

        public string? Name { get; set; } = null!;

        public string? MobilePhone { get; set; } = null!;

        public List<Product> Products { get; set; } = new();
    }
}
