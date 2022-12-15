#pragma warning disable CS8618
namespace ChefsNDishes.Models;
public class MyViewModel
{    
    public Dish Dish {get;set;}    
    public List<Chef> AllChefs {get;set;} = new List<Chef>();
}
