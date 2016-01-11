using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using System.IO;
using Microsoft.Net.Http.Headers;
using System;
using FileUpload01.Models;
using System.Linq;

namespace FileUpload01.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _environment;
        private ApplicationDbContext _db;

        public HomeController(IHostingEnvironment environment, ApplicationDbContext db)
        {
            _environment = environment;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Uploads.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(IFormFile file)
        {
            try
            {
                var uploads = Path.Combine(_environment.WebRootPath,"uploads");
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                FileUpload01.Models.File newFile = new FileUpload01.Models.File();
                newFile.ImagePath = fileName;
                _db.Uploads.Add(newFile);
                _db.SaveChanges();
                await file.SaveAsAsync(Path.Combine(uploads, fileName));
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex);
                return View();
            }
        }
    }
}
