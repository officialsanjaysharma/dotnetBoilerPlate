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
    public class BookController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<>> Get()
        {

        }
    }
}