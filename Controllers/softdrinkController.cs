using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace softdrinkAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class softdrinkController : ControllerBase
    {
       
        [HttpGet]
       public List<softdrinks> Get(string DrinkType="Flavour")
        {
           softdrinkFactory softDrinkFactory = new softdrinkFactory();
           ISoftdrink softDrink = softDrinkFactory.GetDrinks(DrinkType);
           List<softdrinks> returnedSoftDrink = new List<softdrinks>();
           returnedSoftDrink.Add(new softdrinks{flavour=softDrink.getFlavour(),diet=softDrink.getDiet()});

           return returnedSoftDrink;
        }
    }
}