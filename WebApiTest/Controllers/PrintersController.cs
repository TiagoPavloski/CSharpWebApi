﻿using System.Collections.Generic;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class PrintersController : ApiController
    {
        // GET api/customers
        public IEnumerable<PrinterInfo> Get()
        {
            return new[]
            {
                new PrinterInfo()
                {
                    Name = "Printer 1",
                    SerialKey = "1234",
                    Customer = new Customer()
                    {
                        Id = 1,
                        Name = "Customer 1"
                    }
                },
                 new PrinterInfo()
                {
                    Name = "Printer 2",
                    SerialKey = "5678",
                    Customer = new Customer()
                    {
                        Id = 2,
                        Name = "Customer 2"
                    }
                }
            };
        }
    }
}
