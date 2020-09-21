using Dul.Domain.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AriticleApp.Models
{
    /// <summary>
    /// ArticleRepository Interface
    /// </summary>
    public interface IArticleRepository
    {
        Task<Article> AddArticleAsync(Article article); //입력
        Task<List<Article>> GetArticlesAsync(); //출력
        Task<Article> GetArticleByIdAsync(int id); //상세
        Task<Article> EditArticleAsynce(Article article); //수정
        Task DeleteArticleAsync(int i); //삭제

        Task<PagingResult<Article>> GetAllAsync(int pageIndex, int pageSize);
    }
}
