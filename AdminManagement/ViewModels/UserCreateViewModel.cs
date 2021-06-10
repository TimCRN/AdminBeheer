// <copyright file="UserCreateViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdminManagement.ViewModels
{
    using AdminManagement.Models;

    public class UserCreateViewModel
    {
        public int RoleId { get; set; }

        public Role[] AvailableRoles { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }
    }
}
