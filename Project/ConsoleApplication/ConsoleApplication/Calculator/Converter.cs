using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Calculator
{
    public class Converter
    {
        public float Convert(string input)
        {
            var output = 0f;
            float.TryParse(input, out output);
            return output;
        }

        public string Convert(float input)
        {
            return input.ToString("{0:N2}");
        }
    }
}
