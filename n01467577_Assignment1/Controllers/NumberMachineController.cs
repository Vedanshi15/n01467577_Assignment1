using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01467577_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {

        // <summary> This code recevies a number and calculate the given mathematical expression</summary>
        // <param name="id">Input of number of id</param>
        // <returns>It will display the number(The result of the mathematical expression)</returns>
        // <example>
        // Get api/NumberMachine/10 -> 56
        // Get api/NumberMachine/-5 -> -19
        // Get api/NumberMachine/30 -> 156
        // </example>
        public int Get(int id)
        {
            //It will multiply the recevied number by 5 and then add 6. 
            return (5 * id) + 6;
        }
    }
}
