using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnswerCloud.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnswerCloud.Controllers
{
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        [HttpGet]
        public IEnumerable<string> PublishIssue(Issue issue)
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 打星
        /// </summary>
        /// <param name="issueId"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string StarIssue(string issueId)
        {
            return "value";
        }

        /// <summary>
        /// 回复问题
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void AnswerIssue([FromBody]string value)
        {
        }

        /// <summary>
        /// 感谢问题
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void GrateIssue(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// 收藏问题
        /// </summary>
        /// <param name="issueId"></param>
        [HttpDelete("{id}")]
        public void StoreIssue(string issueId)
        {
        }
    }
}
