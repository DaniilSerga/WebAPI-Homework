using Microsoft.EntityFrameworkCore;

namespace WebAPI_homework.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; } = null!;

        public decimal Price { get; set; }

        public List<User> User { get; set; } = new();
    }
}
