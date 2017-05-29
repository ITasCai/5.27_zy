using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = "abc";
            try
            {
                int str = Convert.ToInt32(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
