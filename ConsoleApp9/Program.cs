using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleApp9
{
    //캐릭터 클래스정의
    class Character
    {
        // 필드 (Field): 클래스의 데이터
        private string name;
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;

        // 생성자 (Constructor)
        public Character(string _name, int _level, int _hp, int _maxHP, int _mp, int _maxMP)
        {
            name = _name;
            level = _level;
            hp = _hp;
            maxHP = _maxHP;
            mp = _mp;
            maxMP = _maxMP;
        }

        // 메서드 (Method): 클래스의 기능
        public void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"MP: {mp}/{maxMP}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        }


        public void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;

            Console.WriteLine($"⚔️ {name}이(가) {damage} 데미지를 받았습니다!");
            Console.WriteLine($"   남은 HP: {hp}/{maxHP}");
        }


        public void Heal(int amount)
        {
            hp += amount;
            if (hp > maxHP) hp = maxHP;

            Console.WriteLine($"💚 {name}의 HP가 {amount} 회복되었습니다!");
            Console.WriteLine($"   현재 HP: {hp}/{maxHP}");
        }

    }

    class Monster
    {
        public string name;
        public int level;
        public int hp;
        public int attack;
        public int defense;
        public int expReward;

         // 기본 생성자
        public Monster()
        {
            name = "슬라임";
            level = 1;
            hp = 50;
            attack = 10;
            defense = 5;
            expReward = 10;
        }
        
        // 매개변수가 있는 생성자
        public Monster(string monsterName, int monsterLevel)
        {
            name = monsterName;
            level = monsterLevel;
            hp = 50 * level;
            attack = 10 * level;
            defense = 5 * level;
            expReward = 10 * level;
        }
          // 정보 출력
        public void ShowStats()
        {
            Console.WriteLine($"👾 {name} (Lv.{level})");
            Console.WriteLine($"   HP: {hp}");
            Console.WriteLine($"   공격력: {attack}");
            Console.WriteLine($"   방어력: {defense}");
            Console.WriteLine($"   경험치: {expReward}");
        }


    }

    class Student
    {
        private string name;
        private int score;

        public string Name
        {
            get { return name; } private set { name = value; }
        }
        public int Score
        {
            get { return score; }
            set
            {
                if (value > 100) score = 100;
                else if (value < 0) score = 0;
                else score = value;
            }
        }
        public char Grade
        {
            get
            {
                if (score >= 90) return 'A';
                else if (score >= 80) return 'B';
                else if (score >= 70) return 'C';
                else if (score >= 60) return 'D';
                else return 'F';
            }
            private set;
        }

        public Student(string name)
        {
            this.name = name;
        }

        public void ShowInfo()
    {
        Console.WriteLine($"━━━━━━━━━━━━━━━━");
        Console.WriteLine($"이름: {Name}");
        Console.WriteLine($"점수: {Score}점");
        Console.WriteLine($"등급: {Grade}");
        Console.WriteLine($"━━━━━━━━━━━━━━━━");
    }

        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //절차 지향 프로그래밍 vs 객체지향방식

            // 객체 생성
            Character player1 = new Character("홍길동", 10, 150, 150, 80, 80);

            // 메서드 호출 출력 
            player1.ShowInfo();

            //데미지 50
            player1.TakeDamage(50);

            //힐 30
            player1.Heal(30);

            //새로운객체 생성해서 임의값 입력후 출력
            Character player2 = new Character("김영희", 15, 200, 200, 120, 120);

            player2.ShowInfo();

            Monster slime = new Monster();
            slime.ShowStats();

            Monster goblin = new Monster("고블린", 5);
            goblin.ShowStats();

            Console.WriteLine("=== 필드 몬스터 ===\n");
            Monster[] monsters = new Monster[3];
            monsters[0] = new Monster("늑대", 3);
            monsters[1] = new Monster("오크", 7);
            monsters[2] = new Monster("트롤", 10);

            for(int i =0; i<monsters.Length; i++)
            {
                monsters[i].ShowStats();
                Console.WriteLine();
            }


            Student student = new Student("홍길동");
        
            student.Score = 95;
            student.ShowInfo();
            
            Console.WriteLine();
            
            student.Score = 75;
            student.ShowInfo();
            
            Console.WriteLine();
            
            // 잘못된 값 입력 시도
            student.Score = 150;  // 100으로 제한되어야 함
            student.Score = -10;  // 0으로 제한되어야 함
            student.ShowInfo();
            }
    }
}