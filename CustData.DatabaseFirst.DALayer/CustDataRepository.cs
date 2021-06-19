using System;
using System.Collections.Generic;
using System.Text;
using CustData.DatabaseFirst.DALayer;
using CustData.DatabaseFirst.DALayer.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CustData.DatabaseFirst.DALayer
{
    public class CustDataRepository
    {
        customerContext context;
        public CustDataRepository()
        {
            context = new customerContext();
        }
        public List<Userdatum> GetAllData()
        {
            List<Userdatum> userdata = null;
            try
            {
                userdata = (from User in context.Userdata orderby User.UserId select User).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                userdata = null;
            }

            return userdata;
        }

        public List<Userdatum> GetById(decimal userId)
        {
            List<Userdatum> userdata = null;
            try
            {
                userdata = context.Userdata.Where(u => u.UserId == userId).ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                userdata = null;
            }

            return userdata;
        }

        public List<Userdatum> GetByUserName(string Uname)
        {
            List<Userdatum> userdata = null;
            try
            {
                userdata = context.Userdata.Where(u => EF.Functions.Like(u.Fname + u.Lname, Uname)).ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                userdata = null;
            }
            return userdata;
        }


    }
}
