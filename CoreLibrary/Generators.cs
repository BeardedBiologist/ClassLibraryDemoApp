using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class Generators
    {
        public string WelcomeMesage(string prefix, string lastname)
        {
            return $"Welcome to our demo application {prefix} {lastname}";
        }
        public string FarewellMesage(string prefix, string lastname)
        {
            return $"I hope you enjoyed your time with us {prefix} {lastname}. Please come back soon";
        }
    }
}
