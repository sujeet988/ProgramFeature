using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ProgramFeature.Domain.Interfaces;
using ProgramFeature.Domain.Models.Users;
using ProgramFeature.Infrastructure.Data.DbModels;

namespace ProgramFeature.Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository
    {


        public programfeatureContext _Context;
        public IConfiguration _configuration;

        public UserRepository(programfeatureContext context, IConfiguration config)
        {
            _Context = context;
            _configuration = config;
        }


        public async Task<UserInfoModel> AuthenticateAsync(string username, string password)
        {


            var user = await GetUser(username, password);
            // return null if user not found
            if (user == null)
                return null;
            UserInfoModel _user = new UserInfoModel();
            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("Id", user.UserId.ToString()),
                    new Claim("FirstName", user.FirstName),
                    new Claim("LastName", user.LastName),
                    new Claim("UserName", user.UserName),
                    new Claim("Email", user.Email)
                   };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);
            _user.Token = tokenHandler.WriteToken(token);

            return _user;
        }

        public IEnumerable<UserInfoModel> GetAll()
        {
            throw new NotImplementedException();
        }


        private async Task<UserInfo> GetUser(string username, string password)
        {
            return await _Context.UserInfo.FirstOrDefaultAsync(u => u.UserName == username && u.Password == password);
        }

    }
}
