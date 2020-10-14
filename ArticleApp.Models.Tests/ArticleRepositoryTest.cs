using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ArticleApp.Models.Tests
{
    [TestClass]
    public class ArticleRepositoryTest
    {
        [TestMethod]
        public async Task ArticleRepositoryAllMetodTest()
        {
            //obj Creation
            var options = new DbContextOptionsBuilder<ArticleAppDBContext>()
                //.UseInMemoryDatabase(databaseName: "ArticleApp").Options;
                .UseSqlServer("server=(localdb)\\mssqllocaldb;database=ArticleApp;integrated security=true;").Options;
            //Add Method
            using (var context = new ArticleAppDBContext(options))
            {
                //Repo Obj creation
                var repository = new ArticleRepository(context);
                var model = new Article
                {
                    Title = "[1]게시판 시작",
                    Created = DateTime.Now
                };
                await repository.AddArticleAsync(model);
                await context.SaveChangesAsync();
            }
            using (var context = new ArticleAppDBContext(options))
            {
                Assert.AreEqual(1, await context.Articles.CountAsync());
                var model = await context.Articles.Where(m => m.Id == 1).SingleOrDefaultAsync();
                Assert.AreEqual("[1]게시판 시작", model?.Title);
            }
            // get All article 
            using (var context = new ArticleAppDBContext(options))
            {
                //Repo Obj creation
                var repository = new ArticleRepository(context);
                var model = new Article
                {
                    Title = "[2]게시판 가동",
                    Created = DateTime.Now
                };
                context.Articles.Add(model); //[1] 저장
                await context.SaveChangesAsync();

                context.Articles.Add(new Article
                {
                    Title = "[3]게시판",
                    Created = DateTime.Now
                });
                await context.SaveChangesAsync();
            }

            // GetByIdAsync() Method Test
            using (var context = new ArticleAppDBContext(options))
            {
                var repository = new ArticleRepository(context);
                var model = await repository.GetArticleByIdAsync(2);

                Assert.IsTrue(model.Title.Contains("가동"));
            }
        }
    }
}
