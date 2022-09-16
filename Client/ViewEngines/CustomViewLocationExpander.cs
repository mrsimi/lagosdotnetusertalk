using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;

namespace lagosdotnetusertalk.Client.ViewEngines
{
    public class CustomViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, 
            IEnumerable<string> viewLocations)
        {
            return new string[]
            {
                "Client/{1}/UI/{0}.cshtml",
                "Client/Layouts/{0}.cshtml"
            };
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }
    }
}