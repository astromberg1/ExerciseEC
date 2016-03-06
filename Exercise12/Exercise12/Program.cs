using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var application = new Logapplication(logger);
            application.Run();


        }
    }
}
