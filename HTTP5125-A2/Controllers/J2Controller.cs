using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125_A2.Controllers
{

    [ApiController]
    public class J2Controller : ControllerBase
    {
        [HttpGet]
        [Route("api/J2/{a}/{b}/{c}/{d}")]

        public string detectFish(int a, int b, int c, int d)
        {
            if (a < b && b < c && c < d)
            {
                return "Fish Rising";
            }
            else if (a > b && b > c && c > d)
            {
                return "Fish Diving";
            }
            else if (a == b && b == c && c == d)
            {
                return "Constant Depth";
            }
            else
            {
                return "No Fish";
            }
        }
    }
}
