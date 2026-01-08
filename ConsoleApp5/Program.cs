using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetWindowSize(80, 25); //콘솔 창 크기 설정 (가능 80, 세로 25)
            Console.SetBufferSize(81, 26); //버퍼 크기도 살짝 크게 (이모지 깨짐 방지)

            int x = 10, y = 10; //초기 좌표
            int direction = 3; //0:상, 1:하, 2:좌, 3:우\
            bool apple1 = true;
            bool apple2 = true;
            bool apple3 = true;
            bool apple4 = true;
            bool apple5 = true;
            bool apple6 = true;
            bool apple7 = true;
            bool apple8 = true;
            bool apple9 = true;
            bool apple10 = true;


            ConsoleKeyInfo keyInfo; //키관련된 정보

            Console.CursorVisible = false;

            while(true)
            {
                if (Console.KeyAvailable) //키가 눌렸다면
                {
                    keyInfo = Console.ReadKey(true); //키 입력 받기

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            direction = 0;
                            break;
                        case ConsoleKey.DownArrow:
                            direction = 1;
                            break;
                        case ConsoleKey.LeftArrow:
                            direction = 2;
                            break;
                        case ConsoleKey.RightArrow:
                            direction = 3;
                            break;
                    }
                }
                Console.Clear(); //화면 지우기
                // 맵 테두리 그리기
                for (int i = 0; i < 80; i++)
                {
                    Console.SetCursorPosition(i, 24);
                    Console.Write("🔥");
                }
                for (int i = 0; i < 25; i++)
                {
                    Console.SetCursorPosition(79, i);
                    Console.Write("🔥");
                }
                for (int i = 0; i < 25; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("🔥");
                }
                for (int i = 0; i < 80; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write("🔥");
                }
                // 사과 10개 그리기
                if (apple1) { Console.SetCursorPosition(30, 15); Console.Write("🍎"); }
                if (apple2) { Console.SetCursorPosition(50, 5); Console.Write("🍎"); }
                if (apple3) { Console.SetCursorPosition(20, 8); Console.Write("🍎"); }
                if (apple4) { Console.SetCursorPosition(60, 12); Console.Write("🍎"); }
                if (apple5) { Console.SetCursorPosition(10, 20); Console.Write("🍎"); }
                if (apple6) { Console.SetCursorPosition(70, 18); Console.Write("🍎"); }
                if (apple7) { Console.SetCursorPosition(40, 3); Console.Write("🍎"); }
                if (apple8) { Console.SetCursorPosition(25, 17); Console.Write("🍎"); }
                if (apple9) { Console.SetCursorPosition(55, 10); Console.Write("🍎"); }
                if (apple10) { Console.SetCursorPosition(15, 6); Console.Write("🍎"); }
                // 캐릭터 그리기
                switch (direction)
                {
                    case 0: //상
                        Console.SetCursorPosition(x, y);
                        Console.Write("😋");
                        break;
                    case 1: //하
                        Console.SetCursorPosition(x, y);
                        Console.Write("😋");
                        break;
                    case 2: //좌
                        Console.SetCursorPosition(x, y);
                        Console.Write("😋");
                        break;
                    case 3: //우
                        Console.SetCursorPosition(x, y);
                        Console.Write("😋");
                        break;
                }
                // 캐릭터 이동
                switch (direction)
                {
                    case 0: //상
                        y--;
                        break;
                    case 1: //하
                        y++;
                        break;
                    case 2: //좌
                        x--;
                        break;
                    case 3: //우
                        x++;
                        break;
                }
                // 벽 충돌시 게임 오버
                if (x <= 0 || x >= 79 || y <= 0 || y >= 24)
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 12);
                    Console.Write("게임 오버!");
                    break;
                }
                // 사과 먹기
                if (x == 30 && y == 15 && apple1) apple1 = false;
                else if (x == 50 && y == 5 && apple2) apple2 = false;
                else if (x == 20 && y == 8 && apple3) apple3 = false;
                else if (x == 60 && y == 12 && apple4) apple4 = false;
                else if (x == 10 && y == 20 && apple5) apple5 = false;
                else if (x == 70 && y == 18 && apple6) apple6 = false;
                else if (x == 40 && y == 3 && apple7) apple7 = false;
                else if (x == 25 && y == 17 && apple8) apple8 = false;
                else if (x == 55 && y == 10 && apple9) apple9 = false;
                else if (x == 15 && y == 6 && apple10) apple10 = false;
                // 게임 클리어
                if (!apple1 && !apple2 && !apple3 && !apple4 && !apple5 && !apple6 && !apple7 && !apple8 && !apple9 && !apple10)
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 12);
                    Console.Write("게임 클리어!");
                    break;
                }

                Thread.Sleep(200); //0.2초 대기
            }

        }
    }
}