using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using MySql.Data.MySqlClient;
using supermarcheAPI.models;
using supermarcheAPI.Entities;
using supermarcheAPI.Controllers;
using System.Collections.Generic;
using System.Threading.Tasks;
using Article = supermarcheAPI.Entities.Article;
using System.Net;


namespace supermarcheAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly SupermarchébdContext DBContext;

        public ArticlesController(SupermarchébdContext DBContext)
        {
            this.DBContext = DBContext;
        }

        [HttpGet("GetArticle")]
        public async Task<ActionResult<IEnumerable<Article>>> GetArticle()
        {
            return await DBContext.Articles.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> GetMariage(int id)
        {
            var article = await DBContext.Articles.FindAsync(id);

            if (article == null)
            {
                return NotFound();
            }

            return article;
        }

        [HttpPost]
        public async Task<ActionResult<Article>> PostMariage(Article article)
        {
            DBContext.Articles.Add(article);
            await DBContext.SaveChangesAsync();

            return CreatedAtAction("GetArticle", new { id = article.Artcode }, article);
        }

    }
}
