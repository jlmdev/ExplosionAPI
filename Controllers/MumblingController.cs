using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{s}")]
        public String Accum(string s)
        {
            var output = "";
            for (var index = 0; index < s.Length; index++)
            {
                var character = s[index];
                var characterString = character.ToString();
                for (var counter = 0; counter <= index; counter++)
                {
                    if (counter == 0)
                    {
                        output += characterString.ToUpper();
                    }
                    else
                    {
                        output += characterString.ToLower();
                    }
                }
                if (index != (s.Length - 1))
                {
                    output += "-";
                }
            }
            return output;
        }
    }
}