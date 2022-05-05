using CalcApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalcApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public decimal Post([FromBody] CalcData calcData)
        {
            switch(calcData.Operation)
            {
                case "plus":
                    return calcData.Operand1 + calcData.Operand2;
                case "minus":
                    return calcData.Operand1 - calcData.Operand2;
                case "multiply":
                    return calcData.Operand1 * calcData.Operand2;
                case "divide":
                    return calcData.Operand1 / calcData.Operand2;
                default:
                    throw new NotImplementedException("Unknown Action");
            }
        }

    }
}
