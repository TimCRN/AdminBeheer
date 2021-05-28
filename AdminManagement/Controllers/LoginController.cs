using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdminManagement.Data;
using AdminManagement.Models;
using System.Net.Mail;
using AdminManagement.ViewModels;

namespace AdminManagement.Controllers
{
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