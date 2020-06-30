using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramFeature.Domain.Models
{
  public   class ProgrammeMasterUsersModel
    {

        public long Id { get; set; }
        public string ProgrammeMasterOwner { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
