using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RehearsalPortal.Core;
using RehearsalPortal.Domain;
using System.Data.Entity;
using System.Security.Claims;

namespace RehearsalPortal.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private RPContext db = new RPContext();

        [HttpPost("login")]
        public async Task<UserViewModel> Login([FromBody]LoginViewModel model)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => 
                (u.Email == model.LoginObject || 
                u.Login == model.LoginObject) && 
                u.Password == model.Password
            );

            if (user != null)
            {
                await Authenticate(model.LoginObject); // аутентификация

                return new UserViewModel
                {
                    Id = user.Id,
                    Login = user.Login,
                    Email = user.Email
                };
            }

            return null;
        }

        [HttpPost("register")]
        public async Task<UserViewModel> Register([FromBody]RegisterViewModel model)
        {
            var user = await db.Users.FirstOrDefaultAsync(u => 
                (u.Email == model.Email) || (u.Login == model.Login)
            );
            if (user == null)
            {
                // добавляем пользователя в бд
                db.Users.Add(new User {
                    Email = model.Email,
                    Login = model.Login,
                    Password = model.Password,
                    RegistrationDate = DateTime.Now,
                    LastLoginDate = DateTime.Now,
                });
                await db.SaveChangesAsync();

                await Authenticate(model.Email); // аутентификация

                return new UserViewModel
                {
                    Id = user.Id,
                    Login = user.Login,
                    Email = user.Email
                };
            }
            else
            {
                return null;
            }
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim> {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };

            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            // установка аутентификационных куки
            await HttpContext.Authentication.SignInAsync("Cookies", new ClaimsPrincipal(id));
        }

        [HttpPost("logout")]
        public async void Logout()
        {
            await HttpContext.Authentication.SignOutAsync("Cookies");
        }
    }
}
