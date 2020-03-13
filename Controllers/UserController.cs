using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UserApi.Services;
using UserApi.Models;
using System;
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
        // GET api/v{version Number}/user
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            try{

            return _userservice.Get();
            } 
            catch(Exception e){
                return StatusCode(500, "Internal server error");
            }
        }

        // GET api/v{version Number}/user/5
        [HttpGet("{id}",Name ="GetUser")]
        public ActionResult<User> Get(string id)
        {
            try{

            var user = _userservice.Get(id);
            if (user==null)
            {
            return NotFound();
            }
            return user;
            } catch(Exception e){
                return StatusCode(500, "Internal server error");
            }
        }

        // POST api/v{version Number}/user
        [HttpPost]
        public ActionResult<User> Post([FromBody] User value)
        {
            var user=_userservice.Create(value);
            return StatusCode(200,value);
        }

        // PUT api/v{version Number}/user/id
        [HttpPut("{id}")]
        public ActionResult<User> Put(string id, [FromBody] User value)
        {
            _userservice.Update(id,value);
            return StatusCode(200);
        }

        // DELETE api/v{version Number}/user/id
        [HttpDelete("{id}")]
        public ActionResult<User> Delete(string id)
        {
            _userservice.Remove(id);
            return StatusCode(200);
        }
    }
}
