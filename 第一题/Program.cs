﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一题
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("请输入一个整数：");
                byte b = Convert.ToByte(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
