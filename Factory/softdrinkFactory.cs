using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace softdrinkAPI {

public class softdrinkFactory
{

public ISoftdrink returnInstance;

public ISoftdrink GetDrinks(string DrinkType)
{
   
       switch(DrinkType)
       {
           case("Fanta"):
           returnInstance = new drinks();
           break;
          


       }

        return returnInstance;


    }
}
}


