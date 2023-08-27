using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly RecipesDbContext _context;

        public RecipeRepository(RecipesDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Recipe> GetAll()
        {
            return _context.Recipes.ToList();
        }

        public Recipe GetById(int id)
        {
            return _context.Recipes.FirstOrDefault(r => r.Id == id);
        }

        public void Add(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
        }

        public void Update(Recipe recipe)
        {
            _context.Recipes.Update(recipe);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var recipe = GetById(id);
            _context.Recipes.Remove(recipe);
            _context.SaveChanges();
        }
    }
}
