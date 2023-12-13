using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FoodApi.Controllers
{
    [ApiController]
    [Route("api/food")]
    public class FoodController : ControllerBase
    {   

        [HttpGet]
        public IActionResult GetFoodData()
        {
            var foodData =  new List<FoodItem> 
          {
            new FoodItem("White Bread", 67, 1, 2, 13, "Slice"),
                new FoodItem("Brown Bread", 74, 0.9, 2.9, 13.5, "Slice"),
                new FoodItem("Chicken", 165, 3.6, 31, 0, "100g"),
                new FoodItem("Apple", 95, 0.3, 0.5, 25, "one"),
                new FoodItem("Banana", 110, 0.3, 1.3, 28, "one"),
                new FoodItem("Whole Milk", 61, 3.2, 3.2, 4.8, "100ml"),
                new FoodItem("Skimmed Milk", 35, 0.1, 3.4, 5, "100ml"),
                new FoodItem("Cheddar Cheese", 402, 33.1, 25, 1.3, "100g"),
                new FoodItem("Salmon", 206, 13, 22, 0, "100g"),
                new FoodItem("Broccoli", 55, 0.6, 3.7, 11, "100g"),
                new FoodItem("Oatmeal", 68, 1.4, 2.4, 12, "Half cup"),
                new FoodItem("Eggs", 68, 4.8, 5.5, 0.6, "Medium"),
                new FoodItem("Spinach", 23, 0.4, 2.9, 3.6, "Cup"),
                new FoodItem("Peanut Butter", 94, 8, 4, 3, "Tablespoon"),
        };

            return Ok(foodData);
        }
    }

    record FoodItem(
        string Name,
        int Calories,
        double Fat,
        double Protein,
        double Carbs,
        string Quantity
    );
}
