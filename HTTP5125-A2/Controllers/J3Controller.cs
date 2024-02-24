using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125_A2.Controllers
{

    [ApiController]
    public class J3Controller : ControllerBase
    {   //J3 - Slot Machines
        
        [HttpGet]
        [Route("api/J3/{q}/{x}/{y}/{z}")]
        //
        public string UntilBroke(int q, int x, int y, int z)
        {
            var round = 0;
            
             while (q > 0)
            {
          //Machine 1
            x = x + 1;

                if (x == 35)
                {
                    x = 0;
                    q = q + 30;
                }
                q = q - 1;
                round = round + 1;

          //Machine 2
            y = y + 1;

                if (y == 100)
                {
                    y = 0;
                    q = q + 60;
                }
                q = q - 1;
                round = round + 1;

          //Machine 3
            z = z + 1;

                if (z == 10)
                {
                    z = 0;
                    q = q + 9;
                }
            q = q - 1;
            round = round + 1;


              }

            var message = "Martha plays " + round + " times before going broke.";

            return message;
        }
    }
}
