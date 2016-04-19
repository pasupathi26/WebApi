using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleWebApi.Models;

namespace SampleWebApi.Controllers
{
    public class EmployeeDetailsController : ApiController
    {

        public IEnumerable<Employee> Get()
        {
            var s = new List<Employee>(){
                
            new Employee()
            {
                UserId = "Emp120",
                UserName = "Pasupathi",
                Password = "rabiksha   ",
                Mobilenumber = "7411182882",
                Email = "pasupathi26@gmail.com"
            },
            new Employee()
            {
                UserId = "Emp123",
                UserName = "Sonikumari",
                Password = "rabik",
                Mobilenumber = "9916757680",
                Email = "soni2mail.xcom"
            }
            };
            return s;
        }
        public Employee GetEmployee(int UserID)
        {
            var s = new Employee()
            {

                UserId = "Emp120",
                UserName = "Pasupathi",
                Password = "rabiksha   ",
                Mobilenumber = "7411182882",
                Email = "pasupathi26@gmail.com"

            };
            return s;
        }
    }

}
