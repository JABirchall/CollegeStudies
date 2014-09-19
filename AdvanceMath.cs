using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.Title = "Advanced math class";

            double QOne = (2354.76 * 1564.22);
            Console.WriteLine("Question One: " + QOne);

            double QTwo = (23.56 / 7.3);
            Console.WriteLine("Question Two: " + QTwo);

            double QThree = (25.0 * (16.0 / 100.0));
            Console.WriteLine("Question Three: " + QThree);

            double QFour = SunDistance();
            Console.WriteLine("Question Four: " + QFour);

            double QFive = MoonSpeed();
            Console.WriteLine("Question Five: " + QFive);

            double QSix = (5 * 52);
            Console.WriteLine("Question Six: " + QSix);

            double QSeven = ((7 + 3) + (3 + 7));
            Console.WriteLine("Question Seven: " + QSeven);

            double QEight = (186000.0 * 23.34329);
            Console.WriteLine("Question Eight: " + QEight);

            double QNine = (9 / 3);
            Console.WriteLine("Question Nine: " + QNine);

            double QTen = RoadRunner();
            Console.WriteLine("Question Ten: " + QTen);

            double QEleven = (115.87 * 0.621371192);
            Console.WriteLine("Question Eleven: " + QEleven);

            double QTwelve = ((23.45 * 11.23) * 9.11);
            Console.WriteLine("Question Twelve: " + QTwelve);

            double QThirteen = (12 / 2);
            Console.WriteLine("Question Thirteen: " + QThirteen);

            double QFourteen = ((65 / 5) * 3);
            Console.WriteLine("Question Fourteen: " + QFourteen);

            double Qfifteen = Math.Sqrt(Math.Sqrt(6.23) - Math.Sqrt(1.23));
            Qfifteen = Math.Sqrt(Qfifteen);
            Console.WriteLine("Question Fifteen: " + Qfifteen);

            double QSixteen = ((28.4 / 100) * 36);
            Console.WriteLine("Question Sixteen: " + QSixteen);

            double QSeventeen = ((130.0 + 104.0 + 155.0 + 160.0 + 135.0 + 108.0) / 6);
            Console.WriteLine("Question Seventeen: " + QSeventeen);

            double QEighteen = ((4.0*4.43)+(2.0*3.976));
            Console.WriteLine("Question Eighteen: " + QEighteen);

            double Qnineteen = 0;
            Console.WriteLine("Question Nineteen: " + Qnineteen);

            double QTweenty = 0;
            Console.WriteLine("Question Tweeny: " + QTweenty);



            Console.ReadLine();

        }


        static int SunDistance()
        {
            int SunDistance = 149600000;
            int EarthSpeed = 162;
            int Days;

            Days = (SunDistance / (EarthSpeed * 24));
            return Days;

        }

        static double MoonSpeed()
        {
            double MoonSpeed;
            double MoonTime = 37.5;
            double MoonDistance = 384400.0;

            MoonSpeed = (MoonDistance / MoonTime);
            return MoonSpeed;
        }

        static double RoadRunner()
        {
            double RoadRunnerSpeed = (72.579 / 60);
            double RoadRunnerTime = 311.0;
            double RoadRunnerDistance = (RoadRunnerSpeed * RoadRunnerTime);
            return RoadRunnerDistance;
        }

    }
}
