using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{

    public class Composite : IComponents 
    {

        string part;

        public Composite(string part)
        {
            this.part = part;
        }

        public Composite()
        {
        }

        List<IComponents> components = new List<IComponents>(); 

        public string getPart()
        {
            string value = null;

            for(int i =0; i < components.Count; i++)
            {
                value = components.ElementAt(i).getBurgerPart();
            }

            return value;
        }

        public void addPart(IComponents component)
        {
           components.Add(component);
        }

        public void removePart(IComponents component)
        {
           components.Remove(component);
        }

        public string getBurgerPart()
        {
            throw new NotImplementedException();
        }
    }
    }

