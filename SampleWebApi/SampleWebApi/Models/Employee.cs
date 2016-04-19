using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models
{
    public class Employee
    {
        public string UserId { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string Mobilenumber { set; get; }
        public string Email { set; get; }
    }
}