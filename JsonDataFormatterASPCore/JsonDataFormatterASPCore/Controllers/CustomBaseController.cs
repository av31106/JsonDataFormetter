using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonDataFormatterASPCore.Controllers
{
    public abstract class ControllerBaseCustom : ControllerBase
    {
        public string TestMessage { get; set; }
        public ControllerBaseCustom()
        {
            TestMessage = "Hello, I am working fine. Thanks for checking my health.";
        }
    }
}
