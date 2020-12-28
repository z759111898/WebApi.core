using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApi.core.Extension
{
    public static class UserIdentityExtension
    {
        public static string GetToken(this ClaimsPrincipal claims, string Name)
        {
            return claims.Claims.Where(oo => oo.Type == "Name").FirstOrDefault().Value;
        }
    }
}
