using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01467577_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {

        // <summary> This code recevies a number and add 10 into that number</summary>
        // <param name="id">Input of number of id</param>
        // <returns>It will display the number(sum of entered number and 10)</returns>
        // <example>
        // Get api/AddTen/21 -> 31
        // Get api/AddTen/0 -> 10
        // Get api/AddTen/-9 -> 1
        // </example>

        public int Get(int id)
        {
            // It will add 10 in recevied value and return the total value.
            return id+10;
        }
    }
}
