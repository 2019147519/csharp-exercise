using System;
using System.Text;


namespace ConsoleApp8
{
    internal class Program
    {
        static double FindAvg(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }
        static string GetGrade(int score)
        {
            if (score >= 90)
                return "A";
            else if (score >= 70)
                return "B";
            else if (score >= 50)
                return "C";
            else if (score >= 30)
                return "D";
            else
                return "F";
        }
        static bool IsPrime(int a)
        {
            if (a <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
        static void GainExp(int currentExp, int gainExp, int maxExp, out bool levelUP, out int newExp)
        {
            currentExp += gainExp;
            levelUP = false;
            newExp = currentExp;
            if (currentExp >= maxExp)
            {
                levelUP = true;
                newExp = currentExp - maxExp;
            }
        }
        static bool Upgrade(int level = 1)
        {
            Random rand = new Random();
            int a = rand.Next(1,101);
            if (a + level * 3 > 80)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== 문제 1: 평균 계산 함수 ==="); // 정수 배열을 받아 평균을 반환하는 함수를 만드세요.
            int[] scores = {39, 72, 56, 14, 89, 23, 67, 45, 90, 11};
            double average = FindAvg(scores);
            Console.WriteLine($"점수: {string.Join(", ", scores)}");
            Console.WriteLine("평균: " + average);
            Console.WriteLine();

            Console.WriteLine("=== 문제 2: 등급 판별 함수 ==="); // 점수를 받아 A, B, C, D, F 등급을 반환하는 함수를 만드세요.
            foreach (int score in scores)
            {
                Console.WriteLine($"점수 {score}: {GetGrade(score)}");
            }
            Console.WriteLine();

            Console.WriteLine("=== 문제 3: 소수 판별 함수 ==="); // 숫자를 받아 소수인지 판별하는 함수를 만드세요.
            Console.WriteLine("1부터 29까지의 소수:");
            for (int i = 1; i < 30; i++)
            {
                if (IsPrime(i))
                    Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("=== 문제 4: 경험치 시스템 ==="); // 현재 경험치와 획득 경험치를 받아 레벨업 여부와 새 경험치를 반환하는 함수를 만드세요. (out 사용)
            int currentExp = 300;
            int gainExp = 250;
            int maxExp = 500;
            bool isLevelUp;
            Console.WriteLine($"현재 경험치: {currentExp}");
            Console.WriteLine($"얻은 경험치: {gainExp}");
            Console.WriteLine($"최대 경험치: {maxExp}");
            GainExp(currentExp, gainExp, maxExp, out isLevelUp, out currentExp);
            Console.WriteLine($"레벨 업 여부: {isLevelUp}");
            Console.WriteLine($"현재 경험치: {currentExp}");
            Console.WriteLine();
            Console.WriteLine($"현재 경험치: {currentExp}");
            Console.WriteLine($"얻은 경험치: 300");
            Console.WriteLine($"최대 경험치: {maxExp}");
            GainExp(currentExp, 300, maxExp, out isLevelUp, out currentExp);
            Console.WriteLine($"레벨 업 여부: {isLevelUp}");
            Console.WriteLine($"현재 경험치: {currentExp}");
            Console.WriteLine();

            Console.WriteLine("=== 문제 5: 아이템 강화 시스템 ==="); // 강화 레벨에 따라 성공 확률이 달라지는 아이템 강화 시스템을 함수로 구현하세요.
            int level = 1;
            Console.WriteLine("현재 강화 레벨: " + level);
            for (int i = 0; i < 20; i++)
            {
                if (Upgrade(level))
                    Console.WriteLine("강화 성공! ✅");
                else
                    Console.WriteLine("강화 실패! ❌");
            }
            level = 10;
            Console.WriteLine("현재 강화 레벨: " + level);
            for (int i = 0; i < 20; i++)
            {
                if (Upgrade(level))
                    Console.WriteLine("강화 성공! ✅");
                else
                    Console.WriteLine("강화 실패! ❌");
            }

        }
    }
}