using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramFeature.Domain.Models.Users
{
  public  class UserInfoModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Token { get; set; }

    }

}
