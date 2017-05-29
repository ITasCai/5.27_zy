using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四题
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("-----------------------欢迎来到简易电话本系统--------------------------");

                Console.WriteLine("  A:添加联系人   B.删除联系人  C.修改联系人  S：查看联系人    Q:退出系统");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("输入您要进行的操作：");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

                switch (ch)
                {
                    case 'A':
                        //添加
                     
                        break;
                    case 'S':
                        //查询
                      
                        break;
                    //退出
                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("输出有误，请重新输入！");
                        break;
                }
            }

        }
    }
}
