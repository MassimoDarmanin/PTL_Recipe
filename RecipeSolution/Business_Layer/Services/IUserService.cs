using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data_Access_Layer.Models;

namespace Business_Layer.Services
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}
