using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_homework.Models
{

    [Table("Users")]
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string? MobilePhone { get; set; }

        public List<Product> Products { get; set; } = new();
    }
}
