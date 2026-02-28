    using HomeBites.Data;
    using HomeBites.Models;
    using HomeBites.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;

namespace HomeBites.Services.Implementations
{
    

    public class AuthService : IAuthService
    {
        private readonly HomeBitesContext _context;

        public AuthService(HomeBitesContext context)
        {
            _context = context;
        }

        public async Task<User> Register(User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> Login(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null) return null;

            bool valid = BCrypt.Net.BCrypt.Verify(password, user.Password);
            if (!valid) return null;

            return user;
        }
    }

}
