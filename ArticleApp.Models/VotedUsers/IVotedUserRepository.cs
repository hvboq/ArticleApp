using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArticleApp.Models.VotedUsers
{
    public interface IVotedUserRepository
    {
        Task<VotedUser> AddVotedUserAsync(VotedUser votedUser); //유저 추가
        Task<List<VotedUser>> GetAllVotedUserAsync(); //모든 유저 출력
    }
}
