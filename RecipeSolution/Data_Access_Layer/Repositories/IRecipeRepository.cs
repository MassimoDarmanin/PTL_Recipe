using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> GetAll();
        Recipe GetById(int id);
        void Add(Recipe recipe);
        void Update(Recipe recipe);
        void Delete(int id);
    }
}
