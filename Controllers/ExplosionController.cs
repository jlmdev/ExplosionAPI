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
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{s}")]
        public string Explode(string s)
        {
            // Given a string of digits (s), return a string
            // where each digit is repeated a number of times equal to its value
            var output = "";
            for (var index = 0; index < s.Length; index++)
            {
                var sCharacter = s[index];
                var sCharacterString = sCharacter.ToString();
                var sInteger = Int32.Parse(sCharacterString);

                for (var addNumber = 0; addNumber < sInteger; addNumber++)
                {
                    output += sCharacter;
                }

            }
            return output;
        }
    }
}