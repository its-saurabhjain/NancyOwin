using System;
using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(NancyMVC.Startup))]
namespace NancyMVC
{
    public class Startup
    {
        public void Configuration(IAppBuilder app) {
            /*
            app.Run(context =>
                {
                    string t = DateTime.Now.Millisecond.ToString();
                    return context.Response.WriteAsync(DateTime.Now + " Non Production OWIN App");
                });
                */
            //app.Use() Plugin the middleware code
            //
            app.UseNancy();
        }
    }
}