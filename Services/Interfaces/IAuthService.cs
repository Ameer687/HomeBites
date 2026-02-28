using HomeBites.Models;

namespace HomeBites.Services.Interfaces
{
    

    public interface IAuthService
    {
        Task<User> Register(User user);
        Task<User> Login(string email, string password);
    }

}
