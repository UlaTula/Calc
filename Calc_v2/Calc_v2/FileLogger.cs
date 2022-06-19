using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_v2
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            var lines = new string[] { message };
            File.WriteAllLines("logs.txt", lines);
        }
    }
}
