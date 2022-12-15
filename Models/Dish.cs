using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace ChefsNDishes.Models;
public class Dish
{
		[Key]
	public int DishId {get;set;}
	[Required]
	public string Name {get;set;}
	[Required]
	[Range(0,25000)]
	public int Calories {get;set;}
	[Required]
	[Range(0,5)]
	public int Tastiness {get;set;}
	public int ChefId {get;set;}
	public Chef? Creator {get;set;}
	public DateTime CreatedAt { get; set; } = DateTime.Now;
	public DateTime UpdatedAt { get; set; } = DateTime.Now;
}