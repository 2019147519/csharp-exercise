using System;

namespace ConsoleApp14
{
    public class Player
    {
        public INFO m_tInfo;

        // 데미지를 입는 함수
        public void SetDamage(int iAttack) { m_tInfo.iHP -= iAttack; }
        // 플레이어 정보를 외부에서 볼 수 있는 함수
        public INFO GetInfo() { return m_tInfo; }
        // hp를 다시 설정해주는 함수
        public void SetHP(int iHP) { m_tInfo.iHP = iHP; }
        // 직업선택
        public void SelectJob()
        {
            m_tInfo = new INFO();
            Console.WriteLine("직업을 선택하세요(1.기사 2.마법사 3.도둑): ");
            int iInput = 0;
            iInput = int.Parse(Console.ReadLine());
            switch (iInput)
            {
                case 1:
                    m_tInfo.strName = "기사";
                    m_tInfo.iHP = 100;
                    m_tInfo.iAttack = 10;
                    break;
                case 2:
                    m_tInfo.strName = "마법사";
                    m_tInfo.iHP = 90;
                    m_tInfo.iAttack = 15;
                    break;
                case 3:
                    m_tInfo.strName = "도둑";
                    m_tInfo.iHP = 85;
                    m_tInfo.iAttack = 13;
                    break;
            }
        }
        public void Render()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("직업 이름: " + m_tInfo.strName);
            Console.WriteLine("체력: " + m_tInfo.iHP + "\t공격력: " + m_tInfo.iAttack);
        }
        public Player() { }  // 생성자
        ~Player() { }    // 소멸자
    }
}