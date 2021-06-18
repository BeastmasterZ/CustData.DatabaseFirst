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
            var data = repository.GetAllData();
            foreach (var usr in data )
            {
                Console.WriteLine("{0}",usr.UserId);
            }
            
        }
    }
}
