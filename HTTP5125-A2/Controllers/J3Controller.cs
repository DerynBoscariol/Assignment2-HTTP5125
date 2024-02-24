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
    {   //J3 - Slot Machines - On page 4
        //https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2000/stage1/2000CCCStage1Contest.pdf

        [HttpGet]
        [Route("api/J3/{q}/{x}/{y}/{z}")]
        /// <summary>
        /// Solving the "Slot Machines" problem, this method determines
        /// how many times Martha could play three slot machines in order until
        /// she goes broke, given how many quarters she has and how many
        /// times each machine has been played since it last paid out. The first
        /// machine pays out 30 quarters every 35th time it's played, the second
        /// machine pays out 60 quarters every 100th time it's played, and the
        /// third machine pays out 9 quarters every 10th time it's played. Each
        /// machine requires one quarter per turn.
        /// </summary>
        /// <param name="q">An integer representing the number of quarters Martha
        /// has when she starts playing</param>
        /// <param name="x">An integer representing the number of times the first
        /// machine has been played since it last paid out</param>
        /// <param name="y">An integer representing the number of times the second
        /// machine has been played since it last paid out</param>
        /// <param name="z">An integer representing the number of times the third
        /// machine has been played since it last paid out</param>
        /// <returns>A string stating how many total rounds Martha plays before
        /// going broke</returns>
        
        /// GET api/J3/48/3/10/4 --> "Martha plays 66 times before going broke."
        /// GET api/J3/256/15/76/5 --> "Martha plays 1179 times before going broke."
        /// GET api/J3/93/30/26/8 --> "Martha plays 390 times before going broke."

        //Creating method and initializing parameters
        public string UntilBroke(int q, int x, int y, int z)
        {
            //Creating a variable to count every round played on each machine
            //and assigning it 0 to start
            var round = 0;

            //Creating a while loop that runs while Martha has more than 0 quarters
             while (q > 0)
            {
           //Machine 1
          //Adding another turn to the first machine and taking one quarter
          //away from Martha
                 x = x + 1;
                 q = q - 1;
                //If the machine has now been played 35 times since last paying
                //out, the number of times it's been played is reset to zero
                //and Martha receives 30 more quarters
                if (x == 35)
                {
                    x = 0;
                    q = q + 30;
                }
                //Martha has played one more round
                round = round + 1;
            //This same logic is repeated for machines 2 and 3
          //Machine 2
                 y = y + 1;
                 q = q - 1;

                if (y == 100)
                {
                    y = 0;
                    q = q + 60;
                }
                round = round + 1;

          //Machine 3
                 z = z + 1;
                 q = q - 1;

                if (z == 10)
                {
                    z = 0;
                    q = q + 9;
                }
            
                round = round + 1;


              }
             //Once Martha has 0 quarters, the while loop finishes and the
             //method returns a concatenated string stating how many rounds she
             //has played
            var message = "Martha plays " + round + " times before going broke.";

            return message;
        }
    }
}
