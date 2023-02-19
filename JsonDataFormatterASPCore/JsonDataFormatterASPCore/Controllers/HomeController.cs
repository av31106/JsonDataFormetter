using JsonDataFormatterASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonDataFormatterASPCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBaseCustom
    {
        [HttpGet]
        [Route("TestAPI")]
        public string TestAPI()
        {
            return TestMessage;
        }

        [HttpPost]
        [Route("FormatJsonData")]
        public string FormatJsonData([FromForm] string jsonString)
        {
            if (!string.IsNullOrEmpty(jsonString))
            {
                var jsonObject = JsonConvert.DeserializeObject(jsonString);
                string jsonStr = JsonConvert.SerializeObject(jsonObject);
                string jsonFormatted = JValue.Parse(jsonStr).ToString(Formatting.Indented);
                return jsonFormatted;
            }
            else
            {
                return "";
            }
        }
        [HttpPost]
        [Route("RemoveWhiteSpace")]
        public string RemoveWhiteSpace([FromForm] string jsonString)
        {
            if (!string.IsNullOrEmpty(jsonString))
            {
                var jsonObject = JsonConvert.DeserializeObject(jsonString);
                string jsonStr = JsonConvert.SerializeObject(jsonObject);
                string jsonFormatted = JValue.Parse(jsonStr).ToString(Formatting.None);
                return jsonFormatted;
            }
            else
            {
                return "";
            }
        }
    }
}
