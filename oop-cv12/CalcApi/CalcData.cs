using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcApi.Models
{
    public class CalcData
    {
        public string Operation { get; set; }
        public decimal Operand1 { get; set; }
        public decimal Operand2 { get; set; }
    }
}