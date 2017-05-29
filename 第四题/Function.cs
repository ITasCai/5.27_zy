using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第四题
{
    /// <summary>
    /// 电话本的功能类
    /// </summary>
    class Function
    {
       public static Hashtable ht = new Hashtable();
        
        /// <summary>
        /// 添加
        /// </summary>
        public static void Add() {
            Console.WriteLine("请输入您的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入您的电话号码");
            string phone = Console.ReadLine();
            ht.Add(name,phone);
            Console.WriteLine("添加成功!");
        }

        /// <summary>
        /// 
        /// 删除
        /// </summary>
      public static void Remove() {
            Console.WriteLine("请输入你要删除的姓名");
            bool flag = false;
            string name = Console.ReadLine();
            if (name.Equals(ht.Keys))
            {
                flag = true;

                Console.WriteLine("");
                if ()
                {

                }
            }
            if (flag)
            {
                Console.WriteLine("没有此联系人");
            }
        }
    }
}  
