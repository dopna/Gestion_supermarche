using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace supermarcheAPI.Controllers
{
    [Route("api/articles")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ApplicationBuilder context;

        public ArticleController()
        {
            
        }

     
       
    }
}
