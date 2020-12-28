using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.core.Common;
using Microsoft.AspNetCore.Authorization;
using WebApi.core.Extension;
using System.IdentityModel.Tokens.Jwt;

namespace WebApi.core.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// 测试
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public string Login(string UserCode)
        {
            var token = new TokenModel()
            {
                ID = 1,
                Name = "测试",
                Phone = "123456",
                Sub = "Master"
            };
            return Token.GetJWT(token);
        }
        [HttpGet]
         
        public string GetName()
        {
            return User.GetToken("Name");
        }
        /// <summary>
        /// 获取Token信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JwtSecurityToken GetJwtToken()
        {
            var token = HttpContext.Request.Headers["Authorization"].ToString();
            return new JwtSecurityTokenHandler().ReadJwtToken(token.Replace("Bearer ",""));
        }
    }
}
