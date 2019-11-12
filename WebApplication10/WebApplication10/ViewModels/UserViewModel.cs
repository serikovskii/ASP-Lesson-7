using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication10.ViewModels
{
    public class UserViewModel
    {
        [DisplayName("Name user")]
        public string UserName { get; set; }
        [DisplayName("Date regis")]
        public DateTime CreationDate { get; set; }
    }
}