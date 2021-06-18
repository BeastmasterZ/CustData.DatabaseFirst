using System;
using System.Collections.Generic;
using System.Text;
using CustData.DatabaseFirst.DALayer;
using CustData.DatabaseFirst.DALayer.Models;
using System.Linq;

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
    }
}
