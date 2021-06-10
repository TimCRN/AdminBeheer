// <copyright file="LoginController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdminManagement.Controllers
{
    using AdminManagement.Data;
    using Microsoft.AspNetCore.Mvc;

    public class LoginController : Controller
    {
        private readonly AdminManagementContext _context;

        public LoginController(AdminManagementContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}