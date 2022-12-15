using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace ChefsNDishes.Models;
public class Chef
{
	[Key]
	public int ChefId {get;set;}
	[Required]
	public string FirstName {get;set;}
	[Required]
	public string LastName {get;set;}
	[Required]
	[PastDate]
	public DateTime DOB {get;set;}
	public List<Dish> Dishes {get;set;} = new List<Dish>();
	public DateTime CreatedAt { get; set; } = DateTime.Now;
	public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
public class PastDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if(value == null)
        {
            return new ValidationResult("DOB is required!");
        }

		DateTime dob = Convert.ToDateTime(value);
		if(DateTime.Compare(dob, DateTime.Now) >= 0)
        {
            return new ValidationResult("DOB must be in the past!");
        } else {
            return ValidationResult.Success;
        }
    }
}

