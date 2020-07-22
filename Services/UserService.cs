using UserMicroService.Models;
using UserMicroService.Repository;
using Microsoft.Extensions.Options;
using System.Linq;

namespace UserMicroService.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;
        public readonly ApplicationContext applicationContext;

        public UserService(IGenericRepository<User> genericRepository, ApplicationContext applicationContext)
        {
            _genericRepository = genericRepository;
            this.applicationContext = applicationContext;
        }

        public User GetById(int id)
        {
            var user = this.applicationContext.User.FirstOrDefault(x => x.Id == id);
            return user;
        }
    }
}
