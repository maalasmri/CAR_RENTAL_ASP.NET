using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace KFMCproject.App_Code
{
    public class clientside
    {

            [Required(ErrorMessage = "Please enter email")]
            [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email is not valid")]
            public string EmailId { get; set; }
            [Required(ErrorMessage = "Please enter password")]
            public string Password { get; set; }
        }
    }
