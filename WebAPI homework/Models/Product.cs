using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_homework.Models
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; } = null!;

        public decimal Price { get; set; }

        public List<User> User { get; set; } = new();
    }
}
