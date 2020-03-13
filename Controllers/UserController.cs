using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UserApi.Services;
using UserApi.Models;
namespace dotnetBoilerplate.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userservice;
        public UserController(UserService userService)
        {
            _userservice = userService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return _userservice.Get();
        }

        // GET api/values/5
        [HttpGet("{id:length(24}",Name ="GetUser")]
        public ActionResult<User> Get(int id)
        {
            var user = _userservice.Get(id);
            if (user==null)
            {
            return NotFound();
            }
            return user;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
