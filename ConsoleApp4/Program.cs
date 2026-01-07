using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("온도: ");
            string input = Console.ReadLine();
            int temperature = int.Parse(input);
            Console.WriteLine("현재 온도: " + temperature + "°C");
            if (temperature >= 30)
            {
                Console.WriteLine("매우 더워요! 반팔과 반바지를 입으세요.");
            }
            else if (temperature >= 20)
            {
                Console.WriteLine("적당해요! 긴판 티셔츠를 입으세요.");
            }
            else if (temperature >= 10)
            {
                Console.WriteLine("쌀쌀해요! 가디건이나 자켓을 챙기세요.");
            }
            else if (temperature >= 0)
            {
                Console.WriteLine("추워요! 코트를 입으세요.");
            }
            else
            {
                Console.WriteLine("매우 추워요! 패딩과 목도리가 필요해요.");
            }
        }
    }
}
