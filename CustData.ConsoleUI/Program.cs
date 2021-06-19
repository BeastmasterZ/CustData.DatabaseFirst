using System;
using CustData.DatabaseFirst.DALayer;
using System.Linq;
using CustData.DatabaseFirst.DALayer.Models;

namespace CustData.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustDataRepository repository = new CustDataRepository();
            //var data = repository.GetAllData();
            //foreach (var usr in data )
            //{
            //    Console.WriteLine("{0}",usr.UserId);
            //}



            //Userdatum data = new Userdatum();
            //data.Fname = "peter";
            //data.Lname = "parker";
            //data.Email = "peter@parker.com";
            //data.Phone = 9876543211;
            //data.Gender = "male";
            //data.Address1 = "Seattle";
            //data.Address2 = "";
            //data.City = "New Jersy";
            //data.State = "New jersy state";
            //data.Country = "USA";
            //data.Purpose = "Visiting";

            //bool result = repository.AddDetails(data);

            //if(result)
            //{
            //    Console.WriteLine("Success");
            //}
            //else
            //{
            //    Console.WriteLine("Unsuccessful");
            //}



            bool result = repository.UpdateName(2, "John","wick");
            if (result)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
    }
}
