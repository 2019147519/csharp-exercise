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

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("캐릭터 이름을 입력하세요: ");
            // string name = Console.ReadLine();
            // Console.WriteLine($"환영합니다! {name}님!");
            // Console.Write("시작 레벨을 입력하세요: ");
            // int level = int.Parse(Console.ReadLine());
            // Console.WriteLine($"{name}님의 시작 레벨은 {level}입니다.");

            // int killCount = 0;
            // Console.WriteLine("=== 몬스터 처치 ===");
            // Console.WriteLine($"고블린 처치! (킬 카운트: {++killCount})");
            // Console.WriteLine($"오크 처치! (킬 카운트: {++killCount})");
            // Console.WriteLine($"드래곤 처치! (킬 카운트: {++killCount})");
            // Console.WriteLine($"총 처치 수: {killCount}마리");

            // int bulletLeft = 30;
            // Console.WriteLine("\n=== 사격 ===");
            // Console.WriteLine($"남은 탄약: {bulletLeft}");
            // Console.WriteLine($"발사! 남은 탄약: {--bulletLeft}");
            // Console.WriteLine($"발사! 남은 탄약: {--bulletLeft}");
            // Console.WriteLine($"발사! 남은 탄약: {--bulletLeft}");

            // int countDown = 3;
            // Console.WriteLine("\n=== 카운트다운 ===");
            // Console.WriteLine($"{countDown--}");
            // Console.WriteLine($"{countDown--}");
            // Console.WriteLine($"{countDown--}");
            // Console.WriteLine("발사!");

            // int x = 5; // 0101
            // int y = 3; // 0011

            // string binary = Convert.ToString(x & y, 2);

            // Console.WriteLine($"8비트 : {binary.PadLeft(8,'0')}");

            // binary = Convert.ToString(x | y, 2);

            // Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            // binary = Convert.ToString(x ^ y, 2);
            // Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            // binary = Convert.ToString(~x, 2);
            // Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            // 문제1
            int currentHP = 80;
            int maxHP = 100;
            Console.WriteLine($"초기 체력: {currentHP}/{maxHP}");            
            currentHP -= 25;
            Console.WriteLine($"데미지 -25: {currentHP}/{maxHP}");
            currentHP += 30;
            Console.WriteLine($"회복 +30: {currentHP}/{maxHP}");
            currentHP -= 5;
            Console.WriteLine($"독 데미지 -5: {currentHP}/{maxHP}");
            // 문제2
            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;
            Console.WriteLine($"\n처치한 몬스터: {monstersKilled}마리");
            Console.WriteLine($"획득 경험치: {expPerMonster * monstersKilled}");
            Console.WriteLine($"레벨업까지 필요: {expForLevelUp - (expPerMonster * monstersKilled)}");
            // 문제3
            int totalGold = 1234;
            int partyMembers = 5;
            Console.WriteLine($"\n총 골드: {totalGold}");
            Console.WriteLine($"파티원: {partyMembers}명");
            Console.WriteLine($"1인당 골드: {totalGold / partyMembers}");
            Console.WriteLine($"남은 골드: {totalGold % partyMembers}");
            // 문제4
            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            currentHP = 60;
            maxHP = 100;
            Console.WriteLine($"\n=== 던전 입장 조건 ===");
            Console.WriteLine($"레벨 조건 (30 이상): {playerLevel >= requiredLevel}");
            Console.WriteLine($"열쇠 보유: {hasKey}");
            Console.WriteLine($"체력 조건 (50% 이상): {currentHP >= maxHP / 2}");
            Console.WriteLine($"입장 가능: {playerLevel >= requiredLevel && hasKey && currentHP >= maxHP / 2}");
            // 문제5
            int originalPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;
            int finalPrice = originalPrice;
            Console.WriteLine($"\n원가: {originalPrice}골드");
            if (isVIP)
            {
                finalPrice = finalPrice - (finalPrice * 20 / 100);
                Console.WriteLine($"VIP 할인 (20%): {finalPrice}골드");
            }
            if (hasCoupon)
            {
                finalPrice -= 500;
                Console.WriteLine($"쿠폰 할인 (-500): {finalPrice}골드");
            }
            Console.WriteLine($"최종 가격: {finalPrice}골드");
        }
    }
}
