﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ugani_Restaurant.Startup))]
namespace Ugani_Restaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
