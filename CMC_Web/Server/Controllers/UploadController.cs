using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileUploadWASM.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        public UploadController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        [HttpPost]
        public async Task Post()
        {
            if(HttpContext.Request.Form.Files.Any())
            {
                foreach (var file in HttpContext.Request.Form.Files)
                {                        
                    var path = Path.Combine(environment.ContentRootPath, "upload", file.FileName);

                    using(var stream=new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
            }
        }
    }
}