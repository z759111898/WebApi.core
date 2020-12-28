using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class HealthyController : ControllerBase
    {
        /// <summary>
        /// 心跳检测
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetHeart()
        {
            return DateTime.Now.ToString();
        }
    }
}
