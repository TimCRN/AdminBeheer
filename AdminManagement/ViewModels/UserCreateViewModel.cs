using AdminManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminManagement.ViewModels
{
    public class UserCreateViewModel
    {
        public int RoleId { get; set; }
        public Role[] AvailableRoles { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

    }
}
