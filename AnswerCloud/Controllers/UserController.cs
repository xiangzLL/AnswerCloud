using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AnswerCloud.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public UserController(IOptions<MyOption> option)
        {
            
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> UserLogin(string userName,string password)
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string RegisterUser(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void ForgetPassword([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void HeadHunterCheck(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void ChangePassword(int id)
        {
        }

        public void ChangeUserRole(string id)
        {
            
        }

    }
}
