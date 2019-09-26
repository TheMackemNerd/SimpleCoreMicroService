﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class primeController : ControllerBase
    {

        // GET api/prime/5
        [HttpGet("{num}")]
        public ActionResult<string> Get(int num)
        {
            return Ok(new { IsPrime = IsPrime(num) });
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}



