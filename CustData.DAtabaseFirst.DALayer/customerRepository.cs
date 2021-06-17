using System;
using System.Collections.Generic;
using System.Text;
using CustData.DAtabaseFirst.DALayer.Models;

namespace CustData.DAtabaseFirst.DALayer
{
    public class customerRepository
    {
        customerContext context;

        public customerRepository()
        {
            context = new customerContext();
        }

        
    }
}
