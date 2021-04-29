using MahaleSystem.ViewModel.Account;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel
{
    public   class UploadFile: IUploadFile
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UploadFile(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        string ProcessorUploadFile(Image model)
        {
            string Uniquename = null;
            if (model.Img != null && model.Img.Count > 0)
            {
                foreach (var item in model.Img)
                {
                    String UploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                    Uniquename = Guid.NewGuid().ToString() + "_" + item.FileName;
                    String filename = Path.Combine(UploadFolder, Uniquename);
                    //useing is used to when this blockexecuted immedaitly dispose
                    using (var filestream = new FileStream(filename, FileMode.Create))
                    {
                        item.CopyTo(filestream);
                    }
                }
            }

            return Uniquename;
        }

        string IUploadFile.ProcessorUploadFile(Image model)
        {
            throw new NotImplementedException();
        }
    }
}
