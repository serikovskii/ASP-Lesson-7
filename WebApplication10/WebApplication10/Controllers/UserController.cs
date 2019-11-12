using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication10.DataAccess;
using WebApplication10.Models;
using WebApplication10.ViewModels;

namespace WebApplication10.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public async Task<ActionResult> Index()
        {
            List<User> users = new List<User>();
            using(var context = new JobsContext())
            {
                users = await context.Users.ToListAsync();
            }
            List<UserViewModel> viewModel = new List<UserViewModel>();
            foreach(var user in users)
            {
                viewModel.Add(
                    new UserViewModel
                    {
                        UserName = user.UserName,
                        CreationDate = user.CreationDate
                    });
            }

            return View(viewModel);
        }
    }
}