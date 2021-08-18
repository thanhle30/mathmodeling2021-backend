using MathModeling21.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private MathModelingContext context { get; set; }
        public ArticleController(MathModelingContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult GetArticles()
        {
            var articles = context.Articles.ToList();
            //foreach (Article a in articles) GetImageList(a);
            return Ok(articles);
        }

        [HttpGet("{id}")]
        public IActionResult GetArticle(int id)
        {
            var article = context.Articles.FirstOrDefault(m => m.Id == id);
            if (article != null)
            {
                //GetImageList(article);
                return Ok(article);
            }
            else return BadRequest("Cannot find article");
        }

        //private void GetImageList(Article article)
        //{
        //    article.Images = article.ImagesStr.Split(",").ToList();
        //}
    }
}
