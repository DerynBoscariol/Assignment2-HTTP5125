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
{
    // GET api/J1/Menu/{burger}/{drink}/{side}/{dessert}
    [HttpGet]
    [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

    public string Menu(int burger, int drink, int side, int dessert)
    {
        List<int> burgers = new List<int>();
        burgers.Add(461);
        burgers.Add(431);
        burgers.Add(420);
        burgers.Add(0);

        int burgerCal = burgers[burger - 1];

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

        int totalCal = burgerCal + drinkCal + sideCal + dessertCal;
            string message = "Your total calorie count is " + totalCal;
            return message;
    }
}
}



