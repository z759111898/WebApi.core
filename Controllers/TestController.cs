using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.core.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class TestController : ControllerBase
    {
        /// <summary>
        /// 测试接口
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpPost]
        public Return<string> Test(string name)
        {
            return new Return<string>() { state = 1, body = "Hello Word, " + name, msg = "查询成功" };
        }
    }
}
