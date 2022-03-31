using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Controllers
{
  [ApiController]  
  [Route ("[controller]")]

  public class customBurgerControllers : ControllerBase
  {
      [HttpGet]

      public List<string> Get (bool Tomatoe, bool Cheese, bool Bun, bool Patty, bool lettuce)
      {
         IComponents burgerBun = new Bun();
         IComponents burgerPatty = new Patty();
         IComponents burgerLettuce = new Bun();
         IComponents burgerTomatoe = new Bun();
         IComponents burgerCheese = new Bun();

Composite baseBurger = new Composite();
baseBurger.addPart(burgerBun);
baseBurger.addPart(burgerPatty);
baseBurger.addPart(burgerLettuce);
baseBurger.addPart(burgerTomatoe);
baseBurger.addPart(burgerCheese);


if(Tomatoe)
{
    baseBurger.removePart(burgerTomatoe);
}

if(lettuce)
{
    baseBurger.removePart(burgerLettuce);
}
if(Cheese)
{
    baseBurger.removePart(burgerCheese);
}
if(Bun)
{
    baseBurger.removePart(burgerTomatoe);
}


List <string> returnList = new List<string>();
returnList.Add(baseBurger.getBurgerPart());

return returnList;

      }
  }
}