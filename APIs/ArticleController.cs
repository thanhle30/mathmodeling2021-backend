using MathModeling21.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MathModeling21.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private MathModelingContext context { get; set; }
        private readonly IWebHostEnvironment webHostEnvironment;

        public ArticleController(MathModelingContext ctx, IWebHostEnvironment hostEnvironment)
        {
            context = ctx;
            webHostEnvironment = hostEnvironment;
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

        [HttpPost]
        public IActionResult UploadFile()
        {
            if (Request.Form.Files.Count > 0)
            {
                var file = Request.Form.Files[0];  // just upload only 1 file for now              

                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                var uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                //get image's rendering url for client-side
                string apiUrl = Request.Host.Value;
                string httpRoot = Request.IsHttps ? "https://" : "http://";
                string imgUrl = httpRoot + apiUrl + "/Images/" + uniqueFileName;                

                return Ok(imgUrl);
            }
            else
            {
                return BadRequest("No file detected");
            }
        }

        // (possibly) better way: post and delete image -> separate file (ImageController)
        [HttpDelete]
        public IActionResult DeleteImage()
        {
            string fileName = Request.Form["fileName"];

            if (fileName != null && fileName != "")
            {
                string filePath = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName);
                System.IO.File.Delete(filePath);
                return Ok(fileName);
            }
            else
            {
                return BadRequest("No target file specified.");
            }
        }

        [Route("multi-img")]
        [HttpDelete]
        public IActionResult DeleteImages()
        {
            string imagesStr = Request.Form["images"];
            string[] images = imagesStr.Split(',');

            if (images.Length > 0)
            {
                foreach (string img in images)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath, "images", img);
                    System.IO.File.Delete(filePath);
                }
                return Ok(images);
            }
            else
            {
                return BadRequest("No target images specified.");
            }
        }
    }
}
