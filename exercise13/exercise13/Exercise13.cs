using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise13
{

    class Exercise13
    {
       static void Main()
        {
            /* 1.Create a new Console Project.
            2.Ask the user for their name, as well as the year, month and day they were born.
            3.Calculate the user’s current age.
            4.Calculate on what exact day the user will turn 100.
            5.Calculate how long it is until the user’s next birthday.
            6.Output the data in a format similar to the following: */
            string datum = "19800223";
            int intdatum = int.Parse(datum);
            int year = intdatum / 10000;
            int month = (intdatum - year * 10000) / 100;
            int day = (intdatum - year * 10000-month*100);

            TimeSpan interval = new TimeSpan(3, 16, 42, 45, 750);

            Console.WriteLine("Value of TimeSpan: {0}", interval);

            Console.WriteLine("{0:N5} days, as follows:", interval.TotalDays);
            Console.WriteLine("   Days:         {0,3}", interval.Days);
            Console.WriteLine("   Hours:        {0,3}", interval.Hours);
            Console.WriteLine("   Minutes:      {0,3}", interval.Minutes);
            Console.WriteLine("   Seconds:      {0,3}", interval.Seconds);
            Console.WriteLine("   Milliseconds: {0,3}", interval.Milliseconds);
       


        var dt3 = new DateTime(year,month,day);
            Console.WriteLine(dt3.ToString());


            Console.WriteLine("Write your name");
            String Name = Console.ReadLine();
            Console.WriteLine("Write your birth year YYYY");
            String YYYY = Console.ReadLine();
            Console.WriteLine("Write your birth month(number) MM");
            String MM = Console.ReadLine();
            Console.WriteLine("Write your birth day(number) DD");
            String DD = Console.ReadLine();
            DateTime date = new DateTime(int.Parse(YYYY), int.Parse(MM), int.Parse(DD));
            DateTime date2 = new DateTime(date.Year+1, date.Month, date.Day);
            DateTime Dagensdatum = DateTime.Now;
           
            DateTime dt1 = new DateTime(Dagensdatum.Year-1, date.Month, date.Day);
            DateTime dt2 = new DateTime(Dagensdatum.Year - 1, date.Month, date.Day);

            TimeSpan age = (DateTime.Now - date);

           

            int ageyr = 0;

            ageyr = (int) (age.TotalDays / 365.25f); // enkelt beräkning av ålder i år Totaldays tar även hänsyn till dygnstiden


            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            Console.WriteLine("Vecknummer "+ (cal.GetWeekOfYear(date, dfi.CalendarWeekRule, dfi.FirstDayOfWeek)));



            int antaldgr=0;
            int dgrtillfolsedag = 0;
            DateTime dt = new DateTime(Dagensdatum.Year, date.Month, date.Day); // Din födelsdag i år;
            if (Dagensdatum < dt)
            {
                ageyr = Dagensdatum.Year - date.Year-1;
                antaldgr = (Dagensdatum - dt1).Days;
                dgrtillfolsedag = (dt-Dagensdatum).Days;
                
            }
            else
            {
                ageyr = Dagensdatum.Year - date.Year;
                antaldgr = (Dagensdatum - dt).Days;
                if (!(Dagensdatum == dt))
                    dgrtillfolsedag = (dt.AddYears(1) - dt).Days;
                else
                    dgrtillfolsedag=0;


            }

          
            DateTime datax100 = date.AddYears(100); //snabbt sätt att få fram datum när du fyller 100 år



            Console.WriteLine();
            Console.WriteLine("Your age:" + ageyr + " Years " + antaldgr  + " dagar");
            Console.WriteLine();
            Console.WriteLine("Hello, " + Name + " .You are " + ageyr + " years old, and will turn  " + (ageyr + 1) + "  in  " + dgrtillfolsedag+ " days");


            
            Console.WriteLine("Your 100th birthday will be on a " + datax100.DayOfWeek);
            Console.ReadKey();




            //stretch övningar


           







        }
    }
}
