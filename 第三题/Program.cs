using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三题
{
    class Program
    {
        static void Main(string[] args)
        {

            int max = int.MaxValue; 
            try
            {
                unchecked {
                    int i = max * 2;
                    Console.WriteLine(i);
                }
                checked {
                    int j = max * 2;
                    Console.WriteLine(j);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
