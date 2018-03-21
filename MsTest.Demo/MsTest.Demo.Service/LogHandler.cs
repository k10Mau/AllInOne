using MsTest.Demo.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTest.Demo.Service
{
    public class LogHandler:ILogHandler
    {
        public void LogError(string errorMessage)
        {
            // log exception in DB
        }
    }
}
