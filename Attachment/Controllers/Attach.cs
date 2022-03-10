using Attachment.DAL;
using Attachment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Attachment.Controllers
{
    public class AttachController : Controller
    {
        private readonly DatabaseContext _context;
        public AttachController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var items = _context.Employees.ToList();
            return View(items);
        }

        //public IActionResult GetFilesByEmployeeIdAsync(int id)
        //{
        //    var items = _context.Files.Where(f => f.EmployeeId == id).ToList<Files>();
        //    return PartialView("_EmployeesAttachments", items);
        //}

        [HttpPost]
        public IActionResult Index(IFormFile files)
        {
            if (files != null)
            {
                if (files.Length > 0)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(files.FileName);
                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);
                    // concatenating  FileName + FileExtension
                    //var newFileName = String.Concat(Convert.ToString(Guid.NewGuid()), fileExtension);
                    string newFileName = String.Format("Attachment {0}.png",
                                DateTime.UtcNow.ToString("yyyy-MM-dd HH-mm-ss"));
                    var objfiles = new Files()
                    {
                        DocumentId = 0,
                        Name = newFileName,
                        FileType = fileExtension,
                        CreatedOn = DateTime.Now,
                        EmployeeId = 1
                        
                    };

                    using (var target = new MemoryStream())
                    {
                        files.CopyTo(target);
                        objfiles.DataFiles = target.ToArray();
                    }

                    _context.Files.Add(objfiles);
                    _context.SaveChanges();

                }
            }
            return View();
        }
    }
}
