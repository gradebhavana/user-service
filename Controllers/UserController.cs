using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UserMicroService.Models;
using UserMicroService.Services;

namespace UserMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       private readonly IUserService _userServce;

        public UserController(IUserService UserService)
        {
            _userServce = UserService;
        }

        [HttpGet("{id:int}")]
        public User GetById(int id)
        {
            return _userServce.GetById(id);
        }
    }
}