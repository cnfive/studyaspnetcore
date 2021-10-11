using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication16.Models;

using System.Net.Http.Headers;
using System.IO;



namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        [HttpPost]



        public JsonResult UploadCKEditorImage()



        {



            var files = Request.Form.Files;



            if (files.Count == 0)




            {




                var rError = new




                {




                    uploaded = false,




                    url = string.Empty




                };




                return Json(rError);




            }




            var formFile = files[0];




            var upFileName = formFile.FileName;




            //大小，格式校验....




            var fileName = Guid.NewGuid() + Path.GetExtension(upFileName);




            var saveDir = @".\wwwroot\upload\";




            var savePath = saveDir + fileName;




            var previewPath = "/upload/" + fileName;









            bool result = true;




            try




            {




                if (!Directory.Exists(saveDir))




                {




                    Directory.CreateDirectory(saveDir);




                }




                using (FileStream fs = System.IO.File.Create(savePath))




                {




                    formFile.CopyTo(fs);




                    fs.Flush();




                }




            }




            catch (Exception ex)




            {




                result = false;




            }




            var rUpload = new




            {




                uploaded = result,




                url = result ? previewPath : string.Empty




            };




            return Json(rUpload);




        }



    }
}
