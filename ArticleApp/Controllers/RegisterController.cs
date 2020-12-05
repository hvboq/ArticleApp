using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleApp.Models.Users;
using Microsoft.JSInterop;

namespace ArticleApp.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IUserRepository _userRepository;
        public RegisterController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string email, string password)
        {
            List<User> users = await _userRepository.GetAllUserAsync();
            if(users.Find(user => user.Email.Equals(email)) != null)
            {
                return LocalRedirect(Url.Content("~/"));
            }

            User user = new User()
            {
                Email = email,
                Password = password
            };

            await _userRepository.AddUserAsync(user);

            return LocalRedirect(Url.Content("~/"));

        }
    }
}
