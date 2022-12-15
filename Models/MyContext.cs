#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
namespace ChefsNDishes.Models; // fill in PrpjectName
public class MyContext : DbContext
{
    public MyContext(DbContextOptions options) : base(options) { }
    // create the following line for every model
    public DbSet<Chef> Chefs { get; set; } 
    public DbSet<Dish> Dishes { get; set; } 
}