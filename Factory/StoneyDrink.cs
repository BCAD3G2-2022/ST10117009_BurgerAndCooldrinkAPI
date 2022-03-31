using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace softdrinkAPI
{
    public class stoneySoftDrink : ISoftdrink
    {
        public string getFlavour()
        {
            return "Stoney";
        }
        public string getDiet()
        {
            return "Yes";
        }
    }
}