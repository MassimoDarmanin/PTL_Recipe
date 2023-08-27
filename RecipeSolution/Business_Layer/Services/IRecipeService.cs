using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data_Access_Layer.Models;

namespace Business_Layer.Services
{
    public interface IRecipeService
    {
        IEnumerable<Recipe> GetAllRecipes();
        Recipe GetRecipeById(int id);
        void AddRecipe(Recipe recipe);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(int id);
    }
}
