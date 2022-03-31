using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{

public class Bun: IComponents
{
public string getBurgerPart()
{
 return "Bun";
}
}
}