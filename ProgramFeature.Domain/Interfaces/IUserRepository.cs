using System;
using System.Collections.Generic;
using System.Text;
using ProgramFeature.Domain.Models.Users;

using System.Threading.Tasks;
namespace ProgramFeature.Domain.Interfaces
{
    public interface IUserRepository
    {

         Task<UserInfoModel> AuthenticateAsync(string username, string password);
        IEnumerable<UserInfoModel> GetAll();



    }
}
