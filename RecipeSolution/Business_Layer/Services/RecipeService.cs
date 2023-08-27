using Data_Access_Layer.Models;
using Data_Access_Layer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;        

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _recipeRepository.GetAll();
        }

        public Recipe GetRecipeById(int id)
        {
            return _recipeRepository.GetById(id);
        }

        public void AddRecipe(Recipe recipe)
        {
            _recipeRepository.Add(recipe);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            _recipeRepository.Update(recipe);
        }

        public void DeleteRecipe(int id)
        {
            _recipeRepository.Delete(id);
        }
    }
}
