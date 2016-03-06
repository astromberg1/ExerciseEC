using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Logapplication
    {
        private ILogger _logger;
        public Logapplication(ILogger ilogger)
        {
            this._logger = ilogger;
        }

        public void Run()
        {

            // 1) Add message to log 
            //2) Print log
            //Choice:
            bool run = true;
            while (run)
            {
                // show menu
                Console.Clear();
                Console.WriteLine("1) Add message to log ");
                Console.WriteLine("2) Print log ");
                Console.WriteLine("3) Exit ");
                Console.WriteLine(" Choice:");
                char input = Console.ReadLine().ToCharArray(0, 1)[0];

                switch (input)
                {
                    case '1':

                        Console.WriteLine("Type message to log");
                        string loginput = Console.ReadLine();
                        _logger.Log(loginput);
                        break;

                    case '2':

                        //  When selecting 2 in the menu, use the LogPosts property to get a list of all values and print them to the screen. 
                        Console.WriteLine("Choice 2, printing");

                        foreach (var ls in _logger.LogPosts)
                        {
                            Console.WriteLine(ls);
                            
                        }
                        Console.ReadKey();

                        break;
                    case '3':
                        run = false;
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Wrong choice, try again");
                        break;

                }



            }

        }
    }
           
        

    
}
