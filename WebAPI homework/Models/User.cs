using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_homework.Models
{

    [Table("Users")]
    public class User
    {
        public int Id { get; set; }

        public string? Name { get; set; } = null!;

        public string? MobilePhone { get; set; } = null!;

        public List<Product> Products { get; set; } = new();
    }
}
