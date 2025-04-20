using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPractice.Services
{
    public class TestService : ITestService
    {
        public string GetString()
        {
            return "안냐세요.";
        }
    }
}
