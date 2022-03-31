using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace BurgerAPI {

public class BurgerFactory
{

public IBurger returnInstance;

public IBurger getBurger(string BurgerType)
{
   
       switch(BurgerType)
       {
           case("chicken"):
           returnInstance = new chicken();
           break;
           case("plain"):
           returnInstance = new PlainBurger();
            break;
           case("cheese"):
           returnInstance = new CheeseBurger();
           break;
           case("veggie"):
           returnInstance = new VegBurger();
           break;


       }

        return returnInstance;


    }
}



}