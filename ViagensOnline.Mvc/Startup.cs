﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(ViagensOnline.Mvc.Startup))]

namespace ViagensOnline.Mvc
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Para obter mais informações sobre como configurar seu aplicativo, visite https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(
                new CookieAuthenticationOptions()
                {
                    AuthenticationType = "ViagensOnlineCookeAuth",
                    LoginPath = new PathString("/Admin/Login")
                }
                );
        }
    }
}
