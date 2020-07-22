
using UserMicroService.Models;
using System.Collections.Generic;

namespace UserMicroService.Services
{
    public interface IUserService
    {
        public User GetById(int id);
    }
}
