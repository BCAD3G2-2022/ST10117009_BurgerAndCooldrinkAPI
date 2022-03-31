using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace softdrinkAPI
{
    public class CokeSoftDrink : ISoftdrink
    {
        public string getFlavour()
        {
            return "Coke";
        }
        public string getDiet()
        {
            return "No";
        }
    }
}