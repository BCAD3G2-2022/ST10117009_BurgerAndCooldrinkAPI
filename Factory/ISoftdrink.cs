using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace softdrinkAPI
{
public interface ISoftdrink
{

   string getFlavour();

   string getDiet();

  

}

}