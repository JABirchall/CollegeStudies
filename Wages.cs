using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Wage Calculator";

            Log("Enter employee name: ");
            Container.Name = Read();

            Log("Enter employee Natinal Insurance Number: ");
            Container.InsuranceNum = Read();

            Log("Enter number of hours worked: ");
            Container.Hours = readInt();

            logL("Select the employee pay rate.");
            logL("1. Administrators (£8.07)");
            logL("2. Programmer (£12.03)");
            logL("3. Project leader (£24.54)");
            logL("4. Custom rate");
            string tempRate = Read();

            switch (tempRate)
            {
                case "1":
                    Container.Rate = 8.07;
                    break;
                case "2":
                    Container.Rate = 12.03;
                    break;
                case "3":
                    Container.Rate = 24.54;
                    break;
                case "4":
                    Log("Please enter custom rate: ");
                    Container.Rate = readDouble();
                    break;
            }

            if (Container.Hours >= 41) Container.Overtime = true;
            else Container.Overtime = false;

            if (Container.Overtime == true && Container.Hours >= 51) Container.doubleTime = true;
            else Container.doubleTime = false;

            hourPay();
            weeklyTax();
            calculateIT();
            logL("Net Total: "+netIncome().ToString());
            logL("Gross Total: "+Container.pay.ToString());

            logL("Do you want to save your results(y/yes/n/no)?");
            string tempAnswer = Read();

            if (string.Equals(tempAnswer, "y", StringComparison.CurrentCultureIgnoreCase) || string.Equals(tempAnswer, "yes", StringComparison.CurrentCultureIgnoreCase))
            {
                var Files = File.Create(Directory.GetCurrentDirectory()+"/pay.txt");

            }


            Read();
        }

        static double hourPay()
        {
            Container.pay = (Container.pay != 0) ? Container.pay : 0;

            if (Container.doubleTime == true)
            {
                Container.tempHours = Container.Hours - 50;
                Container.pay = (Container.tempHours * (Container.Rate * 2.0));
            }
            if (Container.Overtime == true)
            {
                Container.tempHours = (Container.Hours - 40) - Container.tempHours;
                Container.pay += (Container.tempHours * (Container.Rate * 1.5));
            }
            Container.pay += (Container.Hours - Container.tempHours) * Container.Rate;
            return Container.pay;
        }

        static double Insurance() 
        {
            Container.insurance = (11 / 100) * Container.pay;
            return Container.insurance;
        }

        static double weeklyTax()
        {
            return 7470 / 52;
        }

        static void calculateTax()
        {
            double tempTax = Container.insurance - weeklyTax();
            Container.Taxable = Container.pay - tempTax;
            //return Container.Taxable;

        }
        static void calculateIT()
        {
            double tempTax = 25 / 100;
            Container.incomeTax = Container.Taxable * tempTax;
            //return Container.incomeTax;

        }

        static double netIncome() 
        {
            Container.net = Container.pay - (Container.incomeTax + Container.insurance);
            return Container.net;
        } 

        static void logL(string text) { Console.WriteLine(text); }
        static void Log(string text) { Console.Write(text); }
        static string Read() { return Console.ReadLine(); }
        static int readInt() { return Convert.ToInt32(Read()); }
        static double readDouble() { return Convert.ToDouble(Read()); }
    }

    class Container
    {
        static public string Name { get; set; }
        static public string InsuranceNum { get; set; }
        static public int Hours { get; set; }
        static public double Rate { get; set; }
        static public bool Overtime { get; set; }
        static public bool doubleTime { get; set; }
        static public double pay { get; set; }
        static public double insurance { get; set; }
        static public double Taxable { get; set; }
        static public double incomeTax { get; set; }
        static public double net { get; set; }
        static public int tempHours { get; set; }
    }
}
