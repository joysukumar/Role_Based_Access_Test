using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Register_Login_Test.Models;

namespace Register_Login_Test.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                User? user = null;
                if (model.Username!.Contains("@"))
                {
                    user = await _userManager.FindByEmailAsync(model.Username);
                }
                else
                {
                    user = await _userManager.FindByNameAsync(model.Username);
                }

                if (user == null)
                {
                    ModelState.AddModelError("", "User not found.");
                    return View(model);
                }
                var result = await _signInManager.PasswordSignInAsync(user.UserName!, model.Password!, model.Rememberme, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid Login Credentials");
            }
            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {

                User user = new()
                {
                    UserName=model.Email,
                    Name = model.Name,
                    Email = model.Email,
                    Address=model.Address

                };
                var result = await _userManager.CreateAsync(user, model.Password!);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
    }
}
