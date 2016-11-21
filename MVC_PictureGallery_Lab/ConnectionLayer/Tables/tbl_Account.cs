using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLayer.Tables
{
    class tbl_Account
    {
        public Guid id { get; set; }
        public string email { get; set; }
        public string Salt { get; set; }
        [Display(Name = "Password")]
        public string hash { get; set; }
        public string Fistname { get; set; }
        public string Lastname { get; set; }
        public ICollection<tbl_Album> Albums { get; set; }
        public ICollection<tbl_Account> Friends { get; set; }
        public tbl_Account()
        {
            Albums = new HashSet<tbl_Album>();
            Friends = new HashSet<tbl_Account>();
        }
    }
}
