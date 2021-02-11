using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01467577_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        // <summary> This code will print string</summary>
        // <param>It has no parameters</param>
        // <returns>It will return the string.</returns>
        // <example>
        // post api/Greeting -> Hello World!
        // </example>
        public string Post()
        {
            //It will return Hello World! as a String
            return "Hello World!";
        }


        // <summary> This code recevies a value and concate with the string</summary>
        // <param name="id">Input of number of id</param>
        // <returns>A sentence which display the messege with number</returns>
        //<example>
        // Get api/Greeting/3 -> Greetings to 3 people!
        // Get api/Greeting/6 -> Greetings to 6 people!
        // Get api/Greeting/0 -> Greetings to 0 people!
        //</example>

        public string Get(int id)
        {
            //It will return message with recevied number,(concate the number with string).
            return "Greeting to "+ id +" people!";
        }

    }
}
