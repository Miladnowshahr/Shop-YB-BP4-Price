using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using ShopYB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ShopYB.Security
{
    public class SecurityManager
    {
        public async void SignIn(HttpContext httpContext,Account account,string schema)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(getUserClaims(account),schema);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await httpContext.SignInAsync(schema,claimsPrincipal);
        }

        public async void SignOut(HttpContext httpContext,string schema)
        {
            await httpContext.SignOutAsync(schema);
        }



        private IEnumerable<Claim> getUserClaims(Account account)
        {
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Name, account.Username));


            foreach (var roleAccount in account.RoleAccounts)
            {
                claims.Add(new Claim(ClaimTypes.Role, roleAccount.Role.Name));
            }

            return claims;
               
        }
    }
}
