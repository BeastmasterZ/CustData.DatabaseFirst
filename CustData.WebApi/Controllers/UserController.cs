using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustData.DatabaseFirst.DALayer;
using CustData.DatabaseFirst.DALayer.Models;

namespace CustData.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        CustDataRepository repository = null;

        public UserController()
        {
            repository = new CustDataRepository();
        }

        public JsonResult GetAllData()
        {
            List<Userdatum> userdata = null;
            try
            {
                userdata = repository.GetAllData();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                userdata = null;
            }
            return Json(userdata);
        }

        public JsonResult GetById(decimal userId)
        {
            List<Userdatum> userdata = null;
            try
            {
                userdata = repository.GetById(userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                userdata = null;
            }
            return Json(userdata);
        }

        public JsonResult GetByUserName(string Fname, string Lname)
        {
            List<Userdatum> userdata = null;
            string Uname = Fname + Lname;
            try
            {
                userdata = repository.GetByUserName(Uname);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                userdata = null;
            }
            return Json(userdata);
        }

        [HttpPost]
        public JsonResult AddDetails(Userdatum user)
        {
            
            bool status = false;
            string message;

            try
            {
                status = repository.AddDetails(user);
                if (status)
                {
                    message = "Details entered Successfully = " + user.UserId;
                }
                else
                {
                    message = " Unsuccessful operation";
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                message = "Some error occured";
            }
            return Json(message);
        }

        [HttpPost]
        public JsonResult AddDetailsbyparam(string fname, string lname, string email, decimal phone, string gender, string address1, string address2, string city, string state, string country, string purpose)
        {
            bool status = false;
            string message;
            try
            {
                status = repository.AddDetailsbyparam( fname, lname, email, phone, gender, address1, address2, city, state, country, purpose);
                if (status)
                {
                    message = "Details entered Successfully ";
                }
                else
                {
                    message = " Unsuccessful operation";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                message = "Some error occured";
            }
            return Json(message);

        }

        [HttpPut]
        public bool UpdateName(decimal userId, string fname, string lname)
        {
            bool Status = false;
            try
            {
                Status = repository.UpdateName(userId, fname, lname);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Status = false;
            }
            return Status;
        }

        [HttpPut]
        public bool UpdateEmail(decimal userId, string email)
        {
            bool status = false;

            try
            {
                status = repository.UpdateEmail(userId, email);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                status = false;
            }

            return status;
        }

        [HttpPut]
        public bool UpdateAddress(decimal userId, string address1, string address2, string city, string state, string country)
        {
            bool status = false;
            try
            {
                status = repository.UpdateAddress(userId, address1, address2, city, state, country);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                status = false;
            }

            return status;
        }

        [HttpDelete]
        public JsonResult Deleteuser(decimal userId)
        {
            bool status = false;
            try
            {
                status = repository.Deleteuser(userId);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                status = false;
            }

            return Json(status);
        }
    }
}
