using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Simple.Models;

namespace Simple.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }
        //public IActionResult Index()
        //{
        //    var contents = new List<Content>();
        //    for (int i = 1; i < 11; i++)
        //    {
        //        contents.Add(new Content
        //        {
        //            Id = i,
        //            title = $"{i}的标题",
        //            content = $"{i}的内容",
        //            isDelete = 0,
        //            createOn = DateTime.Now.AddDays(-i),
        //            updateOn = DateTime.Now.AddDays(-i)

        //        });
        //    }
        //    return View( new ContentViewModel{ Contents = contents });
        //}
        public IActionResult Index()
        {
            return View(new ContentViewModel { Contents=new List<Content> { contents } });
        }
    }
}