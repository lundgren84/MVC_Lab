using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_MVC_med_Javascript_och_Ajax.Models
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string Salt { get; set; }
        [Display(Name = "Password")]
        public string hash { get; set; }
    }
}