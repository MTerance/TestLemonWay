using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestLemonWay.Logic;

namespace TestLemonWay.Controllers
{
    public class FibonacciController : ControllerBase
    {

        private readonly ILogger<FibonacciController> _logger;


        public FibonacciController(ILogger<FibonacciController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Fibonacci(int n)
        {
            if (n < 1 || n > 100)
                return -1;
            FibonacciLogic logic = new FibonacciLogic();

            return logic.ComputeFibonacci(n);
        }


        [HttpGet]
        public string XmlToJson(string xml)
        {

            return "Bad Xml format";
        }

    }
}