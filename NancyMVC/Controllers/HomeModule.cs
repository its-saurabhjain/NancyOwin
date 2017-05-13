using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyMVC.Controllers
{
    public class HomeModule: NancyModule
    {
        public HomeModule() {

            Get["/"] = _ => View["Home"];
        }
    }
}