using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Category
  {
    public Category()
    {
        this.Recipes = new HashSet<CategoryRecipe>();
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<CategoryRecipe> Recipes { get; set; }
  }
}