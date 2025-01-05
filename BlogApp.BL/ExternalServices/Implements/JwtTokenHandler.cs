using BlogApp.BL.ExternalServices.Interfaces;
using BlogApp.Core.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.ExternalServices.Implements
{
    public class JwtTokenHandler : IJwtTokenHandler
    {
        public string CreateToken(User user, int hours)
        {
            List<Claim> claims = [
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim("Fullname", user.Name + "" + user.Surname)
                ];
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(""));
            SigningCredentials cred = new
                (key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken secToken = new(
                issuer: "http://localhost:18894",
                audience: "http://localhost:18894",
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddHours(36),
                signingCredentials: cred
                );
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(secToken);
        }
    }
}
