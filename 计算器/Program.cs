using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int sum;
            string s;
            Console.WriteLine("请输入所生成题目数量：");
            sum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sum;)
            {
                Random A = new Random(Guid.NewGuid().GetHashCode());
                double a = A.Next(0, 100);
                double b = A.Next(0, 100);
                double d = A.Next(0, 100);
                int c = A.Next(4);
                double he2 = 0;
                double he1 = 0;
                switch (c)
                {
                    case 0:
                        s = "+";
                        he2 = Yunsuan(a, b, s);
                        if ((int )he2 == he2 && he2 > 0)
                        {
                            he1 = Yunsuan(he2, d, s);
                            if ((int)he1 ==he1 && he1 > 0)
                            {
                                Console.WriteLine(a + "+" + b + "+" + d + "=" + he1);
                                i++;

                            }

                        }
                        break;
                    case 1:
                        s = "-";
                        he2 = Yunsuan(a, b, s);
                        if (he2 % 2 == 0 && he2 > 0)
                        {
                            he1 = Yunsuan(he2, d, s);
                            if (he1 % 2 == 0 && he1 > 0)
                            {
                                Console.WriteLine(a + "-" + b + "-" + d + "=" + he1);
                                i++;

                            }

                        }
                        break;
                    case 2:
                        s = "*";
                        he2 = Yunsuan(a, b, s);
                        if (he2 % 2 == 0 && he2 > 0)
                        {
                            he1 = Yunsuan(he2, d, s);
                            if (he1 % 2 == 0 && he1 > 0)
                            {
                                Console.WriteLine(a + "*" + b + "*" + d + "=" + he1);
                                i++;

                            }

                        }
                        break;
                    case 3:
                        s = "/";
                        he2 = Yunsuan(a, b, s);
                        if (he2 % 2 == 0 && he2 > 0)
                        {
                            he1 = Yunsuan(he2, d, s);
                            if (he1 % 2 == 0 && he1 > 0)
                            {
                                Console.WriteLine(a + "/" + b + "/" + d + "=" + he1);
                                i++;

                            }

                        }
                        break;
                }


            }
            Console.ReadKey();
        }

        public static double Yunsuan(double a1, double a2, string sign)
        {
            double sum = 0;
            switch (sign)
            {
                case "-":
                    sum = a1 - a2;
                    break;
                case "+":
                    sum = a1 + a2;
                    break;
                case "*":
                    sum = a1 * a2;
                    break;
                case "/":
                    sum = a1 / a2;
                    break;
            }
            return sum;
        }
    }

}
