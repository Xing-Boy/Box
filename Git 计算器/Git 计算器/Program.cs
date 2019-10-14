using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Caculate cat = new Caculate();
            cat.GetResualt();

            Console.ReadLine();
        }
    }
    class Caculate
    {
        int number1, number2;
        string num1, num2;
        string fun;
        double end = 0;
        string send;
        int CheckNum(string num)
        {
            try
            {
                int i = int.Parse(num);
                return i;
            }
            catch (Exception e)
            {
                Console.WriteLine("输入有误请重新输入");
                string str = Console.ReadLine();

                return CheckNum(str);
            }
        }
        public void GetResualt()
        {
            Input();//输入
            string yun = "";
            string t = "";
            switch (fun)
            {
                case "1":
                    Console.WriteLine("请选择模式：1(字符串相加)  2(数字相加)");
                    t = Console.ReadLine();
                    if (t == "1")
                    {
                        send = num1 + num2;
                        yun = "+";
                        break;
                    }
                    else
                    {
                        end = number1 + number2;
                        yun = "+";
                        break;
                    }
                    
                case "2":
                    end = number1 - number2;
                    yun = "-";
                    break;
                case "3":
                    end = number1 * number2;
                    yun = "x";
                    break;
                case "4":
                    end = (double)number1 / number2;
                    yun = "÷";
                    break;
                default:
                    Console.WriteLine("请重新选择：");
                    string str = Console.ReadLine();
                    GetResualt();
                    return;
            }
            if (t == "1")
            {
                Console.WriteLine("'{0}'{3}'{1}'='{2}'", number1, number2, send, yun);
            }
            else
                Console.WriteLine("{0}{3}{1}={2}", number1, number2, end, yun);



        }
        void Input()
        {
            Console.WriteLine("请输入第一个数：");
            num1 = Console.ReadLine();
            number1 = CheckNum(num1);
            Console.WriteLine("请输入第二个数：");
            num2 = Console.ReadLine();
            number2 = CheckNum(num2);
            Console.WriteLine("请选择运算符：1.+  2.-  3.x  4.÷：");
            fun = Console.ReadLine();
        }
    }
}
