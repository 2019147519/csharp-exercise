using System;

namespace ConsoleApp13
{
    interface IAttackable
    {
        void Attack(string target);
    }
    //추상클래스 상속을 받고있는친구는 추상메서드를 상속받아서 꼭 구현해야한다.
    public abstract class Character
    {
        public string name;
        public int hp;
        public int maxHp;
        public int speed;

        public Character(string name, int hp, int maxHp, int speed)
        {
            this.name = name;
            this.hp = hp;
            this.maxHp = maxHp;
            this.speed = speed;
        }
        // 추상 메서드 (구현 안 됨 - 자식이 반드시 구현)
        public abstract void ShowInfo();

    }

    public class Warrior : Character
    {   
        public int atk;
        public int def;

        public Warrior(string name, int hp, int maxHp, int speed, int atk, int def) : base(name, hp, maxHp, speed)
        {
            this.atk = atk;
            this.def = def;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[전사] {name}");
            Console.WriteLine($"HP: {hp}/{maxHp}");
            Console.WriteLine($"공격력: {atk}");
            Console.WriteLine($"방어력: {def}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
        }
    }

    public class Mage : Character, IAttackable
    {
        public int ap;
        public int mana;

        public Mage(string name, int hp, int maxHp, int speed, int ap, int mana) : base(name, hp, maxHp, speed)
        {
            this.ap = ap;
            this.mana = mana;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[마법사] {name}");
            Console.WriteLine($"HP: {hp}/{maxHp}");
            Console.WriteLine($"마력: {ap}");
            Console.WriteLine($"마나: {mana}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
        }

        public void Attack(string target)
        {
            Console.WriteLine($"{name}이 {target}에게 공격마법 발동!");
        }

    }

    public class Archer : Character
    {
        public int atk;
        public int arrow;
        public Archer(string name, int hp, int maxHp, int speed, int atk, int arrow) : base(name, hp, maxHp, speed)
        {
            this.atk = atk;
            this.arrow = arrow;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[궁수] {name}");
            Console.WriteLine($"HP: {hp}/{maxHp}");
            Console.WriteLine($"공격력: {atk}");
            Console.WriteLine($"화살: {arrow}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character[] ch = new Character[3]; //배열준비

            Console.WriteLine("=== 유닛 생성 ===");
            ch[0] = new Warrior("홍길동", 200, 200, 5, 80, 50);
            ch[1] = new Mage("김마법", 120, 120, 4, 150, 120);
            ch[2] = new Archer("이궁수", 150, 150, 6, 100, 50);


            for (int i = 0; i < ch.Length; i++)
            {
                ch[i].ShowInfo();
            }

            ((IAttackable)ch[1]).Attack("오크");
        }
    }
}