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

        public bool AddDetails(Userdatum user)
        {
            bool status = false;
            try
            {
                context.Userdata.Add(user);
                context.SaveChanges();
                status = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                status = false;
            }

            return status;
        }

        public bool AddDetailsbyparam(string fname, string lname, string email, decimal phone, string gender, string address1, string address2, string city, string state, string country, string purpose)
        {
            bool status = false;
            try
            {
                Userdatum data = new Userdatum();
                data.Fname = fname;
                data.Lname = lname;
                data.Email = email;
                data.Phone = phone;
                data.Gender = gender;
                data.Address1 = address1;
                data.Address2 = address2;
                data.City = city;
                data.State = state;
                data.Country = country;
                data.Purpose = purpose;

                context.Userdata.Add(data);
                context.SaveChanges();
                status = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                status = false;
            }

            return status;
        }

        public bool UpdateName(decimal userId, string fname, string lname)
        {

            bool status = false;
            Userdatum data = context.Userdata.Find(userId);
            try
            {
                if(data!=null)
                {
                    data.Fname = fname;
                    data.Lname = lname;
                    context.SaveChanges();
                    status = true;

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                status = false;
                
            }



            return status;
        }

        public bool UpdateEmail(decimal userId, string email)
        {
            bool status = false;
            Userdatum data = context.Userdata.Find(userId);
            try
            {
                if (data != null)
                {
                    data.Email = email;
                    context.SaveChanges();
                    status = true;

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                status = false;

            }

            return status;
        }

        public bool UpdateAddress(decimal userId, string address1, string address2,string city, string state , string country)
        {
            bool status = false;
            Userdatum data = context.Userdata.Find(userId);

            try
            {
                if (data != null)
                {
                    data.Address1 = address1;
                    data.Address2 = address2;
                    data.City = city;
                    data.State = state;
                    data.Country = country;
                    context.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                status = false;

            }

            return status;
        }

        public bool Deleteuser(decimal userId)
        {
            bool status = false;
            Userdatum data = context.Userdata.Find(userId);
            try
            {
                if (data != null)
                {
                    context.Userdata.Remove(data);
                    context.SaveChanges();
                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                status = false;

            }

            return status;
        }
    }
}
