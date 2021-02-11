using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01467577_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        // <summary> This method will take an input for the number of forthnights, calculate the hosting cost with tax and print the charges</summary>
        // <param name="id">Input of number of id</param>
        // <returns>It will display the tax and hosting charge with and without tax.</returns>
        // <example>
        // Get api/HostingCost/0 -> 1 fortnights at $5.50/FN= $5.50CAD -> HST 13%= $0.715CAD -> Total= $6.215CAD
        // Get api/HostingCost/14 -> 2 fortnights at $5.50/FN= $11.00CAD -> HST 13%= $1.43CAD -> Total= $12.43CAD
        // Get api/HostingCost/15 -> 2 fortnights at $5.50/FN= $11.00CAD -> HST 13%= $1.43CAD -> Total= $12.43CAD
        // Get api/HostingCost/21 -> 2 fortnights at $5.50/FN= $11.00CAD -> HST 13%= $1.43CAD -> Total= $12.43CAD
        // Get api/HostingCost/28 -> 3 fortnights at $5.50/FN= $16.50CAD -> HST 13%= $2.145CAD -> Total= $18.645CAD
        // </example>
        public string Get(decimal id)
        {
            // This code will take input number and calculate the hosting cost with and without the HST.
            decimal total,total_without_HST,HST;
            decimal FN = 1, one_FN_rate = 5.50M;
            FN = Math.Ceiling(id / 14);
            if(id%14==0)
            {
                FN = FN + 1;
            }
            total_without_HST = FN * one_FN_rate;
            HST = (total_without_HST * 13)/100;
            total = HST + total_without_HST;
            return "-> "+FN + " fortnights at $5.50/FN= $" + total_without_HST + "CAD -> HST 13%= $" + HST + "CAD -> Total= $" + total + "CAD";
            
        }
    }
}
