using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using PG.Data;
using PG.Models;
using PG.ViewModels;

namespace PG.Controllers
{
    public class PgController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly UserManager<IdentityUser> _userManager;

        public PgController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment, UserManager<IdentityUser> userManager)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
            _userManager = userManager;

        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Authorize]
        public IActionResult AddPg() {
            return View();
        }
        [HttpPost]
        public IActionResult AddPg(Pg_Owner pg) {
            if (ModelState.IsValid)
            { 
                pg.Email = HttpContext.Session.GetString("Email");
                _context.Pg_Owners.Add(pg);
                _context.SaveChanges();

                return RedirectToAction("AddImages", "Pg");
            }
            return View(pg);
        }
        [HttpGet]
        [Authorize]
        public IActionResult AddImages()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddImages(ImagesViewModel img)
        {
            if (ModelState.IsValid)
            {

                string uniqueFileName = null;
                Console.WriteLine(img.Photo);
                if (img.Photo != null)
                {
                    Console.WriteLine("ab");

                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/PG");
                    Console.WriteLine(uploadsFolder);
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + img.Photo.FileName;
                    Console.WriteLine(uniqueFileName);
                    string FilePath = Path.Combine(uploadsFolder, uniqueFileName);
                    Console.WriteLine(FilePath);
                    img.Photo.CopyTo(new FileStream(FilePath, FileMode.Create));
                }
                //ApplicationUser usr = await GetCurrentUserAsync();
                var Email = HttpContext.User.Identity.Name;
                Images newImg = new Images
                {

                    Email = Email,
                    PhotoPath = uniqueFileName
                };

                _context.Add(newImg);
                _context.SaveChanges();
            }
            return View(img);
        }
    }
}
