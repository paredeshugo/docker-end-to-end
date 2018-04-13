using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GenerateRandomPassword.Controllers
{
    [Route("api/[controller]")]
    public class GenerateController : Controller
    {
        const string ALPHABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789,./<>?!@#$%^()-=_+[]{};:";
        private readonly Random _random = new Random();

        // GET api/generate
        [HttpGet("{length=12}")]
        public IActionResult Get(int length)
        {
            var chars = Enumerable.Repeat(ALPHABET, length).Select(s => s[_random.Next(s.Length)]);
            var password = new string(chars.ToArray());

            return Json(new {password = password});
        }
    }
}
