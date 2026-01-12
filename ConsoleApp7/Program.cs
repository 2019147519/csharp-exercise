using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void UsePotion(string potionName="회복 포션", int healAmount=50)
        {
            Console.WriteLine($"💊 {potionName} 사용!");
            Console.WriteLine($"회복량: {healAmount} HP");
            Console.WriteLine();
        }
        static void SummonMonster(string monsterName="슬라임", int level=1, int quantity=1)
        {
            Console.WriteLine($"✨ {monsterName} 소환!");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"수량: {quantity}마리");
            Console.WriteLine();
        }
        static void Attack(ref int a)
        {
            Console.WriteLine("공격력 : " + a);
            a++;
        }
        static void OutFunc(out int b)
        {
            b = 10;
            Console.WriteLine("b : " + b);
            b++;
        }
        // 일반 변수 (값 타입) - 복사됨
        static void ModifyNumber(int number)
        {
            number = 999;
            Console.WriteLine($"   함수 내부: {number}");
        }
        // 배열 (참조 타입) - 원본 수정됨
        static void ModifyArray(int[] arr)
        {
            arr[0] = 999;
            Console.WriteLine($"   함수 내부: [{string.Join(", ", arr)}]");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== 아이템 사용 ===\n");
            UsePotion();
            UsePotion("고급 회복 포션", 100);
            Console.WriteLine("=== 소환 마법 ===\n");
            SummonMonster();
            SummonMonster("고블린", 5);
            SummonMonster("드래곤", 50, 3);

            int a = 10;
            Attack(ref a);
            Console.WriteLine("공격력 : " + a);
            int b;
            OutFunc(out b);
            Console.WriteLine("b : " + b);

            Console.WriteLine("=== 값 타입 (int) ===");
            int num = 100;
            Console.WriteLine($"변경 전: {num}");
            ModifyNumber(num);
            Console.WriteLine($"변경 후: {num}");  // 변경 안 됨!
            Console.WriteLine();
            
            // 참조 타입 테스트
            Console.WriteLine("=== 참조 타입 (배열) ===");
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"변경 전: [{string.Join(", ", numbers)}]");
            ModifyArray(numbers);
            Console.WriteLine($"변경 후: [{string.Join(", ", numbers)}]");  // 변경됨!

        }
    }
}