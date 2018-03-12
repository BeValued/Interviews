using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interviews.Models
{
    public class ExampleClass : IExampleClass
    {
        public bool ExampleMethod(string input)
        {
            //TODO: This method requires unit tests
            return input.Length <= 5;
        }
    }
}