using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01467577_Assignment1.Controllers
{
    public class SquareController : ApiController
    {

        // <summary> This code recevies a number, calculate the square of the number and will print the result.</summary>
        // <param name="id">Input of number of id</param>
        // <returns>It will display the square of number</returns>
        // <example>
        // Get api/Square/2 -> 4
        // Get api/Square/-2 -> 4
        // Get api/Square/10 -> 100
        // </example>

        public int Get(int id)
        {
            // It will multiply the recevied number by same number.
            return id * id;
        }
    }
}
