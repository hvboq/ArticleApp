using Dul.Domain.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AriticleApp.Models
{
    /// <summary>
    /// Repository Class : ADO.NET 또는 Dapper 또는 Entitty Framework core
    /// </summary>
    public class ArticleRepository : IArticleRepository
    {
        public Task<Article> AddArticleAsync(Article article)
        {
            throw new NotImplementedException();
        }

        public Task DeleteArticleAsync(int i)
        {
            throw new NotImplementedException();
        }

        public Task<Article> EditArticleAsynce(Article article)
        {
            throw new NotImplementedException();
        }

        public Task<PagingResult<Article>> GetAllAsync(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Article> GetArticleByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Article>> GetArticlesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
