using System;

namespace ConsoleApp14
{
    public class Monster
    {
        public INFO m_tMonster; // 몬스터 데이터
        public void SetDamage(int iAttack) { m_tMonster.iHP -= iAttack; }
        // INFO클래스 타입 인자로 몬스터 데이터를 넣어준다.
        public void SetMonster(INFO tMonster) { m_tMonster = tMonster; }
        public INFO GetMonster() { return m_tMonster; }
        public void Render()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("몬스터 이름: " + m_tMonster.strName);
            Console.WriteLine("체력: " + m_tMonster.iHP + "\t공격력: " + m_tMonster.iAttack);
        }
    }
}