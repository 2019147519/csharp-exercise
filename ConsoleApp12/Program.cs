using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    //부모클래스 : 기본 캐릭터
    class Character
    {
        //public ,private , protected  //상속이되어있는 자식이 사용가능하게 열어주는 접근제어자
        protected string name;
        protected int level;
        protected int hp;
        protected int maxHP;
        protected int attack;
        protected int defense;

        public Character(string name)
        {
            this.name = name;
            level = 1;
            maxHP = 100;
            hp = maxHP;
            attack = 30;
            defense = 20;

            Console.WriteLine($"캐릭터 {name} 생성!");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"HP : {hp}/{maxHP}");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defense}");
        }

    }

    //자식클래스 : 전사
    class Warrior : Character
    {
        private int rage; //전사만의 고유 속성

        public Warrior(string name) : base(name)
        {
            attack = 60;
            defense = 40;
            maxHP = 150;
            hp = maxHP;
            rage = 0;

            Console.WriteLine("직업 : 전사");
        }

        public override void ShowInfo()
        {
            base.ShowInfo(); //부모의 ShowInfo 호출
            Console.WriteLine($"분노 : {rage}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Warrior("홍길동");
            if (character is Warrior)
            {
                Warrior warrior = (Warrior)character;
                warrior.ShowInfo();
            }
            Warrior war = character as Warrior;
            if (war != null)
            {
                war.ShowInfo();
            }
        }
    }
}
