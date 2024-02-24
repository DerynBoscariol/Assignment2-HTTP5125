using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125_A2.Controllers
{ 
    [ApiController]
public class J1Controller : ControllerBase
{      ///J1 - The New CCC (Canadian Calorie Counting)

    [HttpGet]
    [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        /// <summary>
        /// Solving "The New CCC (Canadian Calorie Counting)" problem, this method
        /// adds up total number of calories in a meal comprised by any of the
        /// four options from each category of the provided menu.
        /// </summary>
        /// <param name="burger">An integer representing the index of the burger option chosen</param>
        /// <param name="drink">An integer representing the index of the drink option chosen</param>
        /// <param name="side">An integer representing the index of the side option chosenr</param>
        /// <param name="dessert">An integer representing the index of the dessert option chosen</param>
        /// <returns>A string stating the sum of the calories from the 4 options chosen</returns>
        /// GET api/J1/Menu/1/1/1/1 --> "Your total calorie count is 858"
        /// GET api/J1/Menu/1/2/3/4 --> "Your total calorie count is 691"
        /// GET api/J1/Menu/3/1/4/2 --> "Your total calorie count is 816"

        //Creating the method and initalizing parameters
        public string Menu(int burger, int drink, int side, int dessert)
    {
        //Creating a list to contain the 4 burger options and their caloric values
        List<int> burgers = new List<int>();
        burgers.Add(461);
        burgers.Add(431);
        burgers.Add(420);
        burgers.Add(0);

        //Creating the variable burgerCal to contain the caloric value of the
        //option chosen. Since the list starts with an index of zero the index
        //of the chosen burger will be one less than the option number
        int burgerCal = burgers[burger - 1];

        //Recreating the same logic for the drink, side, and dessert options
        List<int> drinks = new List<int>();
        drinks.Add(130);
        drinks.Add(160);
        drinks.Add(118);
        drinks.Add(0);

        int drinkCal = drinks[drink - 1];

        List<int> sides = new List<int>();
        sides.Add(100);
        sides.Add(57);
        sides.Add(70);
        sides.Add(0);

        int sideCal = sides[side - 1];

        List<int> desserts = new List<int>();
        desserts.Add(167);
        desserts.Add(266);
        desserts.Add(75);
        desserts.Add(0);

        int dessertCal = desserts[dessert - 1];

        //Calculating the total calories as the sum of the caloric values of each option
        int totalCal = burgerCal + drinkCal + sideCal + dessertCal;

        //Concatenating a message stating the total calories and returning that message
            string message = "Your total calorie count is " + totalCal;
            return message;
    }
}
}



