using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{

public class Cheese: IComponents
{
public string getBurgerPart()
{
 return "Cheese";
}



}
}

