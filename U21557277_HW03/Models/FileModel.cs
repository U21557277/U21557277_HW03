using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace U21557277_HW03.Models
{
    public class FileModel
    {
        //Display options.

        [Display(Name = "File Name")]
        public string FileName { get; set; }

        [Required(ErrorMessage = "Please select file.")]
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] Files { get; set; }

        public string file { get; set; }
    }
}