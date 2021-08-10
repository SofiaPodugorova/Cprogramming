using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            PointStruct pointOne = new PointStruct();
            pointOne.X = 1000000;
            pointOne.Y = 5000000;
            PointStruct pointTwo = new PointStruct();
            pointTwo.X = 11111111;
            pointTwo.Y = 11548956;




            var point1 = new PointClass() { X = 42, Y = 42 };
            var point2 = new PointClass() { X = 7, Y = 7 };


            PointStruct point3 = new PointStruct();
            point3.X = 85468;
            point3.Y = 845696;
            PointStruct point4 = new PointStruct();
            point4.X = 652356;
            point4.Y = 895656;


            PointStruct point5 = new PointStruct();
            point5.X = 85468;
            point5.Y = 845696;
            PointStruct point6 = new PointStruct();
            point6.X = 652356;
            point6.Y = 895656;

        }


        public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        public static float PointClassFloat(PointClass point1, PointClass point2)
        {
            float x2 = point1.X - point2.X;
            float y2 = point1.Y - point2.Y;
            return (float)Math.Sqrt((x2 * x2) + (y2 * y2));
        }

        public static float PointDistanceFloat(PointStruct point3, PointStruct point4)
        {
            double x = point3.X - point4.X;
            double y = point3.Y - point4.Y;
            return (float)Math.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceFloatWithoutSqrt(PointStruct point5, PointStruct point6)
        {
            double x = point5.X - point6.X;
            double y = point5.Y - point6.Y;
            return ((float)((x * x) + (y * y)));
        }
    }
}
//У меня не выводится консоль потому я не могу посчитать время, хотя показывает что нет никаких ошибок. Извините.