using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleApp.Models.Users
{
    class UserRepository : IUserRepository
    {
        private readonly ArticleAppDBContext _context;

        public UserRepository(ArticleAppDBContext context) => this._context = context;

        // 추가
        public async Task<User> AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAllUserAsync() => await _context.Users.ToListAsync();

        public async Task<User> GetUserByIdxAsync(string Email) => await _context.Users.FindAsync(Email);
        //await _context.Users.Where(user => user.IDX == idx).SingleOrDefaultAsync(); 구버전
    }
}
