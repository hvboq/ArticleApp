using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArticleApp.Models.VotedUsers
{
    public class VotedUserRepository : IVotedUserRepository
    {
        private readonly ArticleAppDBContext _context;
        public VotedUserRepository(ArticleAppDBContext context) => this._context = context;
        public async Task<VotedUser> AddVotedUserAsync(VotedUser votedUser)
        {
            _context.VotedUsers.Add(votedUser);
            await _context.SaveChangesAsync();
            return votedUser;
        }

        public async Task<List<VotedUser>> GetAllVotedUserAsync() => await _context.VotedUsers.ToListAsync();
    }
}
