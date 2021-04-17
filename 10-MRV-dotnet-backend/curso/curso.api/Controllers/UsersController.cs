using curso.api.Models.Users;
using Microsoft.AspNetCore.Mvc;
//using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curso.api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace curso.api.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //[SwaggerResponse(statusCode: 200, Description = "success auth", Type = typeof(LoginViewModelInput))]
        //[SwaggerResponse(statusCode: 400, Description = "missing elements", Type = typeof(ValidationViewModelOutput))]
        //[SwaggerResponse(statusCode: 500, Description = "internal error", Type = typeof(ErrorViewModel))]
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] RegisterViewModelInput registerViewModelInput)
        {
            return Ok(registerViewModelInput);
        }



        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET api/<ValuesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}


        //// PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ValuesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
