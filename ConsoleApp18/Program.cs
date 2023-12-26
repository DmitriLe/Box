using System;
using System.Security.Cryptography;

namespace kursach
{
    class proga
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать!\nВы рассчитываете предельно допустимую окружную силу Fпред, передаваемую зубчатым ремнём и сравниваете её с расчйтной силой F");
            double Fpred, h, y, da1, B, deltaT, b, e, z0, Li, m, z1, sigma, C1, N, n1, F, T1, tip, Yp, a1, z2, a, u;
            y = (50 * Math.PI) / 180;
            Console.WriteLine("Введите высоту зуба h:\n");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мощность N:\n");
            N = Convert.ToDouble(Console.ReadLine());
            /*Console.WriteLine("Введите частоту вращения меньшего шкива n1:\n");
            n1 = Convert.ToDouble(Console.ReadLine());
            m = 35 * Math.Cbrt(N / n1);*/
            Console.WriteLine("Выберите значение m: 2,3,4,5,7,10:\n");
            m = Convert.ToDouble(Console.ReadLine());
            if (m == 2)
            {
                Console.WriteLine("Выберите значение n1:\n  1) 500...3000, z1=12;\n  2) 3500...4500, z1=14;\n  3) 5000...6800, z1=16;\n  4) 7000...7500, z1=18;\n  Введите значение n1: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                if((500<=n1 && n1<=3000))
                {
                    z1 = 12;
                }
                else if ((3500 <= n1 && n1 <= 4500))
                {
                    z1 = 14;
                }
                else if ((5000 <= n1 && n1 <= 6800))
                {
                    z1 = 16;
                }
                else if ((7000 <= n1 && n1 <= 7500))
                {
                    z1 = 18;
                }
                else { z1 = 0; }
            }
            else if (m == 3)
            {
                Console.WriteLine("Выберите значение n1:\n  1) 500...1000, z1=12;\n  2) 1500...2000, z1=14;\n  3) 2500...3500, z1=16;\n  4) 4000...5000, z1=18;\n  Введите значение n1: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                if ((500 <= n1 && n1 <= 1000))
                {
                    z1 = 12;
                }
                else if ((1500 <= n1 && n1 <= 2000))
                {
                    z1 = 14;
                }
                else if ((2500 <= n1 && n1 <= 3500))
                {
                    z1 = 16;
                }
                else if ((4000 <= n1 && n1 <= 5000))
                {
                    z1 = 18;
                }
                else { z1 = 0; }
            }
            else if (m == 4)
            {
                Console.WriteLine("Выберите значение n1:\n  1) 500, z1=14;\n  2) 1000, z1=16;\n  3) 1500...2000, z1=18;\n  4) 2500...3500, z1=20;\n  Введите значение n1: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                if ((500 == n1))
                {
                    z1 = 14;
                }
                else if ((1000 == n1))
                {
                    z1 = 16;
                }
                else if ((1500 <= n1 && n1 <= 2000))
                {
                    z1 = 18;
                }
                else if ((2500 <= n1 && n1 <= 3500))
                {
                    z1 = 20;
                }
                else { z1 = 0; }
            }
            else if (m == 5)
            {
                Console.WriteLine("Выберите значение n1:\n  1) 500, z1=16;\n  2) 1000...1500, z1=18;\n  3) 2000...3000, z1=20;\n  4) 3500...4000, z1=22;\n  Введите значение n1: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                if ((500 == n1))
                {
                    z1 = 16;
                }
                else if ((1000 <= n1 && n1 <= 1500))
                {
                    z1 = 18;
                }
                else if ((2000 <= n1 && n1 <= 3000))
                {
                    z1 = 20;
                }
                else if ((3500 <= n1 && n1 <= 4000))
                {
                    z1 = 22;
                }
                else { z1 = 0; }
            }
            else if (m == 7)
            {
                Console.WriteLine("Выберите значение n1:\n  1) 500, z1=20;\n  2) 1000, z1=22;\n  3) 1500, z1=24;\n  4) 2000, z1=26;\n  Введите значение n1: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                if ((500 == n1))
                {
                    z1 = 20;
                }
                else if ((1000 == n1))
                {
                    z1 = 22;
                }
                else if ((1500 == n1))
                {
                    z1 = 24;
                }
                else if ((2000 == n1))
                {
                    z1 = 26;
                }
                else { z1 = 0; }
            }
            else if (m == 10 )
            {
                Console.WriteLine("Выберите значение n1:\n  1) 500, z1=20;\n  2) 1000, z1=22;\n  3) 1500, z1=24;\n  4) 2000, z1=26;\n  Введите значение n1: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                if ((500 == n1))
                {
                    z1 = 20;
                }
                else if ((1000 == n1))
                {
                    z1 = 22;
                }
                else if ((1500 == n1))
                {
                    z1 = 24;
                }
                else if ((2000 == n1))
                {
                    z1 = 26;
                }
                else { z1 = 0; }
            }
            else
            {
                Console.WriteLine("Вы ввели неверные значения!\n");
                z1 = 0;
                m = 0;
            }
            Console.WriteLine("Введите значение sigma:\n");
            sigma = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение T1:\n");
            T1 = Convert.ToDouble(Console.ReadLine());
            F = (2 * 1000 * T1) / (m * z1);

            if(m<4)
            {
                tip = 7;
            }
            else if (m==4)
            {
                Console.WriteLine("Введите значение типа троса(7 или 21):\n");
                tip = Convert.ToDouble(Console.ReadLine());
            }
            else if(m>4) 
            {
                tip = 21;
            }
            else
            {
                tip = 0;
            }

            if (m == 2 && tip == 7)
            {
                Li = 0.0018;
            }
            else if (m == 3 && tip == 7)
            {
                Li = 0.0025;
            }
            else if (m == 4 && tip == 7)
            {
                Li = 0.003;
            }
            else if (m == 4 && tip == 21)
            {
                Li = 0.0011;
            }
            else if (m == 5 && tip == 21)
            {
                Li = 0.0013;
            }
            else if (m == 7 && tip == 21)
            {
                Li = 0.0019;
            }
            else if (m == 10 && tip == 21)
            {
                Li = 0.0025;
            }
            else
            {
                Console.WriteLine("Вы ввели неверные значения:\n");
                Li = 0;
            }
            Console.WriteLine("Введите значение коэффициента ширины ремня Yp(от 6 до 9):\n");
            Yp = Convert.ToDouble(Console.ReadLine());
            b = Yp * m;
            C1 = (0.15 * F * Li * z1) / b;
            da1 = m * z1 - 2 * sigma + C1;
            da1=Math.Abs(da1);

            B = Math.Sqrt((4 * h) / (da1 * Math.Cos(y)));

            deltaT = (0.45 * F * Li) / b;

            e = 0.16;

            Console.WriteLine("Введите значение u(u>=1):\n");
            u = Convert.ToDouble(Console.ReadLine());
            z2 = z1 * u;
            Console.WriteLine("Введите значение расстояния между осями шкивов a:\n");
            a = Convert.ToDouble(Console.ReadLine());
            a1 = ((180 * Math.PI) / 180) - (m * (z2 - z1) / a) * ((57.3 * Math.PI) / 180);
            z0 = (z1 * a1) / ((360 * Math.PI) / 180);

            Fpred = ((h * Math.Tan(y) - 0.5 * da1 * (B - Math.Sin(B)) + deltaT) * b) / ((e / z0) + Li);

            Console.WriteLine($"Fпред = {Fpred}");
            Console.WriteLine($"F = {F}");
            Console.WriteLine($"Ответ: {Fpred} >= {F}");
        }

    }
}

