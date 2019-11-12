using System;
using System.Collections.Generic;

namespace WebApplication10.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        //[DisplayName("Name user")]
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public ICollection<Job> Jobs { get; set; } = new List<Job>(); 
    }
}