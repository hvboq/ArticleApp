using Dul.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AriticleApp.Models
{
    /// <summary>
    /// Repository Class : ADO.NET 또는 Dapper 또는 Entitty Framework core
    /// </summary>
    public class ArticleRepository : IArticleRepository
    {
        ArticleAppDBContext _context;
        public ArticleRepository(ArticleAppDBContext context)
        {
            this._context = context;
        }
        //입력
        public async Task<Article> AddArticleAsync(Article article)
        {
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
            return article;
        }
        // 페이징
        public async Task<PagingResult<Article>> GetAllAsync(int pageIndex, int pageSize)
        {
            var totalRecords = await _context.Articles.CountAsync();
            var articles = await _context.Articles
                .OrderByDescending(a => a.Id)
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagingResult<Article>(articles, totalRecords);
        }

        public Task<List<Article>> GetArticlesAsync()
        {
            return _context.Articles.OrderByDescending(a => a.Id).ToListAsync();
        }
        public async Task<Article> GetArticleByIdAsync(int id)
        {
            return await _context.Articles.FindAsync(id);
        }
        public Task DeleteArticleAsync(int i)
        {
            throw new NotImplementedException();
        }

        public Task<Article> EditArticleAsynce(Article article)
        {
            throw new NotImplementedException();
        }


        
    }
}
