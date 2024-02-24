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
    {   //J2 - Sounds Fishy!
        
        [HttpGet]
        [Route("api/J2/{a}/{b}/{c}/{d}")]
        /// <summary>
        /// Solving the "Sounds Fishy!" problem, this method recieves consecutive
        /// depth measurements and determines whether there is a fish rising, a
        /// fish diving, a constant depth or no fish based on whether the inputs
        /// are increasing, decreasing, remaianing the same, or not showing a
        /// consistent trend
        /// </summary>
        /// <param name="a">An integer representing the first depth recorded</param>
        /// <param name="b">An integer representing the second depth recorded</param>
        /// <param name="c">An integer representing the third depth recorded</param>
        /// <param name="d">An integer representing the fourth depth recorded</param>
        /// <returns>A string Stating "Fish Rising", "Fish Diving", "Constant Depth",
        /// or "No Fish" depending on the trend of the inputs</returns>
       
        /// GET api/J2/2/5/8/10 --> "Fish Rising"
        /// GET api/J2/17/14/7/2 --> "Fish Diving"
        /// GET api/J2/4/4/4/4 --> "Constant Depth"
        /// GET api/J2/9/2/6/1 --> "No Fish"

        //Creating the method and initializing the 4 parameters
        public string DetectFish(int a, int b, int c, int d)
        {
            //If the inputs are ascending, the method will return "Fish Rising"
            if (a < b && b < c && c < d)
            {
                return "Fish Rising";
            }
            //If the inputs are descending, the method will return "Fish Diving"
            else if (a > b && b > c && c > d)
            {
                return "Fish Diving";
            }
            //If the inputs are all the same, the method will return "Constant Depth"
            else if (a == b && b == c && c == d)
            {
                return "Constant Depth";
            }
            //If the inputs don't have any of the above consistent trends, the
            //method will return "No Fish"
            else
            {
                return "No Fish";
            }
        }
    }
}
