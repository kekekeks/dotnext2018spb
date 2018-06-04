using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Ooui.Shared;

namespace Ooui.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UI.HeadHtml = "<link rel='stylesheet' href='/lib/bootstrap/css/bootstrap.css'/>";
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://127.0.0.1:6002")
                .UseStartup<Startup>()
                .Build();
    }
}
