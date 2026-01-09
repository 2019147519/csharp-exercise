using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // //배열 -> 효율적 

            // //방법 1
            // int[] scores = new int[5];   //5개의 사물함을 준비

            // //방법 2 초기값과 함께 선언
            // int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            // //방법 3: 간단한 초기화
            // int[] values = { 1, 2, 3, 4, 5 };

            // //4번째
            // scores[0] = 1;
            // scores[1] = 2;
            // scores[2] = 3;
            // scores[3] = 4;
            // scores[4] = 5;

            // for(int i =0; i<scores.Length; i++)
            // {
            //     Console.WriteLine(scores[i]);
            // }

            // //인벤토리 시스템 (최대 5개)
            // string[] inventory = new string[5];

            // //아이템 추가
            // for (int i = 0; i < inventory.Length; i++)
            // {
            //     Console.Write("아이템명 입력: ");
            //     string itemName = Console.ReadLine();
            //     inventory[i] = itemName;
            // }

            // //인벤토리 출력
            // Console.WriteLine("=== 인벤토리 ====");

            // for(int i =0; i <inventory.Length; i++)
            // {
            //     Console.WriteLine($"[{i + 1}] {inventory[i]}");
            // }

            // // 플레이어 스탯 배열
            // Console.WriteLine("=== 캐릭터 스탯===");
            // int[] stats = { 100, 50, 80, 60, 45 };
            // string[] statNames = { "HP", "MP", "공격력", "방어력", "민첩" };

            // for(int i =0; i<stats.Length; i++)
            // {
            //     Console.WriteLine($"{statNames[i]}: {stats[i]}");
            // }

            // Console.WriteLine("=== 일일 퀘스트 진행도 ===");
            // string[] quests = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            // int[] limits = { 5, 5, 5, 5, 5 };
            // int[] progresses = new int[quests.Length];
            // progresses[0] = 5;
            // progresses[1] = 3;
            // progresses[2] = 8;
            // progresses[3] = 2;
            // progresses[4] = 7;

            // for (int i = 0; i < quests.Length; i++)
            // {
            //     Console.Write($"{quests[i]}: {progresses[i]}/{limits[i]} ");
            //     if (progresses[i] >= limits[i])
            //     {
            //         Console.WriteLine("✅ 완료");
            //     }
            //     else
            //     {
            //         Console.WriteLine("⏳ 진행중");
            //     }
            // }

            // int[] scores = { 85, 92, 78, 95, 88 };

            // //배열 길이
            // Console.WriteLine("총 점수 개수: " + scores.Length);

            // //배열 순회
            // Console.WriteLine("개별 점수");
            // for(int i =0; i< scores.Length; i++)
            // {
            //     Console.WriteLine($"플레이어 {i + 1} : {scores[i]}점");
            // }


            // //합계 계산
            // int sum = 0;

            // for(int i =0; i<scores.Length; i++)
            // {
            //     sum += scores[i];
            // }

            // Console.WriteLine($"총점 : {sum}점");
            // Console.WriteLine($"평균 : {(float)sum / (float)scores.Length}점");


            // //최고점 찾기
            // int max = scores[0];
            // for (int i = 1; i < scores.Length; i++)
            // {
            //     if (scores[i] > max)
            //     {
            //         max = scores[i];
            //     }
            // }
            // Console.WriteLine($"최고점: {max}점");

            // //최저점 찾기
            // int min = scores[0];
            // for (int i = 1; i < scores.Length; i++)
            // {
            //     if (scores[i] < min)
            //     {
            //         min = scores[i];
            //     }
            // }
            // Console.WriteLine($"최저점: {min}점");

            // //Array 클래스 메서드 활용
            // Console.WriteLine("=== Array 메서드 ===");

            // //정렬
            // int[] sortedScores = (int[])scores.Clone();  //복사본 생성
            // Array.Sort(sortedScores);
            // Console.WriteLine("정렬 후: ");

            // //for (int i = 0; i < sortedScores.Length; i++)
            // //{
            // //    Console.WriteLine(sortedScores[i]);
            // //}

            // //반복문 foreach
            // foreach(int score in sortedScores)
            // {
            //     Console.WriteLine(score);
            // }




            // //85, 92, 78, 95, 88

            // //역순정렬
            // Array.Reverse(sortedScores);
            // Console.WriteLine("역순: ");

            // //for (int i = 0; i < sortedScores.Length; i++)
            // //{
            // //    Console.WriteLine(sortedScores[i]);
            // //}

            // foreach (int score in sortedScores)
            // {
            //     Console.WriteLine(score);
            // }

            //   //검색
            // int searchScore = 92;
            // int index = Array.IndexOf(scores, searchScore);
            // Console.WriteLine($"{searchScore}점의 위치: 인덱스 {index}");
            // Console.WriteLine("찾은값 : "+scores[index]);

            // 다차원배열 
            // #### 배열 크기 확인

            // int[,] array = new int[3, 4];

            // // 전체 요소 개수
            // int totalElements = array.Length;  // 12 (3 x 4)

            // // 특정 차원의 길이
            // int rows = array.GetLength(0);     // 3 (행 개수)
            // int cols = array.GetLength(1);     // 4 (열 개수)

            // // Rank: 배열의 차원 수
            // int dimensions = array.Rank;       // 2

            // string[,] seats =
            // {
            //     { "A1", "A2", "A3" },
            //     { "B1", "B2", "B3" },
            //     { "C1", "C2", "C3" }
            // };
            // for (int i = 0; i < seats.GetLength(0); i++)
            // {
            //     for (int j = 0; j < seats.GetLength(1); j++)
            //     {
            //         Console.Write($"[{seats[i, j]}]");
            //     }
            //     Console.WriteLine();
            // }

            // string[] names = { "김철수", "이영희", "박민수" };
            // string[] subjects = { "국어", "영어", "수학", "과학" };
            // int[,] grades = 
            // {
            //     { 85, 90, 88, 92 },  // 학생 1의 점수
            //     { 78, 85, 90, 87 },  // 학생 2의 점수
            //     { 92, 88, 95, 90 }   // 학생 3의 점수
            // };
            // Console.WriteLine("=== 성적표 ===");
            // Console.Write("이름\t");
            // for (int j = 0; j < subjects.Length; j++)
            // {
            //     Console.Write($"{subjects[j]}\t");
            // }
            // Console.WriteLine("평균");
            // Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            // for (int i = 0; i < grades.GetLength(0); i++)
            // {
            //     Console.Write($"{names[i]}\t");
            //     int sum = 0;
            //     for (int j = 0; j < grades.GetLength(1); j++)
            //     {
            //         Console.Write($"{grades[i, j]}\t");
            //         sum += grades[i, j];
            //     }
            //     float avg = (float)sum / grades.GetLength(1);
            //     Console.Write($"{avg:f1}\n");
            // }
            // Console.WriteLine("\n=== 과목별 평균===");
            // for (int j = 0; j < grades.GetLength(1); j++)
            // {
            //     int sum = 0;
            //     for (int i = 0; i < grades.GetLength(0); i++)
            //     {
            //         sum += grades[i, j];
            //     }
            //     float avg = (float)sum / grades.GetLength(0);
            //     Console.WriteLine($"{subjects[j]}: {avg:f1}점");
            // }

            // // 가변 배열
            // string[][] raid = new string[3][];

            // raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };  //4명
            // raid[1] = new string[] { "도적", "전사", "힐러" };            //3명
            // raid[2] = new string[] { "마법사", "궁수", "힐러", "전사", "탱커" }; //5명

            // Console.WriteLine("=== 레이드 파티 구성 ===");
            // for(int i =0; i< raid.Length; i++)
            // {
            //     Console.WriteLine($"파티 {i + 1} ({raid[i].Length}명):");
            //     for(int j=0; j< raid[i].Length; j++)
            //     {
            //         Console.WriteLine($" - {raid[i][j]}");
            //     }
            // }
            
            // // List
            // // 선언 방법
            // List<int> numbers = new List<int>();           // 빈 리스트
            // List<string> names = new List<string>();       // 문자열 리스트
            // List<float> prices = new List<float>();        // 실수 리스트

            // // 초기값과 함께 선언
            // List<int> scores = new List<int> { 85, 90, 78, 95 };
            // List<string> items = new List<string> { "검", "방패", "포션" };

            // // C# 3.0 이후 간단한 초기화
            // var players = new List<string> { "철수", "영희", "민수" };

            // // Add: 끝에 추가
            // items.Add("회복 포션");
            // items.Add("마나 포션");

            // //List 생성
            // List<string> inventory = new List<string>();

            // Console.WriteLine("=== 도적 인벤토리 시스템 ==");

            // //아이템 추가 (Add)
            // inventory.Add("회복 포션");
            // inventory.Add("마나 포션");
            // inventory.Add("강철 검");
            // Console.WriteLine("아이템 3개 추가");

            // //현재 인벤토리
            // Console.WriteLine($"인벤토리 ({inventory.Count}개):");

            // for (int i = 0; i < inventory.Count; i++)
            // {
            //     Console.WriteLine($"[{i}] {inventory[i]}");
            // }
            // Console.WriteLine();
            // inventory[0] = "초록포션";

            // for (int i = 0; i < inventory.Count; i++)
            // {
            //     Console.WriteLine($"[{i}] {inventory[i]}");
            // }
            // Console.WriteLine();
            // //특정 위치에 추가 (Insert)
            // inventory.Insert(1, "전설 검");

            // for (int i = 0; i < inventory.Count; i++)
            // {
            //     Console.WriteLine($"[{i}] {inventory[i]}");
            // }

            // //아이템 제거 (Remove)
            // inventory.Remove("초록포션");
            // Console.WriteLine();

            // for (int i = 0; i < inventory.Count; i++)
            // {
            //     Console.WriteLine($"[{i}] {inventory[i]}");
            // }

            // //인덱스로 제거 (RemoveAt)
            // inventory.RemoveAt(0);
            // Console.WriteLine();
            // for (int i = 0; i < inventory.Count; i++)
            // {
            //     Console.WriteLine($"[{i}] {inventory[i]}");
            // }

            //  Dictionary<string, int> stats = new Dictionary<string, int>();

            // // Dictionary
            // //데이터추가
            // stats.Add("HP", 150);
            // stats.Add("MP", 80);
            // stats.Add("공격력", 75);
            // stats.Add("방어력", 50);
            // stats.Add("민첩", 60);


            // Console.WriteLine("=== 캐릭터 스탯 ===");

            // foreach(KeyValuePair<string, int> stat in stats)
            // {
            //     Console.WriteLine($"{stat.Key}: {stat.Value}");
            // }

            // //키 존재 확인
            // string searchStat = "방어력";

            // if(stats.ContainsKey(searchStat))
            // {
            //     Console.WriteLine(stats[searchStat]);
            // }
            // else
            // {
            //     Console.WriteLine("해당스탯이 없습니다.");
            // }

            // List<string> inventory = new List<string>();
            // int gold = 600;
            // Dictionary<string, int> itemPrices = new Dictionary<string, int>()
            // {
            //     { "회복 포션", 50 },
            //     { "마나 포션", 40 },
            //     { "강철 검", 500 },
            //     { "가죽 갑옷", 300 },
            //     { "마법 반지", 1000 }
            // };
            // Console.WriteLine("=== 상점 아이템 ===");
            // foreach (var item in itemPrices)
            // {
            //     Console.WriteLine($"{item.Key}: {item.Value}골드");
            // }
            // // 강철 검 구매
            // string selectedItem = "강철 검";
            // if (itemPrices.ContainsKey(selectedItem))
            // {
            //     if (gold >= itemPrices[selectedItem])
            //     {
            //         gold -= itemPrices[selectedItem];
            //         inventory.Add(selectedItem);
            //         Console.WriteLine($"✅ '{selectedItem}' 구매 성공!");
            //         Console.WriteLine($"남은 골드: {gold}");
            //     }
            // }

            Console.SetWindowSize(80, 25); //콘솔 창 크기 설정
            Console.SetBufferSize(80, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; //배열 문자열로 그리기

            int playerX = 0;
            int playerY = 12;
            
            List<int[]> missiles = new List<int[]>(); // 미사일 좌표 리스트
            
            Console.CursorVisible = false; //콘솔창 커서 안보이게하기

            //지연방법 시간을 계산해서 1초 루프
            int dwTime = Environment.TickCount;   // 1/1000 초가 흐릅니다.

            while (true)
            {
                if(dwTime + 10 < Environment.TickCount)
                {
                    //현재 시간 세팅
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    //키영역
                    int pressKey; //정수형 변수 선언 키값 받을거임

                    if(Console.KeyAvailable) //키가 눌렸는지 체크
                    {
                        pressKey = _getch(); //키값 받기
                        if (pressKey == 224) //방향키는 2번 호출됨
                        {
                            pressKey = _getch(); //방향키 두번째 값 받기
                        }
                        switch(pressKey)
                        {
                           
                            case 72:  //위쪽방향 아스키코드                    
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;
                            case 75:
                                //왼쪽 화살표키
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:
                                //오른쪽
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80: //아래
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
                            case 32: //스페이스바 미사일 발사
                                missiles.Add(new int[] { playerX + 3, playerY + 1 });
                                break;
                        }
                    }

                    // 플레이어 그리기
                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }

                    // 미사일 그리기
                    for (int i = 0; i < missiles.Count; i++)
                    {
                        //미사일 좌표 가져오기
                        int missileX = missiles[i][0];
                        int missileY = missiles[i][1];

                        //미사일 그리기
                        Console.SetCursorPosition(missileX, missileY);
                        Console.WriteLine("-");

                        //미사일 이동
                        missiles[i][0] += 2; //x좌표 증가

                        //화면 밖으로 나가면 제거
                        if (missiles[i][0] >= 80)
                        {
                            missiles.RemoveAt(i);
                            i--; //인덱스 조정
                        }
                    }
                }
            }

        }
    }
}