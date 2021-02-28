using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Entities.Register;
using Store.Service.Register.Interfaces;

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) =>
            _userService = userService;

        [HttpPost]
        public User New([FromBody] User user) =>
            _userService.NewUser(user);

        [HttpGet("{id}")]
        public User GetById([FromRoute] int id) =>
            _userService.GetUserById(id);
    }
}
