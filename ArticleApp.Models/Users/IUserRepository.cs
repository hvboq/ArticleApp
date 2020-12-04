using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArticleApp.Models.Users
{
    interface IUserRepository
    {
        Task<User> AddUserAsync(User user); //유저 추가
        Task<List<User>> GetAllUserAsync(); //모든 유저 출력
        Task<User> GetUserByIdxAsync(string Email); //Email을 통해 유저 출력
    }
}
