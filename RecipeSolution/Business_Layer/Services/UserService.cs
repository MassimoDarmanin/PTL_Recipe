using Data_Access_Layer.Models;
using Data_Access_Layer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAllRecipes()
        {
            return _userRepository.GetAll();
        }

        public User GetRecipeById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void AddRecipe(User user)
        {
            _userRepository.Add(user);
        }

        public void UpdateRecipe(User user)
        {
            _userRepository.Update(user);
        }

        public void DeleteRecipe(int id)
        {
            _userRepository.Delete(id);
        }
    }
}

