using System;
using System.Collections.Generic;
//using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForKattis
{
     public class pos {
        public double x;
        public double y;
        public double angle;
        public pos(double x, double y, double angle)
        {
            this.x = x;
            this.y = y;
            this.angle = angle;
        }
    }

    class AllDifferentDirections
    {           
        static void Main(string[] args)
        {
            string input;
            Int32 n;
            while ((input = Console.ReadLine()) != null)
            {
                n = int.Parse(input);
                if (n == 0) break;
                List<pos> des = new List<pos>();
                for (int i = 0; i<n; i++)
                {
                    input = Console.ReadLine();
                    string[] coms = input.Split(' ');
                    pos getting = new pos(double.Parse(coms[0]),
                    double.Parse(coms[1]), double.Parse(coms[3]));
                    //Console.WriteLine("({0}, {1}) face {2}", getting.x, getting.y, getting.angle);
                    for (int r=4; r<coms.Length; r+=2)
                    {
                        if (coms[r] == "walk")
                        {
                            getting.x += double.Parse(coms[r + 1]) * Math.Cos(getting.angle * Math.PI / 180);
                            getting.y += double.Parse(coms[r + 1]) * Math.Sin(getting.angle * Math.PI / 180);

                        } else
                        {
                            getting.angle += double.Parse(coms[r+1]);
                        }
                    }
                    des.Add(getting);
                }              
                pos averdes = new pos(0,0,0);
                for (int i = 0; i<n; i++)
                {
                    averdes.x += des[i].x;
                    averdes.y += des[i].y;
                }
                averdes.x /= n;
                averdes.y /= n;
                List<double> length = new List<double>();
                for (int i = 0; i < n; i++)
                    length.Add(Math.Sqrt(Math.Pow(des[i].x - averdes.x, 2.0) + Math.Pow(des[i].y - averdes.y, 2.0)));
                length.Sort();
                Console.WriteLine("{0:F10} {1:F10} {2:F10}", averdes.x, averdes.y, length.Last());
            }

        }
    }
}
